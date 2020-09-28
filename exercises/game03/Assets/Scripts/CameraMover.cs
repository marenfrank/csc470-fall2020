using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector3(transform.position.x - speed, transform.position.y, transform.position.z);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - speed);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + speed);
        }
    }
}
