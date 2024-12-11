using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PatrolAI : MonoBehaviour
{

    public Transform[] waypoints;
    [SerializeField] private float sightDistance = 5f;
    [SerializeField] private LayerMask playerLayer;
    private int currentWayPointIndex;
    private NavMeshAgent agent;

    public GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        
        
        
        if (waypoints.Length > 0 )
        {
            agent.SetDestination(waypoints[0].position);
        }
    }

    // Update is called once per frame
    void Update()
    {
        bool playerInRange = Physics.CheckSphere(transform.position, sightDistance, playerLayer);

        if(playerInRange)
        {
            Debug.Log("Attack!");
            ChaseMode();
        }
        else
        {
            Debug.Log("Patrolling");
            PatrolMode();
        }
        
    }

    private void ChaseMode()
    {
        
        agent.SetDestination(player.transform.position);
    }
    private void PatrolMode()
    {
        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            currentWayPointIndex = (currentWayPointIndex + 1) % waypoints.Length;
            agent.SetDestination(waypoints[currentWayPointIndex].position);
        }
    }
}
