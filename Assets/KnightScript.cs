using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class KnightScript : LifeScript {
    private NavMeshAgent agent;
    public Transform Destination;

    // Use this for initialization
    void Start () {
        agent = GetComponent<NavMeshAgent>();
    }
	
	// Update is called once per frame
	void Update () {
        if (GameObject.FindGameObjectWithTag("Player"))
            agent.destination = Destination.position;
        else
            agent.destination = transform.position;
    }

    public override void Damage(int d)
    {
        base.Damage(d);
        if (Pv <= 0)
        {
            GetComponent<BoxCollider>().enabled = false;
            GetComponent<NavMeshAgent>().enabled = false;
            Destroy(this);
            gameObject.tag = "Untagged";
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<LifeScript>())
        {
            collision.gameObject.GetComponent<LifeScript>().Damage(5);
        }
    }
}
