﻿using UnityEngine;
using System.Collections;

public class destroy1 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            Destroy(gameObject);
        }
    }
}