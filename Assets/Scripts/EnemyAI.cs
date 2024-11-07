using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public Transform target;
    [SerializeField]
    private NavMeshAgent agent;
    void Start() 
    {
        transform.rotation = Quaternion.Euler( 0, transform.eulerAngles.y, 0 );
    }

    void Update()
    {  
        Vector3 direction = Vector3.Normalize(transform.position - target.position);
        Vector3 destination = target.position + direction * 2;
        agent.speed = System.Math.Max(Vector3.Distance(direction, transform.position), 2.5f); // im dalej tym szybciej (najwolniej 2.5)
        agent.SetDestination(destination);
    }
}
