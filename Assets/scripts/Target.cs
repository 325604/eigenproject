using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public SpawnManager spawnManager;

    public int pointValue;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (spawnManager.isGameActive)
        {
            Destroy(gameObject);

            GameObject.Find("Spawn Manager").GetComponent<SpawnManager>().UpdateScore();
        }
    }
    //hier staat als je tegen een enemy aan komt dat je dat die dan verdwijnd 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
             Destroy(gameObject);
             spawnManager.GameOver();
        }
    }
    
}
