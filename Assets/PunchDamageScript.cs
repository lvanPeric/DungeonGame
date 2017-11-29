using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchDamageScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
            GetComponent<LifeScript>().Damage(5);
    }

    void onMouseOver()
    {
        if (gameObject.tag == "horse")
        {
            if (Input.GetMouseButtonDown(0))
            {
                GetComponent<LifeScript>().Damage(5);
            }
        }
    }
}
