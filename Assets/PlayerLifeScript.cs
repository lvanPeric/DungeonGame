using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLifeScript : LifeScript {
    private LifeScript life;

    private void Start()
    {
        life = GetComponent<LifeScript>();
    }

    private void Update()
    {
        if (life.Pv <= 0)
        {
            SceneManager.LoadScene("SecondScene");
        }
    }

    public override void Damage(int d)
    {
        base.Damage(d);
    }
}
