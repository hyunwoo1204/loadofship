using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    public Slider i;

    // Update is called once per frame
    void Update()
    {

        if (i.value <0.1)
            SceneManager.LoadScene("GameOver");
    }
}
