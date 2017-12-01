using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondLevelDoor : MonoBehaviour {
    public GameObject g;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
            Destroy(gameObject);
    }
}
