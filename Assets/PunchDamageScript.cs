using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PunchDamageScript : LifeScript {
    LineRenderer line;

    // Use this for initialization
    void Start()
    {
        line = GetComponent<LineRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, 5) && hit.collider.gameObject.tag == "Horse")
            {
                line.enabled = true;
                hit.collider.GetComponent<LifeScript>().Damage(5);
            }
            else
            {
                line.enabled = false;
            }
        }

        if (!GameObject.FindGameObjectWithTag("Horse"))
        {
            SceneManager.LoadScene("SecondScene");
        }
    }
}   
