using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavigationSupporter : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent agent;
    private GameObject CurrentTarget;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
        GameObject[] go = GameObject.FindGameObjectsWithTag("Soccer");
        
        CurrentTarget = go[0];
        foreach (GameObject g in go)
        {
            if(Vector3.Distance(g.transform.position, agent.transform.position) < Vector3.Distance(CurrentTarget.transform.position, agent.transform.position))
            {
                Debug.Log(g.name);
                CurrentTarget = g;
            }
        }
        agent.destination = CurrentTarget.transform.position;
    }
}
