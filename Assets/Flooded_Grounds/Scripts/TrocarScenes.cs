using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocarScenes : MonoBehaviour
{
    public string nomeDaCena;

    public void ChangeS()
    {
        SceneManager.LoadScene(nomeDaCena);
    }
    public void sair()
    {
        Application.Quit();
    }
}
