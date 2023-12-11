using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnnemiTouch : MonoBehaviour
{
    // Instanciation des variables
    public GameObject Ballon;

    // Start is called before the first frame update
    void Start(){}

    // Update is called once per frame
    void Update()
    {
        
    }

    // Fonction lors de collision 
    private void OnCollisionEnter(Collision other) 
    {
        // Collision avec un obus
        if(other.gameObject.tag == "Ballon")
        {
            //Le gameObject est ensuite détruit après avoir été remplacer par un tank cassé.
            Destroy(gameObject);
        }

        if(other.gameObject.tag == "Soccer")
        {
            //Le gameObject est ensuite détruit après avoir été remplacer par un tank cassé.
            Destroy(other.gameObject);
        }
    }
}
