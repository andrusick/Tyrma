using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Feature.Loading
{
public class LoadingManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {
        yield return null;
    }
}
}
