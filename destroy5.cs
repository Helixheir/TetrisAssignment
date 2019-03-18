using UnityEngine;
using System.Collections;

public class destroy5 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha5))
        {
            Destroy(gameObject);
        }
    }
}