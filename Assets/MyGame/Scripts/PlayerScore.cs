using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScore : MonoBehaviour
{
    public PlayerData data;
    public Text scoreText;
    public Text playerName;

    //Initialises score with 0 and takes over existing player name 
    void Start()
    {
        playerName.text = data.playerName;
        data.score = 0;
    }

    //Transfers score value to text field in canvas
    void Update()
    {
        scoreText.text = data.score.ToString();
        
        //When negative score then the game is lost and end scene is loaded
        if (data.score < 0)
        {
            SceneManager.LoadScene("EndScene", LoadSceneMode.Single);
            data.winStatus = "You lost: Negative points!";
        }
        //When score is higher than 40 then the game is won and end scene is loaded 
        if (data.score >= 40)
        {
            SceneManager.LoadScene("EndScene", LoadSceneMode.Single);
            data.winStatus = "You won!";
        }
    }
}
