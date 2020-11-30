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
    public Transform camera;
    public int jump = 10;

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
            target = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + camera.eulerAngles.y;
            transform.rotation = Quaternion.Euler(0f, target, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, target, 0f) * Vector3.forward;

            cc.Move(moveDir.normalized * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space) && cc.isGrounded)
        {
            Vector3 position = this.transform.position;
            position.y++;
        }


    }
}
