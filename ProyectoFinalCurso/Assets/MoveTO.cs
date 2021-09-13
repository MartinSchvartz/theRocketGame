using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;

using UnityEngine;

public class MoveTO : MonoBehaviour {

    public Transform goal;
    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
    }


}
