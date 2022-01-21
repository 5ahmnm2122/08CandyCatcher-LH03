using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    private float timer = 25;
    private Text timerSeconds;
    public PlayerData data;
    public bool isPlaying;

    void Start()
    {
        timerSeconds = GetComponent<Text>();
    }

    void Update()
    {
        if (isPlaying)
        {
            timer -= Time.deltaTime;
            timerSeconds.text = timer.ToString("f1");
            data.timeScore = timer;

            if (timer <= 0)
            {
                SceneManager.LoadScene("EndScene", LoadSceneMode.Single);
                data.winStatus = "You lost: Time's up!";
            }
        }
    }
}
