using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tetromino : MonoBehaviour
{
    float fall = 0;
    public float fallSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CheckUserInput();
    }

    void CheckUserInput()
    {
        if (Time.time - fall >= fallSpeed)
        {
            transform.position += new Vector3(0, -1, 0);
            //Debug.Log("down");
            if (CheckIsValidPosition())
            {
                FindObjectOfType<Game>().UpdateGrid(this);
                //Debug.Log("down1" + transform.position);
            }
            else
            {
                transform.position += new Vector3(0, 1, 0);
            }

            fall = Time.time;
        }
    }

    bool CheckIsValidPosition()
    {
        foreach (Transform mino in transform)
        {
            //pos variable contains a rounded value of the mino's current position in the iteration
            Vector2 pos = FindObjectOfType<Game>().Round(mino.position);
            //Debug.Log(mino.position);
            if (FindObjectOfType<Game>().CheckIsInsideGrid(pos) == false)
            {
                return false;
            }
            if (FindObjectOfType<Game>().GetTransformAtGridPos(pos) != null
                && FindObjectOfType<Game>().GetTransformAtGridPos(pos).parent != transform)
            {
                return false;
            }
        }

            return true;
    }
}