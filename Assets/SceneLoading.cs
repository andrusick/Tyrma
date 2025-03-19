using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SceneLoading : MonoBehaviour
{
    [SerializeField] private Slider _progressBar;

    [SerializeField] private const string MENU_SCENE_NAME = "Menu";
    
    void Start() => StartCoroutine(LoadScene());

    private IEnumerator LoadScene()
    {
        Debug.Log("Loading...");
        string sceneName = MENU_SCENE_NAME;
        if (PlayerPrefs.HasKey("Scene"))
        {
            sceneName = PlayerPrefs.GetString("Scene");
        }
        
        AsyncOperation loadConcreteSceen = SceneManager.LoadSceneAsync(sceneName);
        loadConcreteSceen.allowSceneActivation = false;

        while (!loadConcreteSceen.isDone)
        {
            _progressBar.value = loadConcreteSceen.progress;

            loadConcreteSceen.allowSceneActivation = loadConcreteSceen.progress >= 0.9f;

            yield return null;
        }

    }
}
