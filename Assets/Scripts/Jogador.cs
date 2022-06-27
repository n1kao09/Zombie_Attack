using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Jogador : MonoBehaviour
{
    public Slider vidaPlayer;
   // public int vida = 100;
    void Awake()
    {
        transform.tag = "Player";
        
    }
    private void Update()
    {
        if(vidaPlayer.value <= 0)
        {
            vidaPlayer.value = 0;
            Morte();
        }
    }


    public void Morte()
    {
        SceneManager.LoadScene("GameOver");
   
    }


}
