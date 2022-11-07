using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalCollider : MonoBehaviour
{
    public bool collicion = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
           collicion = true;
        }
    }
}
