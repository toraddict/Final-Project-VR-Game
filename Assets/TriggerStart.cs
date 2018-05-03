using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

/*
This message is sent to the trigger Collider and the Rigidbody(if any) that the trigger Collider belongs to, 
and to the Rigidbody(or the Collider if there is no Rigidbody) that touches the trigger.Notes: Trigger events
are only sent if one of the Colliders also has a Rigidbody attached.Trigger events will be sent to disabled
MonoBehaviours, to allow enabling Behaviours in response to collisions.OnTriggerEnter occurs on the FixedUpdate
after a collision. The Colliders involved are not guaranteed to be at the point of initial contact.*/

public class Trigger
{
    public class trigger : MonoBehaviour
    {
        public virtual void OnTriggerEnter(Collider other)
        {
            Destroy(other.gameObject);
        }
    }
}

