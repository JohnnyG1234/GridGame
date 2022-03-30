using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal : MonoBehaviour
{
    [SerializeField] private Vector2Int teloportDestination;
    [SerializeField] private GridManeger grid;

    [HideInInspector] public Tile currentTile;
    [HideInInspector] public Vector2Int cords;

    [SerializeField] private playerMovement player;

    private void Start()
    {
        currentTile = grid.GetTile(cords);
        transform.position = currentTile.transform.position;
    }

    public void teleport()
    {
        player.currentTile = grid.GetTile(teloportDestination);
    }
}
