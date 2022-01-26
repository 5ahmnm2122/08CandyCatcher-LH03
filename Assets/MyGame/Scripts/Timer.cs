using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private float timer = 25;
    private Text timerSeconds;
    public PlayerData data;
    public bool isPlaying;

    //Gets text field where the time is displayed in canvas
    void Start()
    {
        timerSeconds = GetComponent<Text>();
    }

    void Update()
    {
        //When the game is running, the timer counts downwards
        if (isPlaying)
        {
            timer -= Time.deltaTime;
            timerSeconds.text = timer.ToString("f1");
            data.timeScore = timer;

            //If the timer is less than 0, then the game is lost and the end scene is loaded
            if (timer <= 0)
            {
                SceneManager.LoadScene("EndScene", LoadSceneMode.Single);
                data.winStatus = "You lost: Time's up!";
            }
        }
    }
}
