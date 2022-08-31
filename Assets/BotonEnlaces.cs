using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonEnlaces : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Enlaces(string enlace)
    {
        Application.OpenURL(enlace);
    }
}
