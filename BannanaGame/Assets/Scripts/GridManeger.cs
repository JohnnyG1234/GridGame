using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManeger : MonoBehaviour
{
    public int numRows = 6;
    public int numCollomns = 6;
    public float padding = 0.1f;

    private Tile[] tiles;

    [SerializeField] private Tile tilePrefab;

    private void Awake()
    {
        InitGrid();
    }

    public void InitGrid()
    {
        tiles = new Tile[numRows * numCollomns];
        for (int y = 0; y < numRows; y++)
        {
            for (int x = 0; x < numCollomns; x++)
            {
                Tile tile = Instantiate(tilePrefab, transform);
                Vector2 tilePos = new Vector2(x + (padding * x), y + (padding * y));
                tile.transform.localPosition = tilePos;
                tile.name = $"Tile_{x}_{y}";
                tile.gridManeger = this;
                tile.gridCords = new Vector2Int(x, y);
                tiles[y * numCollomns + x] = tile;
            }
        }
    }

    public Tile GetTile(Vector2Int cords)
    {
        return tiles[cords.y * numCollomns + cords.x];
    }
}
