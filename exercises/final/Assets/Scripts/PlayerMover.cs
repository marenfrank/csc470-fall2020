using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    // Start is called before the first frame update
    CharacterController cc;
    float xpos;
    float zpos;
    public int speed = 6;

    float target;

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();


    }

    // Update is called once per frame
    void Update()
    {

        xpos = Input.GetAxisRaw("Horizontal");
        zpos = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(xpos, 0f, zpos).normalized;

        if (direction.magnitude >= 0.1f)
        {
            target = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, target, 0f);

            cc.Move(direction * speed * Time.deltaTime);
        }

    }
}
