using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeginGameScript : MonoBehaviour {
    private float timer = 0;
    private Text t;

    // Use this for initialization
    void Start () {
        t = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if(timer < 10)
        {
            t.text = "Bonjour et bienvenue au jeu, les touches de contrôles sont Z Q S D pour bouger et clic gauche pour attaquer.";
        } else if (timer > 10 && timer < 17)
        {
            t.text = "Le but du jeu est de sauver ta bien-aimée capturée par des chevaliers et gardé par un monstre dans la forêt";
        } else if (timer > 17 && timer < 24)
        {
            t.text = "Pour commencer, tue les chevaux des chevaliers pour qu'ils ne puissent pas les utiliser, il y en a 5";
        } else
        {
            t.text = "";
        }
    }
}
