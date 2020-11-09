using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UsernameManager : MonoBehaviour
{
    public string dogName;
    public GameObject inputfeild;
    public GameObject textDisplay;

    public GameObject textBox;
    public GameObject button;

    public void StoreName()
    {
        dogName = inputfeild.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = "Say hello to your dog " + dogName;


    }
}
