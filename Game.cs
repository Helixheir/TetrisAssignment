using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public static int gridWidth = 8;
    public static int gridHeight = 12;

    public static Transform[,] grid = new Transform[gridWidth, gridHeight];

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateGrid(Tetromino tetromino)
    {
        for (int y = 0; y < gridHeight; ++y)
        {
            for (int x = 0; x < gridWidth; ++x)
            {
                if (grid[x, y] != null)
                {
                    //Check if parent transform is the tetramino transform
                    //that we pass to our UpdateGrid
                    if (grid[x, y].parent == tetromino.transform)
                    {
                        //for when it is moving down 1
                        grid[x, y] = null;
                    }
                }
            }
        }

        foreach (Transform mino in tetromino.transform)
        {
            Vector2 pos = Round(mino.position);
            //Don't want to assign values to grid array the 
            //value that is above the grid (index out of bounds errors)
            if (pos.y < gridHeight)
            {
                grid[(int)pos.x, (int)pos.y] = mino;
            }
        }
    }

    public Transform GetTransformAtGridPos(Vector2 pos)
    {
        if (pos.y > gridHeight - 1)
        {
            return null;
        }
        else
        {
            return grid[(int)pos.x, (int)pos.y];
        }
    }

    public bool CheckIsInsideGrid(Vector2 pos)
    {
        return ((int)pos.x >= 2 && (int)pos.x < gridWidth && (int)pos.y >= 0);
    }

    public Vector2 Round(Vector2 pos)
    {
        return new Vector2(Mathf.Round(pos.x), Mathf.Round(pos.y));
    }
}
