using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class DeathState : AIState
{
    public AIStateID GetID()
    {
        return AIStateID.DeathState;
    }
    public void Enter(AIAgent agent)
    {
        agent.ragdoll.ActivateRagdoll();
        // agent.gameObject.SetActive(false);
        // agent.gameObject.SetActive(true);
        agent.mesh.updateWhenOffscreen = true;
        agent.healthBar.gameObject.SetActive(false);
        agent.bodyIK.enabled = false;
    }
    public void Update(AIAgent agent)
    {

    }
    public void Exit(AIAgent agent)
    {

    }
}