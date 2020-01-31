using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movedown : MonoBehaviour
{
    public float speed = 5.0f;
    private float zDestroy = -15.0f;
    private Rigidbody objectRb;
    // Start is called before the first frame update
    void Start()
    {
        objectRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    //in update de snelheid van de autos en wawneer ze vernietigt worden en waneer de game is afgelopen
    void Update()
    {
        objectRb.AddForce(Vector3.forward * -speed);

        if (transform.position.z < zDestroy)
        {
            GameObject.Find("Spawn Manager").GetComponent<SpawnManager>().GameOver();
            Destroy(gameObject);
        }
    }
}
