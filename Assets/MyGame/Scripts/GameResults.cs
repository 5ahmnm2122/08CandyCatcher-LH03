using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameResults : MonoBehaviour
{
    public Text playerName;
    public Text result;
    public Text score;
    public Text time;
    public PlayerData data;

    void Start()
    {
        playerName.text = data.playerName;
        score.text = data.score.ToString() + " / 40";
        result.text = data.winStatus;
        time.text = data.timeScore.ToString("f1");
    }

}
