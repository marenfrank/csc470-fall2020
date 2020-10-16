using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    GameObject witch;
    public bool chase = true;
    // Start is called before the first frame update
    void Start()
    {
        witch = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {
        if (chase)
        {
            Vector3 directionToPlayer = witch.transform.position - transform.position;
            directionToPlayer = directionToPlayer.normalized;


            transform.Translate(directionToPlayer * Time.deltaTime * 6);
        }
       
    }
}
