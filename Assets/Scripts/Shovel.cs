﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shovel : MonoBehaviour
{
    [SerializeField]
    GameObject kohle;
    // Im Erfolgsfall ist other = kohlehaufen
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Kohlehaufen")
        {
            kohle.SetActive(true);
        }
        else if (other.tag == "Ofen")
        {
            kohle.SetActive(false);
        }
    }
}
