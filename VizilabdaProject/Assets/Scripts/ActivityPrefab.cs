using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivityPrefab : MonoBehaviour {

    public string playerName, player2Name, activityName, goalType;
    public float playerX, playerY, ballX, ballY;

    public ActivityPrefab (string a, string b, string c, string d)
    {
        playerName = a;
        player2Name = b;
        activityName = c;
        goalType = d;
    }
}
