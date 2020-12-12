using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private NavMeshAgent Ghost;
    public GameObject Player;

    public float GhostDistance = 6.0f;

    // Start is called before the first frame update
    void Start()
    {
        Ghost = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, Player.transform.position);

        if(distance < GhostDistance)
        {
            Vector3 dirToPlayer = transform.position - Player.transform.position;
            Vector3 newPos = transform.position - dirToPlayer;

            Ghost.SetDestination(newPos);
        }
        
    }
}
