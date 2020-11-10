using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTreats : MonoBehaviour
{
    public GameObject treat;
    private int xPos;
    private int zPos;
    public int treatNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        GenerateTreats();
    }

    void GenerateTreats()
    {
        while(treatNum < 11)
        {
            xPos = Random.Range(-120, 120);
            zPos = Random.Range(-120, 120);

            Instantiate(treat, new Vector3(xPos, 2, zPos), Quaternion.identity);

            treatNum++;
        }
    }
    
}
