using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneStart : MonoBehaviour
{
    // Start is called before the first frame update
    public void startbuttom()
    {
        SceneManager.LoadScene(1);
    
        var data = new Pressing()
        {
            target = name,
            wherePressed = transform.position,
            whereMouse = Input.mousePosition


        };
        TelemetryLogger.Log(this, "Press", data);
    }

    
    [System.Serializable]
    public struct Pressing
    {
        public string target;
        public Vector3 wherePressed;
        public Vector3 whereMouse;
    }
}
