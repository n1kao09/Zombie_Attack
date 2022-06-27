



using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combo : MonoBehaviour
{
    Animator animator;

    public Transform PontoAtaque;
    public float distanciaAtaque = 0.5f;
    public LayerMask enermyLayers;
    public int DanoAtaque = 20;

    int clicar; 
    bool podes_clicar; 

    void Start()
    {
        animator = GetComponent<Animator>();
        clicar = 0;
        podes_clicar = true;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) { Iniciar_combo(); }
    }

    void Iniciar_combo()
    {
        if (podes_clicar)
        {
            clicar++;
        }

        if (clicar == 1)
        {
            animator.SetInteger("ataque", 1);
        }
    }

    public void Verificar_combo()
    {

        podes_clicar = false;

        if (animator.GetCurrentAnimatorStateInfo(0).IsName("ataque_1") && clicar == 1)
        {
            animator.SetInteger("ataque", 0);
            podes_clicar = true;
            clicar = 0;
        }
        else if (animator.GetCurrentAnimatorStateInfo(0).IsName("ataque_1") && clicar >= 2)
        {       
            animator.SetInteger("ataque", 2);
            podes_clicar = true;
        }
        else if (animator.GetCurrentAnimatorStateInfo(0).IsName("ataque_2") && clicar == 2)
        {       
            animator.SetInteger("ataque", 0);
            podes_clicar = true;
            clicar = 0;
        }
        else if (animator.GetCurrentAnimatorStateInfo(0).IsName("ataque_2") && clicar >= 3)
        {       
            animator.SetInteger("ataque", 3);
            podes_clicar = true;
        }
        else if (animator.GetCurrentAnimatorStateInfo(0).IsName("ataque_3"))
        {      
            animator.SetInteger("ataque", 0);
            podes_clicar = true;
            clicar = 0;
        }
        atacar();
    }

    public void atacar()
    {
        Collider[] hitEnemies = Physics.OverlapSphere(PontoAtaque.position, distanciaAtaque, enermyLayers);

        foreach(Collider enemy in hitEnemies)
        {
            enemy.GetComponent<Enemy>().TakeDamage(DanoAtaque);
        }
    }

    public void OnDrawGizmosSelected()
    {
        if (PontoAtaque == null) 
        return;

        Gizmos.DrawWireSphere(PontoAtaque.position, distanciaAtaque);
    }
}
