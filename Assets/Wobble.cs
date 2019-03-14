using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wobble : MonoBehaviour


	{
    public float startingMeter = 0;
    public float currentMeter;

    Animator Animator;

    Renderer rend;

    Vector3 lastPos;
    Vector3 velocity;
    Vector3 lastRot;
    Vector3 angularVelocity;
    public float MaxWobble = 0.03f;
    public float WobbleSpeed = 1f;
    public float Recovery = 1f;
    float wobbleAmountX;
    float wobbleAmountZ;
    float wobbleAmountToAddX;
    float wobbleAmountToAddZ;
    float pulse;
    float time = 0.5f;

    public Transform leader;
    public float followSharpness = 0.1f;

    Vector3 _followOffset;

    // Use this for initialization
    void Start()
    {
        rend = GetComponent<Renderer>();
        Animator = gameObject.GetComponent<Animator>();
        _followOffset = transform.position - leader.position;

       


    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Animator.SetTrigger("SpawnMeter");
        }

        if (Input.GetMouseButtonUp((0)))
        {
            Animator.SetTrigger("DeleteMeter");
        }

        time += Time.deltaTime;

        wobbleAmountToAddX = Mathf.Lerp(wobbleAmountToAddX, 0, Time.deltaTime * (Recovery));
        wobbleAmountToAddZ = Mathf.Lerp(wobbleAmountToAddZ, 0, Time.deltaTime * (Recovery));

        pulse = 2 * Mathf.PI * WobbleSpeed;
        wobbleAmountX = wobbleAmountToAddX * Mathf.Sin(pulse * time);
        wobbleAmountZ = wobbleAmountToAddZ * Mathf.Sin(pulse * time);

        currentMeter = startingMeter;
        rend.material.SetFloat("_FillAmount", currentMeter);

        rend.material.SetFloat("_WobbleX", wobbleAmountX);
        rend.material.SetFloat("_WobbleZ", wobbleAmountZ);

       
        velocity = (lastPos - transform.position) / Time.deltaTime;
        angularVelocity = transform.rotation.eulerAngles - lastRot;


     
        wobbleAmountToAddX += Mathf.Clamp((velocity.x + (angularVelocity.z * 0.2f)) * MaxWobble, -MaxWobble, MaxWobble);
        wobbleAmountToAddZ += Mathf.Clamp((velocity.z + (angularVelocity.x * 0.2f)) * MaxWobble, -MaxWobble, MaxWobble);

   
        lastPos = transform.position;
        lastRot = transform.rotation.eulerAngles;
    }

    public void TakeDamage(float enemyDamage)
    {
      
        currentMeter += enemyDamage;
        Debug.Log("TakeDamage");

    }


    void LateUpdate()
    {


        Vector3 targetPosition = leader.position + _followOffset;

       
        targetPosition.y = transform.position.y;

         
        transform.position += (targetPosition - transform.position);
    }

}
