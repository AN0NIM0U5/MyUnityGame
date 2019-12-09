using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    Transform enemy;
    Transform player;
    NavMeshAgent nav;
    public Transform goal;
    public bool enter;
    public bool exit;
    public bool inside;
    public bool outside;

    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
        //nav.SetDestination(player.position);
    
    }
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag ("Player").transform;
        nav = GetComponent<NavMeshAgent>();
        enemy = GameObject.FindGameObjectWithTag("Enemy").transform;
        enter = enemy.GetComponentInChildren<BoxCollider>();       
    
    }
    void Update()
    {
        //nav.SetDestination(player.position); 
        AlertEnemy();
    
    }
    void AlertEnemy()
    {
        
       // nav.SetDestination(player.position);
        if (enter == true)
        {
         //   nav.SetDestination(player.position);
        } 
    
    }
    private void OnTriggerEnter(Collider boxCollider)
    {
        if (boxCollider.gameObject.CompareTag("Player")&& enabled) { 
        Debug.Log("colisionn");
            nav.SetDestination(player.position);
        }
    }

   
}
