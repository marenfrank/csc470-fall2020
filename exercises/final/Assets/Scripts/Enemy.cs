using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private NavMeshAgent mob;
    public GameObject player;

    public float mdr = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        mob = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);

        if(distance < mdr)
        {
            Vector3 dirToPlayer = transform.position - player.transform.position;
            Vector3 newPos = transform.position - dirToPlayer;

            mob.SetDestination(newPos);
        }
        
    }
}
