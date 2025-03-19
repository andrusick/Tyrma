using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Feature.Entrypoint
{
public class EntryPoint : MonoBehaviour
{
    // Start is called before the first frame update
    protected void Awake()
    {
        StartCoroutine(InstantiateSceneController());

    }
    protected IEnumerator InstantiateSceneController()
    {
        var scenesController = new GameObject("ScenesController").AddComponent<ScenesController>();
        yield return Instantiate(scenesController);
        scenesController.LoadScene("Menu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}
