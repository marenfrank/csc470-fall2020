using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalLevel : MonoBehaviour
{
    public void OnMouseClick()
    {
        SceneManager.LoadScene("Level 2");
    }

}
