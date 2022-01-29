using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        float currentSpeed = 0;
        if (Input.GetKey(KeyCode.W))
        {
            currentSpeed = speed;
        }
        float angle = transform.eulerAngles.y;
        float x = currentSpeed * Mathf.Sin(angle * Mathf.PI / 180f);
        float z = currentSpeed * Mathf.Cos(angle * Mathf.PI / 180f);
        rb.velocity = new Vector3(x, rb.velocity.y, z);
    }
    [SerializeField] float speed;
}
