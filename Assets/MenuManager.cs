using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Feature.Entrypoint;

public class MenuManager : MonoBehaviour
{
    protected ScenesController scenesController;
    // Start is called before the first frame update
    void Start()
    {
        scenesController = GameObject.FindObjectOfType<ScenesController>();
        if (scenesController == null)
            Debug.LogError("Scene controller - null");
    }

    public void LoadLevel(string lvlName)
    {
        scenesController.LoadScene(lvlName);
        
    }

}
