using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour {

    public Animator transitionAnim;
    public GameObject text;
    void Start()
    {
        
    }



    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(text);
            StartCoroutine(LoadScene());
        }

    }

    IEnumerator LoadScene()
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(3.2f);
        Debug.Log("Load");
        SceneManager.LoadScene("Level2");
        
    }
}
