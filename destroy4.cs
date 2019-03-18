using UnityEngine;
using System.Collections;

public class destroy4 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha4))
        {
            Destroy(gameObject);
        }
    }
}