using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class KnifeRain : MonoBehaviour
{
    public GameObject Knife;
    GameObject park;
    float timeBetweenSpawns = 2.0f;
    private float counter = 0;
    public TextMeshProUGUI pointsText;
    private int points;
    public GameObject winTextObject;
    public GameObject loseTextObject;
    public GameObject skateboard;

    // Start is called before the first frame update
    void Start()
    {
        park = GameObject.Find("Park");
        points = -2;
        SetPoints();
        winTextObject.SetActive(false);
        loseTextObject.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        MakeRain();

        if (points < -1)
        {
            Vector3 directionToSkateboard = skateboard.transform.position - transform.position;
            directionToSkateboard = directionToSkateboard.normalized;

            transform.Translate(directionToSkateboard * Time.deltaTime * 6);
        }

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

    void SetPoints()
    {
        pointsText.text = "Points: " + points.ToString();

        if (points >= 12)
        {
            winTextObject.SetActive(true);
        }

        if (points < -1)
        {
            loseTextObject.SetActive(true);

        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            points += 1;
            SetPoints();
        }

        if (other.gameObject.CompareTag("Knife"))
        {
            Destroy(other.gameObject);
            points -= 1;
            SetPoints();
        }



    }

}
