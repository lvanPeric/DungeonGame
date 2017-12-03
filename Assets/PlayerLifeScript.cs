using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerLifeScript : LifeScript {
    private LifeScript life;
    private float timer = 0;
    private Text t;

    private void Start()
    {
        life = GetComponent<LifeScript>();
        t = GetComponent<Text>();
    }

    private void Update()
    {
        if (life.Pv <= 0)
        {
            timer += Time.deltaTime;
            t.text = "GAME OVER, Retente ta chance";
            if(timer >= 5)
                SceneManager.LoadScene("SecondScene");
        }
    }

    public override void Damage(int d)
    {
        base.Damage(d);
    }
}
