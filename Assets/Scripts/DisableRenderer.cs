using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableRenderer : MonoBehaviour {
   
    void Start()
    {
         GetComponent<Renderer>().enabled = false;

    }

    // Update is called once per frame
    void Update () {
		
	}
}
