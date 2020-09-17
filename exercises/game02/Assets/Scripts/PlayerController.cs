using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 10;
    float rotateSpeed = 120f;
    private int count;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        transform.Rotate(0, hAxis * rotateSpeed * Time.deltaTime, 0, Space.World);

        //jump!
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector3 position = this.transform.position;
            position.y++;
            this.transform.position = position;
        }
        
        if(Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
        }





}

        void OnTriggerEnter(Collider other)
        {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            count += 1;
        }

    }
}
