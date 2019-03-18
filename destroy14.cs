using UnityEngine;
using System.Collections;

public class destroy14 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Destroy(gameObject);
        }
    }
}