using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAim : MonoBehaviour
{
    public GameObject player,aimObject;
    private Vector3 offset;
    private Vector3 setPosition;

    //半径
    private float r = 5;
    //ラジアン
    private float deg = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        setPosition.x = player.transform.position.x + r * Mathf.Cos(Mathf.Deg2Rad * deg);
        setPosition.y = player.transform.position.y + offset.y;
        setPosition.z = player.transform.position.z + r * Mathf.Sin(Mathf.Deg2Rad * deg);
        transform.position = setPosition;
        transform.LookAt(aimObject.transform);
    }
}
