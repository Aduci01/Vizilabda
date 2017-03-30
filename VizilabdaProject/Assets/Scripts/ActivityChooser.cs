using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivityChooser : MonoBehaviour {

    public GameObject chosen1, chosen2;
    public int whichTeam = -1;

    public GameObject goalScreen, mainScreen;
    public GameObject activityBar;
    public GameObject goalImage;

    public void ChoosePlayer1(GameObject obj)
    {
        if (chosen1 != null)
            chosen1.GetComponent<Image>().color = Color.white;
        chosen1 = obj;
        whichTeam = 1;
        chosen1.GetComponent<Image>().color = Color.green;
    }

    public void ChoosePlayer2(GameObject obj)
    {
        if (chosen2 != null)
            chosen2.GetComponent<Image>().color = Color.white;
        whichTeam = 2;
        chosen2 = obj;
        chosen2.GetComponent<Image>().color = Color.green;
    }

    public void onGoal()
    {
        goalScreen.SetActive(true);
        mainScreen.SetActive(false);
    }

    public void onGoalType(int type)
    {
        mainScreen.SetActive(true);
        var gb = Instantiate(goalImage);
        gb.transform.SetParent(activityBar.transform);
        gb.GetComponent<ActivityPrefab>().activityName = "gól";
        if (whichTeam == 1)
            gb.GetComponent<ActivityPrefab>().playerName = chosen1.GetComponentInChildren<Text>().text;
        if (whichTeam == 2) gb.GetComponent<ActivityPrefab>().playerName = chosen2.GetComponentInChildren<Text>().text;

        switch (type)
        {
            case 0:
                gb.GetComponent<ActivityPrefab>().goalType = "emberelőny";
                break;
            case 1:
                gb.GetComponent<ActivityPrefab>().goalType = "akciógól";
                break;
            case 2:
                gb.GetComponent<ActivityPrefab>().goalType = "megúszás";
                break;
            case 3:
                gb.GetComponent<ActivityPrefab>().goalType = "ziccer";
                break;
            case 4:
                gb.GetComponent<ActivityPrefab>().goalType = "szabaddobás";
                break;
        }
        goalScreen.SetActive(false);
    }
}
