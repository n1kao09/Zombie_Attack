using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegarItens : MonoBehaviour
{
    public Transform espada;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "player")
        {
            
        }
    }

}
