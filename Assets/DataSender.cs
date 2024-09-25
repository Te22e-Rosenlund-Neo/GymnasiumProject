using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.PlayerLoop;



public class DataSender : MonoBehaviour
{
    public string data1;
    public string data2;
    
    private string FormUrl = "LINK to google forms";


    public void SubmitFeedback(){

        StartCoroutine(Post(data1, data2));
            }


    private IEnumerator Post(string data1, string data2){

        WWWForm form = new WWWForm();
        form.AddField("entry.XXXXX", data1);
        form.AddField("entry.YYYYY", data2);

        using(UnityWebRequest www= UnityWebRequest.Post(FormUrl, form)){
            
            yield return www.SendWebRequest();

            if(www.result == UnityWebRequest.Result.Success){
                Debug.Log("Data sent successfully");
            }else{
                Debug.LogError("An error occurred:" + www.error);
            }
        }
    }







}
