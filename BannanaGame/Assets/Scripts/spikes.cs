using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikes : MonoBehaviour
{
    [SerializeField] private GridManeger grid;
    private Vector2Int cords;
    [HideInInspector] public Vector2Int startingCords;
    private Tile currentTile;

    private void Start()
    {
        cords = startingCords;
        currentTile = grid.GetTile(cords);
        transform.position = currentTile.transform.position;
    }

    private void Update()
    {
        cords = startingCords;
        currentTile = grid.GetTile(cords);
        transform.position = currentTile.transform.position;
    }

    public Tile spikeTile()
    {
        return currentTile;
    }
}
