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
    [SerializeField] private Tile wallPrefab;

    [SerializeField] private Texture2D source;

    private void Awake()
    {
        InitGrid();
    }

    public void InitGrid()
    {
        int sourceMipLevel = 0;
        Color32[] pixels = source.GetPixels32(sourceMipLevel);
        tiles = new Tile[numRows * numCollomns];
        for (int y = 0; y < numRows; y++)
        {
            for (int x = 0; x < numCollomns; x++)
            {
                if (pixels[x * y].g == 0 && pixels[x * y].r == 0 && pixels[x * y].b == 0)
                {
                    Tile wall = Instantiate(wallPrefab, transform);
                    Vector2 tilePos = new Vector2(x + (padding * x), y + (padding * y));
                    wall.transform.localPosition = tilePos;
                    wall.name = $"Tile_{x}_{y}";
                    wall.gridManeger = this;
                    wall.gridCords = new Vector2Int(x, y);
                    tiles[y * numCollomns + x] = wall;
                }
                else if (pixels[x * y].g > 150 && pixels[x * y].r > 150 && pixels[x * y].b > 150)
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
    }

    public Tile GetTile(Vector2Int cords)
    {
        return tiles[cords.y * numCollomns + cords.x];
    }
}
