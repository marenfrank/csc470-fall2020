using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WitchController : MonoBehaviour
{
    public float movementSpeed = 10;
    float rotateSpeed = 120f;
    private Rigidbody rb;
    public GameObject Rocks;
    GameObject forest;


    // Start is called before the first frame update
    void Start()
    {
        forest = GameObject.Find("Forest");
        rb = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        transform.Rotate(0, hAxis * rotateSpeed * Time.deltaTime, 0, Space.World);

        //jump!
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //random stars when you jump
            Vector3 pos = new Vector3(forest.transform.position.x + Random.Range(-10, 10)
                                    , forest.transform.position.y + 3,
                                    forest.transform.position.z + Random.Range(-10, 10));
            Instantiate(Rocks, pos, Quaternion.identity);
            Vector3 position = this.transform.position;
            position.y++;
            this.transform.position = position;

        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(transform.forward * Time.deltaTime * movementSpeed, Space.World);
        }





    }
}
