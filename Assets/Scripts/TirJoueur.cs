using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TirJoueur : MonoBehaviour
{
    public GameObject Ballon;
    public Transform joueur;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Lorsque le joueur clique sur la touche E ou le clique gauche de la souris, le joueur tir.
        if(Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Mouse0)) {
            GameObject goBallon = Instantiate(Ballon, joueur.position, joueur.rotation);
            Rigidbody rbTir = goBallon.GetComponent<Rigidbody>();
            rbTir.velocity = 20f * joueur.forward;
        }
    }
}
