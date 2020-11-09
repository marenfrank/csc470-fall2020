using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
	public int maxHealth = 100;
	public int currentHealth;
	private int points = 0;
	public Text pointsText; 

	public Healthbar healthBar;

	// Start is called before the first frame update
	void Start()
	{
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
		SetPoints();
	}

	// Update is called once per frame
	void Update()
	{
		if (currentHealth == 0)
        {
			SceneManager.LoadScene("Lose");
		}
	}

	void TakeDamage(int damage)
	{
		currentHealth -= damage;

		healthBar.SetHealth(currentHealth);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Cop"))
		{
			TakeDamage(20);
		}

		if (other.gameObject.CompareTag("Treat"))
		{
			Destroy(other.gameObject);
			points += 1;
			SetPoints();
		}



	}

	public void SetPoints()
	{
		pointsText.text = "Treats: " + points.ToString();

		if (points == 10)
		{
			SceneManager.LoadScene("Win");
		}

	}


}
