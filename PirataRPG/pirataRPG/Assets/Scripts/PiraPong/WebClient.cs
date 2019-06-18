using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class NewBehaviourScript : MonoBehaviour
{
    string url = "https://isc2103-2018-2019rpgwebapi.azurewebsites.net/api/Scores";
    GlobalScript globalScript;

    // Start is called before the first frame update

    private class Score {

        public int IdScore;
        public string PlayerName;
        public double score;
    }

    private void Awake() {
        var globalScript = Camera.main.GetComponent<GlobalScript>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            StartCoroutine("SendRquest");
        }
         if (Input.GetButtonDown("Fire3"))
        {
            StartCoroutine("SendPostRequest");
        }
    }
    IEnumerator SendRquest(string url)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(url))
        {
            yield return webRequest.SendWebRequest();
            Debug.Log(webRequest.downloadHandler.text);
        }
    }

    /*IEnumerator SendPostRequest(string url)
    {
        
        Score newScore = new Score { PlayerName = "Leonardo", score = global.leftScore };
        www.UnityWebRequest.Put(url, JsonUtility.ToJson(newScore));
        www.SetRequestHeader("content-type", "application/json");

        yield return www.downloadHandler.text);
        
        Debug.Log("www.donwloadHandler.text");
    }*/

    IEnumerator Upload() {
        List<IMultipartFormSection> formData = new List<IMultipartFormSection>();
        formData.Add( new MultipartFormDataSection("field1=foo&field2=bar") );
        formData.Add( new MultipartFormFileSection("my file data", "myfile.txt") );

        UnityWebRequest www = UnityWebRequest.Post("http://www.my-server.com/myform", formData);
        yield return www.SendWebRequest();
 
        if(www.isNetworkError || www.isHttpError) {
            Debug.Log(www.error);
        }
        else {
            Debug.Log("Form upload complete!");
        }
    }

}
