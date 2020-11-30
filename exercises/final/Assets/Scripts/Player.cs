using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
	public int maxHealth = 100;
	public int currentHealth;
	public Healthbar healthBar;

	// Start is called before the first frame update
	void Start()
	{
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);

	}

	// Update is called once per frame
	void Update()
	{
		if (currentHealth == 0)
		{
			SceneManager.LoadScene("Lose");
		}
		if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit))
			{

				if (hit.collider.gameObject.CompareTag("Potion"))
				{

					Destroy(hit.collider.gameObject);
					currentHealth += 20;
					healthBar.SetHealth(currentHealth);
				}
			}

		}

	}

	void TakeDamage(int damage)
	{
		currentHealth -= damage;

		healthBar.SetHealth(currentHealth);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Ghost"))
		{

			TakeDamage(20);


		}
	}

} 
