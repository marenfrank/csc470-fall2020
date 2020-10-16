using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fall : MonoBehaviour
{
    public GameObject Broom;
    // Start is called before the first frame update
    void DeathFallFunction()
    {
        if(Broom.transform.position.y <= 10)
        {
            SceneManager.LoadScene("level1");
        }
    }
}