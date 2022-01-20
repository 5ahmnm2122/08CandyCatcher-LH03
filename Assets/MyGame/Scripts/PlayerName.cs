using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    public PlayerData data;

    public Text playerName;

    public void StartGame()
    {
        data.PlayerName = playerName.text;
    }

}
