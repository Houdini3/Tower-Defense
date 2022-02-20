 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviou : MonoBehaviour
{
    public float Speed = 1.0f;
    int waypointNumber = 0;

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        
        Vector3 currentWaypoint = PathwayLogic.Waypoints[waypointNumber];
        Vector3 moveVector = currentWaypoint - transform.position;
        float moveAmout = Mathf.Min(moveVector.magnitude, Speed * Time.fixedDeltaTime);
        Vector3 translateVector = moveVector.normalized * moveAmout;
        transform.Translate(translateVector, Space.World);

        if (moveVector.magnitude<=moveAmout)
        {
            waypointNumber += 1;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Exit"))
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
