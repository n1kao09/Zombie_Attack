using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableEspadaCollider : MonoBehaviour
{
    [SerializeField]
    private SphereCollider sphere; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void enableEspadaCollider()
    {
        sphere.enabled = true;
    }
    
    public void disableEspadaCollider()
    {
        sphere.enabled = false;
    }
}
