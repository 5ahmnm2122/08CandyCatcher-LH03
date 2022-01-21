using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/DataSaver", order = 1)]
public class PlayerData : ScriptableObject
{
    public string playerName;
    public int score;
    public float timeScore;
    public string winStatus;
}
