using UnityEngine;
using System.Collections;

public class destroy15 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            Destroy(gameObject);
        }
    }
}