using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideEffect : MonoBehaviour
{

    public ParticleSystem explosion;
  

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Rock_4"|| other.transform.tag == "Rock_3"|| other.transform.tag == "Rock_2"|| other.transform.tag == "Rock_1")
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
        }
    }

}
