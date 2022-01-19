using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    private float timer = 10;
    private Text timerSeconds;


    void Start()
    {
        timerSeconds = GetComponent<Text>();
    }

    void Update()
    {
        timer -= Time.deltaTime;
        timerSeconds.text = timer.ToString("f1");

        if (timer <= 0)
        {
            Debug.Log("Endtime");
            //GameManager.instance.SaveScore();
            SceneManager.LoadScene("EndScene", LoadSceneMode.Single);
        }
    }
}
