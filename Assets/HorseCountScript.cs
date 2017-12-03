using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HorseCountScript : MonoBehaviour {
    private float timer = 0;
    private Text t;
    private int compteur;

    // Use this for initialization
    void Start () {
        t = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        compteur = 5 - GameObject.FindGameObjectsWithTag("Horse").Length;

        timer += Time.deltaTime;
        if(timer >= 25)
        {
            t.text = "Chevaux tués : " + (int)compteur;
        }
    }
}
