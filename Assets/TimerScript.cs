using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
            if(timer >= 300)
            {
                timer = 0;
                t.text = "GAME OVER, ta bien-aimée est morte";
                if(timer > 5)
                    SceneManager.LoadScene("Second Scene");
            }
        }
    }

    public void Reset()
    {
        timer = 0;
    }
}