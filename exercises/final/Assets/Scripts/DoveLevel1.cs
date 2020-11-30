using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoveLevel1 : MonoBehaviour
{
     public GameObject dove;
    public GameObject key; 
    private int xPos;
    private int zPos;
    public int doveNum = 0;
    

    void Start()
    {
        GenerateDoves();
        GenerateKey();
    }

    void GenerateDoves()
    {
        while(doveNum < 2)
        {
            xPos = Random.Range(-15, 15);
            zPos = Random.Range(-8, 8);

            Instantiate(dove, new Vector3(xPos, 3, zPos), Quaternion.identity);

            doveNum++;
        }
    }

    void GenerateKey()
    {
       
            xPos = Random.Range(-15, 15);
            zPos = Random.Range(-8, 8);

            Instantiate(key, new Vector3(xPos, 2, zPos), Quaternion.identity);

           
        
    }
}
