using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Damage : MonoBehaviour
{
    public Slider vidaPlayer;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player")
        {
            vidaPlayer.value--;
        }
    }
}
