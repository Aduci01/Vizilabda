using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SQLite4Unity3d;

public class DataBaseHandler : MonoBehaviour {

    private DataBase dataBase;
    public Text DebugText;

    // Use this for initialization
    void Start () {
        dataBase = new DataBase("activities.db");
	}

    void Update()
    {
        /*var activity = dataBase.GetActivities();
        ToConsole(activity);*/
    }

    public void createActivity()
    {
    }

    private void ToConsole(IEnumerable<Activity> a)
    {
        foreach (var activity in a)
        {
            ToConsole(activity.ToString());
        }
    }

    private void ToConsole(string msg)
    {
        DebugText.text += System.Environment.NewLine + msg;
        Debug.Log(msg);
    }

}
