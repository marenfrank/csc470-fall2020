using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 10;
    float rotateSpeed = 120f;
    private Rigidbody rb;
    public GameObject Star;
    GameObject park;
    

    // Start is called before the first frame update
    void Start()
    {
        park = GameObject.Find("Park");
        rb = GetComponent<Rigidbody>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        transform.Rotate(0, hAxis * rotateSpeed * Time.deltaTime, 0, Space.World);

        //jump!
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            //random stars when you jump
            Vector3 pos = new Vector3(park.transform.position.x + Random.Range(-10, 10)
                                    , park.transform.position.y + 3,
                                    park.transform.position.z + Random.Range(-10, 10));
            Instantiate(Star, pos, Quaternion.identity);
            Vector3 position = this.transform.position;
            position.y++;
            this.transform.position = position;
            
        }
        
        if(Input.GetKey(KeyCode.Space))
        {
            transform.Translate(transform.forward * Time.deltaTime * movementSpeed, Space.World);
        }

        
       


}

       



    }

