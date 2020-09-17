using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public GameObject coins; 
    // Start is called before the first frame update
    void Start()
    {
        coins = GameObject.Find("Coins");  
    }

    // Update is called once per frame
    void Update()
    {
        coins.transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime);
    }
}
