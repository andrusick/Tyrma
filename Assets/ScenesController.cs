using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace Feature.Entrypoint
{

  

public class ScenesController : MonoBehaviour
{
    public static ScenesController Instance {get; private set; }
   protected void Awake()
   {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
            return;
        }
        Debug.Log("ScenesController inited");
   }

   public void LoadScene(string sceneName) => StartCoroutine(LoadSceneCoroutine(sceneName));

   private IEnumerator LoadSceneCoroutine(string sceneName)
   {
        if (isActiveAndEnabled)
        {
            PlayerPrefs.SetString("Scene", sceneName);
            yield return SceneManager.LoadSceneAsync("Loading");
        }
   }
}
}
