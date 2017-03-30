using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSelection : MonoBehaviour {

    public Text[] players1 = new Text[14], players2 = new Text[14];
    public Text team1, team2;

    public GameObject inGameMenu;

    private void SetPlayerNames()
    {
        for (int i = 0; i < 14; i++)
        {
            string name = "Player " + (i+1).ToString();
            GameObject.Find(name).GetComponentInChildren<Text>().text = players1[i].text;
            //if (players1[i].text == "") GameObject.Find(name).SetActive(false);
        }
        for (int i = 0; i < 14; i++)
        {
            string name = "2Player " + (i + 1).ToString();
            GameObject.Find(name).GetComponentInChildren<Text>().text = players2[i].text;
           // if (players2[i].text == "") GameObject.Find(name).SetActive(false);
        }
    }

    private void SetTeamNames()
    {
        team1.text = GameObject.Find("TeamName A").GetComponent<InputField>().text;
        team2.text = GameObject.Find("TeamName B").GetComponent<InputField>().text;
    }

    public void SetStuffs()
    {
        inGameMenu.SetActive(true);
        SetPlayerNames();
        SetTeamNames();
        GameObject.Find("PlayerSelection").SetActive(false);
    }


}
