using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class InimigoSeguir : MonoBehaviour
{
    
    private GameObject player;
    private bool PodeAtacar;
    //public float distanciaMinima = 1.3f;
    private NavMeshAgent navMeshAgent;

    private void Start()
    {
        PodeAtacar = true;
        player = GameObject.FindWithTag("Player");
        navMeshAgent = GetComponent<NavMeshAgent>();
        //navMeshAgent.stoppingDistance = distanciaMinima;
     
    }
    void Update()
    {
        navMeshAgent.destination = player.transform.position;
        if (Vector3.Distance(transform.position, player.transform.position) < 1.5f)
        {
            Atacar();
        }
    }
    void Atacar()
    {
        if(PodeAtacar == true)
        {
            StartCoroutine("TempoDeAtaque");
        }
    }

    IEnumerator TempoDeAtaque()
    {
        PodeAtacar = false;
        yield return new WaitForSeconds(1);
        PodeAtacar = true;
        player.GetComponent<Jogador>().vidaPlayer.value -= 2;
    }

}
