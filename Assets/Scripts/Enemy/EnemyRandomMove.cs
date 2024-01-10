using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Timeline;
using UnityEngine.UI;
using static Unity.VisualScripting.Member;

public class EnemyRandomMove : MonoBehaviour
{
    public NavMeshAgent agent;
    public float range; 
    public Transform centrePoint; 

    public Animator animator;
    

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

    }


    void Update()
    {
       
        if (agent.remainingDistance <= agent.stoppingDistance) 
        {
            Vector3 point;
            if (RandomPoint(centrePoint.position, range, out point)) 
            {
                Debug.DrawRay(point, Vector3.up, Color.blue, 1.0f); 
                agent.SetDestination(point);
            }
        }

    }
    bool RandomPoint(Vector3 center, float range, out Vector3 result)
    {

        Vector3 randomPoint = center + Random.insideUnitSphere * range;  
        NavMeshHit hit;
        if (NavMesh.SamplePosition(randomPoint, out hit, 1.0f, NavMesh.AllAreas)) 
        {
            animator.SetTrigger("Walk");
           
            result = hit.position;
            return true;
        }

       
        result = Vector3.zero;
        return false;
    }

    
        
            
}
