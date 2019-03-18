using UnityEngine;
using System.Collections;

public class destroy12 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.C))
        {
            Destroy(gameObject);
        }
    }
}