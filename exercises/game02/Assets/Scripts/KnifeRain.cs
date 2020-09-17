using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class KnifeRain : MonoBehaviour
{
    public GameObject Knife;
    GameObject park;
    float timeBetweenSpawns = 2.0f;
    private float counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        park = GameObject.Find("Park");
        

    }

    // Update is called once per frame
    void Update()
    {
        MakeRain();

    }

    void MakeRain()
    {
        counter += Time.deltaTime;
        if (counter > timeBetweenSpawns)
        {
            Vector3 pos = new Vector3(park.transform.position.x + Random.Range(-25, 25)
                                    , park.transform.position.y + 15,
                                    park.transform.position.z + Random.Range(-25, 25));
            Instantiate(Knife, pos, Quaternion.identity);

            counter = 0;
        }
        
    }

}
