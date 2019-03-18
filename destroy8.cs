using UnityEngine;
using System.Collections;

public class destroy8 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha8))
        {
            Destroy(gameObject);
        }
    }
}