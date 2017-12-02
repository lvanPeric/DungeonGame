﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseScript : LifeScript {
    public override void Damage(int d)
    {
        base.Damage(d);
        if(Pv <= 0)
        {
            gameObject.tag = "Untagged";
            Destroy(gameObject);            
        }
    }
}
