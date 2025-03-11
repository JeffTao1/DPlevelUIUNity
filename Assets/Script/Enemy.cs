using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        var data = new KillEventData()
        {
            target = name,
            targetPos = transform.position,
            KillerPos = gameObject.transform.position


        };
        TelemetryLogger.Log(this, "Kill",transform.position);
    }
    [System.Serializable]
    public struct KillEventData 
    {
        public string target;
        public Vector3 targetPos;
        public Vector3 KillerPos;
    }

}
