using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    CharacterController cc;
   

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
      
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveVector = Vector3.zero;

        moveVector.x = Input.GetAxis("Horizontal") * 10;
        moveVector.z = Input.GetAxis("Vertical") * 10;

        cc.Move(moveVector * Time.deltaTime);
    }

  
}
