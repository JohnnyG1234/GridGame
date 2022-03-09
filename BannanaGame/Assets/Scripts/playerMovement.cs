using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private GridManeger grid;
    private float padding = 0.1f;

    private void Start()
    {
        transform.localPosition = new Vector3Int(0, 0, 0);
    }

    private void Update()
    {
        getInput();
    }

    private void getInput()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            moveRight();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            moveLeft();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            moveUp();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            moveDown();
        }
    }

    private void moveLeft()
    {
        transform.localPosition += new Vector3(-1 + (padding*transform.localPosition.x), 0, 0);
    }

    private void moveRight()
    {
        transform.localPosition += new Vector3(1 + (padding * transform.localPosition.x), 0, 0);
    }

    private void moveUp()
    {
        transform.localPosition += new Vector3(0, 1 + (padding * transform.localPosition.y), 0);
    }

    private void moveDown()
    {
        transform.localPosition += new Vector3(0, -1 + (padding * transform.localPosition.y), 0);
    }
}
