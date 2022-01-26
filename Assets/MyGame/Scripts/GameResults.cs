using UnityEngine;
using UnityEngine.UI;

public class GameResults : MonoBehaviour
{
    public Text playerName;
    public Text result;
    public Text score;
    public Text time;
    public PlayerData data;

    //Take over input from inputfield and intitialise game results: score, time score and win status
    void Start()
    {
        playerName.text = data.playerName;
        score.text = data.score.ToString() + " / 40";
        result.text = data.winStatus;
        time.text = data.timeScore.ToString("f1");
    }

}
