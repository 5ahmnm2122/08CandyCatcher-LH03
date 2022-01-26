using UnityEngine;

//Scriptable Object to save data over multiple scenes 
[CreateAssetMenu(fileName = "Player Data", menuName = "ScriptableObjects/PlayerData", order = 1)]
public class PlayerData : ScriptableObject
{
    public string playerName;
    public int score;
    public float timeScore;
    public string winStatus;
}
