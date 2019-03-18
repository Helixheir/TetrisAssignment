using UnityEngine;
using System.Collections;

public class destroy18 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.I))
        {
            Destroy(gameObject);
        }
    }
}