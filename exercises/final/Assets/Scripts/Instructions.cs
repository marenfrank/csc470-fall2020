﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Instructions : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnMouseClick()
    {
        SceneManager.LoadScene("Level 1");
    }
}

