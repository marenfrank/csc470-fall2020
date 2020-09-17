using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 10;
    float rotateSpeed = 120f;
    public TextMeshProUGUI pointsText;
    private int points;
    public GameObject winTextObject;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        points = 0;
        SetPoints();
        winTextObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        transform.Rotate(0, hAxis * rotateSpeed * Time.deltaTime, 0, Space.World);

        //jump!
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector3 position = this.transform.position;
            position.y++;
            this.transform.position = position;
        }
        
        if(Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
        }


}

        void SetPoints()
        {
        pointsText.text = "Points: " + points.ToString();

        if(points >= 12)
        {
            winTextObject.SetActive(true);
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

    }
}
