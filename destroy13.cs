using UnityEngine;
using System.Collections;

public class destroy13 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Destroy(gameObject);
        }
    }
}