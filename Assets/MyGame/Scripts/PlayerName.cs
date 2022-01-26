using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    public PlayerData data;
    public Text playerName;

    //Save player name in scriptable object
    public void StartGame()
    {
        data.playerName = playerName.text;
    }
}
