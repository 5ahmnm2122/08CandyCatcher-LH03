using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScore : MonoBehaviour
{
    public PlayerData data;
    public Text scoreText;
    public Text playerName;

    void Start()
    {
        playerName.text = data.PlayerName;
        data.score = 0;
    }

    private void Update()
    {
        scoreText.text = data.score.ToString();
        
        //Lose game when negative score
        if (data.score < 0)
        {
            SceneManager.LoadScene("EndScene", LoadSceneMode.Single);
            data.winStatus = "You lost: Negative points!";
        }
        if (data.score >= 25)
        {
            SceneManager.LoadScene("EndScene", LoadSceneMode.Single);
            data.winStatus = "You won!";
        }
    }

    }
