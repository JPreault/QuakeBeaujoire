using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballon : MonoBehaviour
{
    // Fonction lors de collision.
    private void OnCollisionEnter(Collision other) {

        // Destruction du ballon lors d'une collision
        Destroy(gameObject);
    }
}
