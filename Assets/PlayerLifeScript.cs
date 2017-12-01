using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            Destroy(gameObject);
        }
    }

    public override void Damage(int d)
    {
        base.Damage(d);
    }
}
