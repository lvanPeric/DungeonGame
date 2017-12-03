﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginBackGroundScript : MonoBehaviour {
    private float timer = 0;
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer > 24.5f)
            Destroy(gameObject);
    }
}
