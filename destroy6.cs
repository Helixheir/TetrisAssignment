using UnityEngine;
using System.Collections;

public class destroy6 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha6))
        {
            Destroy(gameObject);
        }
    }
}