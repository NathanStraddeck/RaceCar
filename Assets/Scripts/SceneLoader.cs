using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    public void OpenShop()
    {
        StartCoroutine(LoadSceneAsync("Shop"));
    }


    public void OpenMenu()
    {
        StartCoroutine(LoadSceneAsync("Menu"));
    }

    public void BackToMenu()
    {
        StartCoroutine(LoadSceneAsync(0));
    }

    public void OpenRecords()
    {
        StartCoroutine(LoadSceneAsync("Records"));
    }

    IEnumerator LoadSceneAsync(int index)
    {
        AsyncOperation op = SceneManager.LoadSceneAsync(index);

        while (!op.isDone)
        {
            yield return null;
        }
    }

    IEnumerator LoadSceneAsync(string sceneName)
    {
        AsyncOperation op = SceneManager.LoadSceneAsync(sceneName); 

        while (!op.isDone)
        {
            yield return null;
        }
    }
}
   


