using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField] private GridManeger grid;
    private Vector2Int cords;
    private Vector2Int moveDir;

    Tile currentTile;

    private void Start()
    {
        cords = new Vector2Int(0, 0);
        currentTile = grid.GetTile(cords);
        transform.position = currentTile.transform.position;
    }

    private void Update()
    {
        getInput();
    }

    private void move(Vector2Int moveDirection)
    {
        cords = cords + moveDirection;
        currentTile = grid.GetTile(cords);
        transform.position = currentTile.transform.position;
    }

    private void getInput()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            moveDir = new Vector2Int(1, 0);
            if (checkTile(moveDir + cords))
            {
                move(moveDir);
            }
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            moveDir = new Vector2Int(-1, 0);
            if (checkTile(moveDir + cords))
            {
                move(moveDir);
            }
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            moveDir = new Vector2Int(0, 1);
            if (checkTile(moveDir + cords))
            {
                move(moveDir);
            }
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            moveDir = new Vector2Int(0, -1);
            if (checkTile(moveDir + cords))
            {
                move(moveDir);
            }
        }
    }

    private bool checkTile(Vector2Int targetCord)
    {
        if (targetCord.y >= grid.numRows || targetCord.x >= grid.numCollomns)
        {
            return false;
        }
        else if (targetCord.y < 0 || targetCord.x < 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }


}
