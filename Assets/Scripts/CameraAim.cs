using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAim : MonoBehaviour
{
    public GameObject player,aimObject;
    private Vector3 offset;
    private Vector3 setPosition;
    [SerializeField] Transform playerCenterPosition;

    //半径
    private float r;
    //ラジアン
    private float deg = 0;
    // Start is called before the first frame update
    void Start()
    {
        r = Mathf.Sqrt((playerCenterPosition.position.x * playerCenterPosition.position.x) +
            (playerCenterPosition.position.z * playerCenterPosition.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        /*setPosition.x = player.transform.position.x + r * Mathf.Cos(Mathf.Deg2Rad * deg);
        setPosition.y = player.transform.position.y + offset.y;
        setPosition.z = player.transform.position.z + r * Mathf.Sin(Mathf.Deg2Rad * deg);
        transform.position = setPosition;
        transform.LookAt(aimObject.transform);*/
        transform.LookAt(aimObject.transform);
        float rotationY = aimObject.GetComponent<AimObject>().rotation.y;
        Vector3 diff = new Vector3(
           r * Mathf.Sin(rotationY * Mathf.PI / 180f+Mathf.PI), transform.position.y-playerCenterPosition.position.y, r * Mathf.Cos(rotationY * Mathf.PI / 180f + Mathf.PI));
        transform.position = playerCenterPosition.position + diff;
    
    }
}
