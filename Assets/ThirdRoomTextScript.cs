using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThirdRoomTextScript : MonoBehaviour {
    private float timer = 0;
    private Text t;

    private void Start()
    {
        t = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update () {
        if (GameObject.FindGameObjectWithTag("Door2"))
        {
            t.text = null;
        }
        else
        {
            timer += Time.deltaTime;
            if (timer < 10f && timer > 0f)
            {
                t.text = "Maintenant que vous avez tué les chevaliers, il est temps de délivrer votre bien-aimée en la trouvant dans la forêt mais faites attention à la terreur de la forêt";
            } else if (timer < 15f && timer > 10f)
            {
                t.text = "Vous avez 300 Secondes";
            } else {
                t.text = null;
            }
        }
    }
}
