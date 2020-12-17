using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuel : MonoBehaviour
{

    [Header("Info")]
    public float current = 100f;

    [Header("Settings")]
    public float max = 100f;
    public float burnRate = 1f;

    void Update()
    {
        current -= burnRate * Time.deltaTime;

        if (current <= 0f)
        {

        }
    }

    void Refuel()
    {
        current = max;
    }
}