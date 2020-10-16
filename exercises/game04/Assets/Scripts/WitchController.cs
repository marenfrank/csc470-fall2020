using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WitchController : MonoBehaviour
{
    public float movementSpeed = 10;
    float rotateSpeed = 120f;
    private Rigidbody rb;
    GameObject forest;
    public GameObject GhostPrefab;

    private int lives = 3;
    public Text livesText;
    public GameObject LoseTextObject;
    public GameObject WinTextObject;


    // Start is called before the first frame update
    void Start()
    {
        forest = GameObject.Find("Forest");
        rb = GetComponent<Rigidbody>();

        SetLives();
        LoseTextObject.SetActive(false);
        WinTextObject.SetActive(false);


        for (int i = 0; i < 5; i++)
        {
            // Choose a random position over the terrain
            float x = Random.Range(Terrain.activeTerrain.transform.position.x, Terrain.activeTerrain.transform.position.x + Terrain.activeTerrain.terrainData.size.x);
            float z = Random.Range(Terrain.activeTerrain.transform.position.z, Terrain.activeTerrain.transform.position.z + Terrain.activeTerrain.terrainData.size.z);
            Vector3 pos = new Vector3(x, 0, z);
            // Use sample height at that position to find out what y should be.
            float y = Terrain.activeTerrain.SampleHeight(pos);
            pos.y = y;
            // Instantiate the tree at that position.
            GameObject Ghost = Instantiate(GhostPrefab, pos, Quaternion.identity);


        }

    }

    // Update is called once per frame
    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        transform.Rotate(0, hAxis * rotateSpeed * Time.deltaTime, 0, Space.World);

        //jump!
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            Vector3 position = this.transform.position;
            position.y++;
            this.transform.position = position;

        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(transform.forward * Time.deltaTime * movementSpeed, Space.World);
        }





    }

    public void SetLives()
    {
        livesText.text = "Lives - " + lives.ToString();

        if (lives < 0)
        {
            LoseTextObject.SetActive(true);

            SceneManager.LoadScene("level2");
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ghost"))
        {

            Destroy(other.gameObject);
            lives = -1;
            SetLives();
        }

        if (other.CompareTag("bone"))
        {
            WinTextObject.SetActive(true);
            Destroy(other.gameObject);
            SceneManager.LoadScene("StartScene");

        }
    }
}