using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliverPrincessScript : MonoBehaviour {
    private void OnCollisionEnter(Collision c)
    {
        gameObject.transform.position = new Vector3(391.6f, 0.3f, 76.26f);
        GetComponent<SphereCollider>().radius = 0.9f;
        gameObject.tag = "Victoire";
    }
}
