using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ControladorNavMesh : MonoBehaviour
{

    [HideInInspector]
    public Transform perseguirObjetivo;

    private NavMeshAgent navMeshagent;

    private void Awake()
    {
        navMeshagent = GetComponent<NavMeshAgent>();
    }
    public void UpdatePointToDestinityNavMeshAgent(Vector3 destinyPoint)
    {
        navMeshagent.destination = destinyPoint;
        // navMeshagent.Resume();
        navMeshagent.isStopped = false;
    }

    public void UpdatePointToDestinityNavMeshAgent()
    {
        UpdatePointToDestinityNavMeshAgent(perseguirObjetivo.position);
    }

    public void StoppedNavMeshAgent()
    {
        navMeshagent.isStopped = true;
    }
    public bool HemosLLegado()
    {
        return navMeshagent.remainingDistance <= navMeshagent.stoppingDistance && !navMeshagent.pathPending;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
