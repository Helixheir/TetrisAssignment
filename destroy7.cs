using UnityEngine;
using System.Collections;

public class destroy7 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha7))
        {
            Destroy(gameObject);
        }
    }
}