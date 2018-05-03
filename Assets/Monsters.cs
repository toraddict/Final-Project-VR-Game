using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class monsters : MonoBehaviour
{
    //declare the transform of our goal (where the navmesh agent will move towards) and our navmesh agent (in this case our zombie)
    public Transform goal;
    public NavMeshAgent agent;

    // Use this for initialization
    virtual public void Start()
    {
        //create references
        goal = Camera.main.transform;
        agent = GetComponent<NavMeshAgent>();
        //set the navmesh agent's desination equal to the main camera's position (our first person character)
        agent.destination = goal.position;
        //start the walking animation
        GetComponent<Animation>().Play("walk");

    }

}
