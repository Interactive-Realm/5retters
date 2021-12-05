using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProduktInfo : MonoBehaviour
{
    public ProductRecipe opskrift;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<MeshFilter>().mesh = opskrift.model;
        this.GetComponent<MeshRenderer>().material = opskrift.material;
        this.GetComponent<MeshCollider>().sharedMesh = opskrift.model;
    }
}
