using UnityEngine;
using System.Collections;

public class destroy16 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.G))
        {
            Destroy(gameObject);
        }
    }
}