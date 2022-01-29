using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimObject : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    private Vector3 setPosition;
    private Vector3 moveOffsetY;

    //半径
    private float r = 5;
    //ラジアン
    private float deg = 0;


    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position + player.transform.position;
        moveOffsetY = new Vector3(0, 0.3f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            deg += 3f;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            deg -= 3f;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            offset += moveOffsetY;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            offset -= moveOffsetY;
        }
        setPosition.x = player.transform.position.x - r * Mathf.Cos(Mathf.Deg2Rad * deg);
        setPosition.y = player.transform.position.y - offset.y;
        setPosition.z = player.transform.position.z - r * Mathf.Sin(Mathf.Deg2Rad * deg);
        transform.position = setPosition;
    }
}