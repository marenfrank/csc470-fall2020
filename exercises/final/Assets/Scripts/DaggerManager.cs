using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaggerManager : MonoBehaviour
{
	public GameObject daggerPanel;
	public GameObject WeaponManager;
	public void OnMouseClick()
	{
		
		daggerPanel.SetActive(false);
	}

	public void DaggerOn()
    {
		WeaponManager.SetActive(true);

	}

}
