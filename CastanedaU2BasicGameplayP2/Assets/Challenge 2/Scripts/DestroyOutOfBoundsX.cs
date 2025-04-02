using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    public GameObject ground;
    private float leftLimit = -30;
    private float bottomLimit = -5;

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.z > bottomLimit)
        {
            //Destroy(gameObject);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
         if(other.gameObject == ground)
         {
            Destroy (gameObject);
         }
    }
}
