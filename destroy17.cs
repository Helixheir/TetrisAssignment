using UnityEngine;
using System.Collections;

public class destroy17 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.H))
        {
            Destroy(gameObject);
        }
    }
}