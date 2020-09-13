using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public float time;
    public int Count;
    bool End=false;
    public Text timetext;

    // Update is called once per frame
    void Update()
    {
        if (End == false)
        {
            time += Time.deltaTime;
            timetext.text = time.ToString("N2");
        }

        if (End == true)
        {
            timetext.text = time.ToString("N2");
        }



    }
}
