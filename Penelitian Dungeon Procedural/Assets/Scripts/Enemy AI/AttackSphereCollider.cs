using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSphereCollider : MonoBehaviour
{
    AIAgent agent;

    private void Start()
    {
        agent = GetComponentInParent<AIAgent>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player in Attack Range");
            agent.isInAttackRange = true;

            agent.stateMachine.ChangeState(AIStateID.AttackState);
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player not in Attack Range");
            agent.isInAttackRange = false;
            agent.stateMachine.ChangeState(AIStateID.ChasePlayer);
        }

    }
}