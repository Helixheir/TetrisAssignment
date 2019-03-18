using UnityEngine;
using System.Collections;

public class destroy3 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha3))
        {
            Destroy(gameObject);
        }
    }
}