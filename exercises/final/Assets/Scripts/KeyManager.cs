using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour
{
	public GameObject keyManager;
	public GameObject keyPanel;

	public void OnMouseClick()
	{
		KeyOn();
		keyPanel.SetActive(false);
	}
	public void KeyOn()
	{
		keyManager.SetActive(true);

	}

}
