using UnityEngine;
using System.Collections;

public class destroy19 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.J))
        {
            Destroy(gameObject);
        }
    }
}