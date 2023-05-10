using UnityEngine;
using System.Collections;
using Steamworks;
using System.Text;
using System;

public class SteamScript : MonoBehaviour
{
    void Start()
    {
        if (SteamManager.Initialized)
        {
            AppsflyerSteamModule afm = new AppsflyerSteamModule("DEV_KEY", "STEAM_APP_ID", this);
            afm.Start();
            // //set event name
            string event_name = "af_purchase";
            //set json string
            string event_values =
                "{\"af_currency\":\"USD\",\"af_price\":6.66,\"af_revenue\":24.12}";
            afm.LogEvent(event_name, event_values);
        }
        else
        {
            Debug.LogError("Steam Client is not running");
        }
    }

    private void Update() { }
}
