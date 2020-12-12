using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class FinalScript : MonoBehaviour
{
    private NavMeshAgent Enemy;
    public GameObject Player;

    public float EnemyDistance = 6.0f;
    public int maxHealth = 100;
    public int currentHealth;
    public Healthbar healthBar;


    // Start is called before the first frame update
    void Start()
    {
        Enemy = GetComponent<NavMeshAgent>();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, Player.transform.position);

        if (distance < EnemyDistance)
        {
            Vector3 dirToPlayer = transform.position - Player.transform.position;
            Vector3 newPos = transform.position - dirToPlayer;

            Enemy.SetDestination(newPos);
        }

        if (currentHealth < 0)
        {
            SceneManager.LoadScene("Win");
        }

    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }


    void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.CompareTag("Dagger"))
        {

            TakeDamage(30);
            


        }
    }
    }
