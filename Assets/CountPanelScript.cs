using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountPanelScript : MonoBehaviour {
    private float timer = 0;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 25)
        {
            GetComponent<Image>().color = new Color(0, 0, 0, 0.596f);
        } else
        {
            GetComponent<Image>().color = Color.clear;
        }
    }
}
