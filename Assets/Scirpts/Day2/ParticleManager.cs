using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    private ParticleSystem fireFlies;
    // Start is called before the first frame update
    void Start()
    {
       fireFlies = GetComponentInChildren<ParticleSystem>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
