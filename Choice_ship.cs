using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choice_ship : MonoBehaviour
{
    public int ch_ship;
    bool left_state;
    bool right_state;

    // Start is called before the first frame update
    void Start()
    {
        ch_ship = 0;
        left_state = false;
        right_state = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnClick_right()
    {
        ch_ship++;

        if (ch_ship == 4)
            ch_ship = 0;
        
    }

    public void OnClick_left()
    {
        ch_ship--;
        if (ch_ship == -1)
            ch_ship = 3;

    }

    public void SetShipValue()
    {
        PlayerPrefs.SetInt("ship_number", ch_ship);
    }
}
