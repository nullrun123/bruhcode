using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlineObject : MonoBehaviour
{
    public Material outlineMaterial; 

    private Material defaultMaterial; 
    private Renderer objectRenderer; 

    void Start()
    {
        objectRenderer = GetComponent<Renderer>(); 
        defaultMaterial = objectRenderer.material; 
    }

    void OnMouseEnter()
    {
        objectRenderer.material = outlineMaterial; 
    }

    void OnMouseExit()
    {
        objectRenderer.material = defaultMaterial; 
    }
}
