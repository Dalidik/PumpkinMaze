using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI_Monster : MonoBehaviour
{
    public NavMeshAgent AI_Agent;
    private GameObject Player;
    

    public Transform[] WayPoints;
    private int Current_Patch;
    
    public enum AI_State { Patrol, Chase };
    public AI_State AI_Enemy;
   
    public AudioClip ChaseSound;
    AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
        AI_Agent = gameObject.GetComponent<NavMeshAgent>();
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    void FixedUpdate()
    {
        
        if (AI_Enemy == AI_State.Patrol )
        {
           
            AI_Agent.speed = 3.5f;
            gameObject.GetComponent<Animator>().SetBool("Patrol", true);
            gameObject.GetComponent<Animator>().SetBool("Run", false);
            AI_Agent.SetDestination(WayPoints[Current_Patch].transform.position);
            float Patch_Dist = Vector3.Distance(WayPoints[Current_Patch].transform.position, gameObject.transform.position);
            if (Patch_Dist < 2)
            {
                Current_Patch++;
                Current_Patch = Current_Patch % WayPoints.Length;
            }
        }
        
        if (AI_Enemy == AI_State.Chase )
        {
            
            source.PlayOneShot(ChaseSound);
            AI_Agent.speed = 4.8f;
            gameObject.GetComponent<Animator>().SetBool("Run", true);
            gameObject.GetComponent<Animator>().SetBool("Patrol", false);
            AI_Agent.SetDestination(Player.transform.position);
        }


        float Dist_Player = Vector3.Distance(Player.transform.position, gameObject.transform.position);
        
    }
}
