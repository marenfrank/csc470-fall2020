using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Opening : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnMouseClick()
    {
        SceneManager.LoadScene("Start Animation");
    }
}
