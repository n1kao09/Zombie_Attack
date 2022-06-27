using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public int vidaMax= 100;
    int vidaAtual;

    public Animator anim;
    void Start()
    {
        vidaAtual = vidaMax;
    }

    public void TakeDamage(int dano)
    {
        vidaAtual -= dano;

        anim.SetTrigger("Hurt");

        if( vidaAtual <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Debug.Log("Inimigo Morreu");
        anim.SetBool("Die", true);

        GetComponent<BoxCollider>().enabled = false;
        this.enabled = false;

    }

}
