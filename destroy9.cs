using UnityEngine;
using System.Collections;

public class destroy9 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha9))
        {
            Destroy(gameObject);
        }
    }
}