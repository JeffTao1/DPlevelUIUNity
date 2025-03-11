using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SessionDisplay : MonoBehaviour
{
    public void OnConnectionSuccess(int sessionID)
    {
        TryGetComponent(out TextMeshProUGUI display);
        if(sessionID < 0)
        {
            display.text = $"Logging locally (Session{sessionID})";
        }
        else
        {
            display.text = $"Connected to Server session( {sessionID})";
        }
       
    }

    public void OnConnectionFail(string error)
    {
        var displayField =  TryGetComponent(out TextMeshProUGUI display);
        display.text = $"Error to server: {error}";
    }
}
