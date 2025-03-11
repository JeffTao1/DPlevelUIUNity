using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField] float speed;
    float gowherex;
    float gowherey;
    [SerializeField] Rigidbody2D rb2d;


    // Start is called before the first frame update
    void Start()
    {

    }
    Vector3 _lastLogPosition;
    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(_lastLogPosition,transform.position)>1f)
        {
            TelemetryLogger.Log(this, "Move", transform.position);
            _lastLogPosition = transform.position;
        }
        gowherex = Input.GetAxis("Horizontal");
        gowherey = Input.GetAxis("Vertical");

        transform.Translate(gowherex * speed * Time.deltaTime, 0, 0);
        transform.Translate(0, gowherey * speed * Time.deltaTime, 0);

        
        
    }

}
