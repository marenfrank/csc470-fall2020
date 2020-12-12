using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
	public GameObject keyPanel;
	public GameObject KeyManager;
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("KeyManager"))
		{

			Destroy(this.gameObject);
			KeyManager.SetActive(false);
			keyPanel.SetActive(false);


		}

	}
}
