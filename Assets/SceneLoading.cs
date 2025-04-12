using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SceneLoading : MonoBehaviour
{
    [SerializeField] private Slider _progressBar;

    [SerializeField] private const string MENU_SCENE_NAME = "Menu";
    [SerializeField] protected Text loading;
    
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

            loading.text = $"{(int)(loadConcreteSceen.progress * 100)}%";

            loadConcreteSceen.allowSceneActivation = loadConcreteSceen.progress >= 0.9f;

            yield return new WaitForSeconds(0.5f);
        }

    }
}
