using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    private float timer = 0;
    private Text t;

    // Use this for initialization
    void Start()
    {
        t = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Door2"))
        {
            timer = 0;
            t.text = (int)timer + "";
        }
        else
        {
            timer += Time.deltaTime;
            t.text = (int)timer + "";
        }
    }

    public void Reset()
    {
        timer = 0;
    }
}