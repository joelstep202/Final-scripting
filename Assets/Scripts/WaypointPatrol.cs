using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WaypointPatrol : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public Transform[] waypoints;
    public Transform player;

    public Observer observer;

    int m_CurrentWaypointIndex;

    void Start ()
    {
        navMeshAgent.SetDestination (waypoints[0].position);
    }

    void Update ()
    {
        if (observer.detected == false)
        {
            if (navMeshAgent.remainingDistance < navMeshAgent.stoppingDistance)
            {
                m_CurrentWaypointIndex = (m_CurrentWaypointIndex + 1) % waypoints.Length;
                navMeshAgent.SetDestination(waypoints[m_CurrentWaypointIndex].position);
            }
        }
        else
        {
            navMeshAgent.SetDestination(player.position);
        }
    }
}
