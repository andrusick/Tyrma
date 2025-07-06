using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    protected int sceneIndex = 3;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<PlayerController>().enabled = false;
            GetComponent<Patrolling>().enabled = false;
            StartCoroutine(isDeath());
        }
        
        
    }
    IEnumerator isDeath()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneIndex); 
    }
}
