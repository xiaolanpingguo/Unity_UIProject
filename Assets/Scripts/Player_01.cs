﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_01 : MonoBehaviour
{
    public float speed = 90;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * speed);
    }

    public void ChangeSpeed(float newSpeed)
    {
        speed = newSpeed;
    }
}
