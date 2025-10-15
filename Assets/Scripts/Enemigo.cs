using UnityEngine;
using UnityEngine.AI;

public class Enemigo : MonoBehaviour
{
    private NavMeshAgent NavMeshAgent;
    private Transform PosicionJugador;

    void Start()
    {
        NavMeshAgent = GetComponent<NavMeshAgent>();
        PosicionJugador = FindAnyObjectByType<Esfera>().transform;
    }

    void Update()
    {
        NavMeshAgent.destination = PosicionJugador.position;
    }
}
