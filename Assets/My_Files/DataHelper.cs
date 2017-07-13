using UnityEngine;
using System.Collections;
using UnityEngine.SocialPlatforms;
using System.Collections.Generic;
using GooglePlayGames;
using UnityEngine.UI;

public class DataHelper : MonoBehaviour{
    bool IsConnectedToGoogleServices;
    public Text LOg;
    void Awake()
    {
       
        PlayGamesPlatform.DebugLogEnabled = true;
    }
    
    public void Start()
    {
        PlayGamesPlatform.Activate();


       Social.localUser.Authenticate((bool success) =>
        {
            if (success)
            {
                LOg.text = "Success fully LOgged";
                Debug.Log("Success fully LOgged In");
                //Do Something
            }
            else
            {
                LOg.text = "Sorry, can't LOgged";
            }
        });
       
    }

    public bool ConnectToGoogleServices()
    {
        if (!IsConnectedToGoogleServices)
        {
            Social.localUser.Authenticate((bool success) =>
            {
                IsConnectedToGoogleServices = success;
            });
        }
        return IsConnectedToGoogleServices;
    }

    public void ToAchivement()
    {
        if (Social.localUser.authenticated)
        {
            Social.ShowAchievementsUI();
        }
        else
        {
            //show Error
        }
    }
}
