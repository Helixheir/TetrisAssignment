using UnityEngine;
using System.Collections;

public class destroy10 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Destroy(gameObject);
        }
    }
}