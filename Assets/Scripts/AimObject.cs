using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimObject : MonoBehaviour
{
    private Vector2 rotation;
    [SerializeField] Vector2 rotationSpeed;
    [SerializeField] Transform playerCenterPosition;

    //半径
    private float r = 5;
    //ラジアン
    private float deg = 0;


    // Start is called before the first frame update
    void Start()
    {
        rotation = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rotation += new Vector2(rotationSpeed.x, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rotation -= new Vector2(rotationSpeed.x, 0);
        }

        //位置確定
        Vector3 diff = new Vector3(
            0,
            r * Mathf.Sin(rotation.x * Mathf.PI / 180f),
            r * Mathf.Cos(rotation.x * Mathf.PI / 180f));
        transform.position = playerCenterPosition.position + diff;
    }
}