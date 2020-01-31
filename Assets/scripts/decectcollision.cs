using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decectcollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
//waneer een opject er langs is dan wort het vernietigt 
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(transform.name);
        Destroy(gameObject);

    }
}
