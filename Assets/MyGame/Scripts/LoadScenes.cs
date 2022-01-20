using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
    public void MainScene()
    {
        SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
    }

    public void IntroScene()
    {
        SceneManager.LoadScene("IntroScene", LoadSceneMode.Single);
    }
}
