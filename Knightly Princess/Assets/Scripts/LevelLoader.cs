using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    public Animator transition;
    public float transitionTime = 1f;

    public void Start()
    {
        Application.targetFrameRate = 60;

    }

    public void PlayGame()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void Retry()
    {
        StartCoroutine(LoadLevel(2));
    }

    public void LoadMenu()
    {
        StartCoroutine(LoadLevel(0));
    }


    public void LoadCave()
    {
        StartCoroutine(LoadLevel(5));
    }

    public void LoadMain()
    {
        StartCoroutine(LoadLevel(2));
    }


    public IEnumerator LoadLevel(int levelindex)
    {
        transition.SetTrigger("FadeStart");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelindex);
    }

}