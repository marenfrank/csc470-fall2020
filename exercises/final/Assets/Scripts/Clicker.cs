using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Clicker : MonoBehaviour
{
	private int points = 0;
	public Text pointsText;

	// Start is called before the first frame update
	void Start()
	{
		SetPoints();
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit))
			{

				if (hit.collider.gameObject.CompareTag("Dove"))
				{
					
					Destroy(hit.collider.gameObject);
					points++;
					SetPoints();

				}

			}
		}
	}

	void SetPoints()
	{
		pointsText.text = points.ToString();
		if(points == 12)
        {
			SceneManager.LoadScene("Level 2 Instructions");
		}
		
	}
}



