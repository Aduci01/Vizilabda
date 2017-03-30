using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DownloadImage : MonoBehaviour {

    public string url = "http://waterpolo.hu/jatekos/6089";

    IEnumerator Start()
    {

        Texture2D tex;
        tex = new Texture2D(4, 4, TextureFormat.DXT1, false);

            WWW www = new WWW(url);
            yield return www;

        Debug.Log(GetPlayerName(www.text));
        Debug.Log(GetClubName(www.text));

        WWW imageWWW = new WWW(GetImageLink(www.text));
        yield return imageWWW;
        imageWWW.LoadImageIntoTexture(tex);
        Rect rec = new Rect(0, 0, tex.width, tex.height);
        Sprite spriteToUse = Sprite.Create(tex, rec, new Vector2(0.5f, 0.5f), 100);
        GetComponent<Image>().sprite = spriteToUse;


    }

    private string GetPlayerName(string a)
    {
        string name = "";
        int start = a.IndexOf("&nbsp;&nbsp;") + 12;

        do
        {
            name += a[start];
            start++;
        } while (!a[start].Equals('&') && start < a.Length - 1);

        name += " ";

        start += 6;

        do
        {
            name += a[start];
            start++;
        } while (!a[start].Equals('<') && start < a.Length - 1);
        return name;
    }

    private string GetImageLink(string a)
    {
        string name = "http://uvr.mvlsz.webpont.com/php/jatekoskepek/";
        int start = a.IndexOf("jatekoskepek") + 13;
        
        do
        {
            name += a[start];
            start++;
        } while (!a[start].Equals('g') && start < a.Length - 1);
        name += a[start];
        Debug.Log(name);
        return name;
    }

    private string GetClubName(string a)
    {
        string name = "";
        int start = a.IndexOf("csapat/") + 7;
       // Debug.Log(a);

        do
        {
            start++;
        } while (!a[start].Equals('>') && start < a.Length - 1);

        start++;
        do
        {            
            name += a[start];
            start++;
        } while (!a[start].Equals('<') && start < a.Length - 1);
        return name;
    }

}
