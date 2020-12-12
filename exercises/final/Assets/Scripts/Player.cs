using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{

	public GameObject keyPanel;
	public GameObject potionPanel;
	public GameObject daggerPanel;
	public int maxHealth = 100;
	public int currentHealth;
	public Healthbar healthBar;
	
	

	// Start is called before the first frame update
	void Start()
	{
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
		keyPanel.SetActive(false);
		potionPanel.SetActive(false);
		daggerPanel.SetActive(false);

		

	}

   

    // Update is called once per frame
    void Update()
	{
		if (currentHealth < 0)
		{
			SceneManager.LoadScene("Lose");
		}
		

       

	}

	void TakeDamage(int damage)
	{
		currentHealth -= damage;

		healthBar.SetHealth(currentHealth);
	}

	void  IncreaseHealth(int health)
    {
		currentHealth += health;
		healthBar.SetHealth(currentHealth);
	}

	void OnTriggerEnter(Collider other)
	{
		

		if (other.gameObject.CompareTag("Ghost"))
		{
			other.GetComponent<AudioSource>().Play();
			TakeDamage(20);
			Destroy(other.gameObject, 3);


		}

		if (other.gameObject.CompareTag("Key"))
		{

			keyPanel.SetActive(true);
			Destroy(other.gameObject);


		}
		if (other.gameObject.CompareTag("Dagger"))
		{

			daggerPanel.SetActive(true);
			Destroy(other.gameObject);


		}

		if (other.gameObject.CompareTag("Potion"))
		{

			potionPanel.SetActive(true);
			Destroy(other.gameObject);


		}

		if (other.gameObject.CompareTag("Enemy"))
		{

			TakeDamage(40);


		}
	}
	public void OnMouseClick()
	{
		IncreaseHealth(20);
		potionPanel.SetActive(false);
	}


} 
