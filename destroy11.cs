using UnityEngine;
using System.Collections;

public class destroy11 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.B))
        {
            Destroy(gameObject);
        }
    }
}