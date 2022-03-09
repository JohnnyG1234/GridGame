using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private GridManeger grid;
    private float padding = 0.1f;
    private Vector2Int cords;

    private void Start()
    {
        cords = new Vector2Int(0, 0);
        Tile currentTile = grid.GetTile(cords);
        transform.position = currentTile.transform.position;
    }

    private void Update()
    {
        
    }


}
