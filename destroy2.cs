using UnityEngine;
using System.Collections;

public class destroy2 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha2))
        {
            Destroy(gameObject);
        }
    }
}