using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaquinaDeEstados : MonoBehaviour
{

    public MonoBehaviour EstadoPatrulla;
    public MonoBehaviour EstadoAlerta;
    public MonoBehaviour EstadoPersecucion;
    public MonoBehaviour EstadoInicial;

    private MonoBehaviour estadoActual;
    // Start is called before the first frame update
    void Start()
    {
        ActivarEstado(EstadoInicial);
    }

    // Update is called once per frame
    void ActivarEstado(MonoBehaviour newState)
    {
        if(estadoActual!=null) estadoActual.enabled = false;
        estadoActual = newState;
        estadoActual.enabled = true;
       

    }
}
