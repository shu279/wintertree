using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimObject : MonoBehaviour
{
    public Vector2 rotation;
    [SerializeField] Vector2 rotationSpeed;
    [SerializeField] Transform playerCenterPosition;
    [SerializeField] float maxRotationX;

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
        if (Input.GetKey(KeyCode.UpArrow) && rotation.x<maxRotationX)
        {
            rotation += new Vector2(rotationSpeed.x, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow) && rotation.x>maxRotationX*-1)
        {
            rotation -= new Vector2(rotationSpeed.x, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rotation += new Vector2(0, rotationSpeed.y);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rotation -= new Vector2(0, rotationSpeed.y);
        }

        //位置確定
        Vector3 diff = new Vector3(
            r * Mathf.Sin(rotation.y * Mathf.PI / 180f),
            r * Mathf.Sin(rotation.x * Mathf.PI / 180f),
            r * Mathf.Cos(rotation.x * Mathf.PI / 180f)+ r* Mathf.Cos(rotation.y * Mathf.PI / 180f)
            );
        transform.position = playerCenterPosition.position + diff;
    }
}