using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ControladorVision : MonoBehaviour
{
    public Transform Ojos;
    public float rangovision = 0f;
    public Vector3 offset = new Vector3(0f, 0.1f, 0f);
    private ControladorNavMesh controladorNavMesh;

    private void Awake()
    {
        controladorNavMesh = GetComponent<ControladorNavMesh>();
    }
    public bool CanViewPlayer(out RaycastHit hit, bool lookToPlayer)
    {
        Vector3 direccion;
        if (lookToPlayer)
        {
         // direction = controladorNavMesh.perseguirObjetivo + offset) - Ojos.position;
            //direccion = controladorNavMesh.perseguirObjetivo;
          
        }
        else
        {
            direccion = Ojos.forward;
        }
        return Physics.Raycast(Ojos.position, Ojos.forward, out hit, rangovision) && hit.collider.CompareTag("Player");
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
