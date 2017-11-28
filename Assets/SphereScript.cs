using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour {

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.localPosition += new Vector3(Time.deltaTime*8, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.localPosition += new Vector3(-Time.deltaTime*8, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.localPosition += new Vector3(0, 0, Time.deltaTime*8);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.localPosition += new Vector3(0, 0, -Time.deltaTime*8);
        }
    }
}
