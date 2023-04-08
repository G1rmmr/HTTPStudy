using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Networking;

public class Network : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(UnityWebRequestGet());
    }

    IEnumerator UnityWebRequestGet()
    {
        string APIKey = "BjCO551GevqdwoKRrFy142OiFn7oZFrK";

        string jobId = "41f1cdc2ff58bb5fdc287be0db2a8df3";
        string jobGrowId = "df3870efe8e8754011cd12fa03cd275f";

		string URL = $"https://api.neople.co.kr/df/skills/{jobId}?jobGrowId={jobGrowId}&apikey=" + APIKey;

        WWW WWW = new WWW(URL);
        yield return WWW;

        if(WWW.error == null)
        {
            Debug.Log(WWW.text);
        }
        else
        {
			Debug.Log("DEBUG");
		}
    }
}
