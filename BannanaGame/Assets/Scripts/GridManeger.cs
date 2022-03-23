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

    [SerializeField] private playerMovement player;
    [SerializeField] private evilMonkey evilMoneky;

    [SerializeField] private Texture2D source;

    [SerializeField] private banana banana;
    [SerializeField] private spikes spikes;

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
                if (pixels[y * numCollomns + x].g == 0 && pixels[y * numCollomns + x].r == 0 && pixels[y * numCollomns + x].b == 0)
                {
                    Tile wall = Instantiate(wallPrefab, transform);
                    Vector2 tilePos = new Vector2(x + (padding * x), y + (padding * y));
                    wall.transform.localPosition = tilePos;
                    wall.name = $"Tile_{x}_{y}";
                    wall.gridManeger = this;
                    wall.gridCords = new Vector2Int(x, y);
                    tiles[y * numCollomns + x] = wall;
                }
                else if (pixels[y * numCollomns + x].g > 150 && pixels[y * numCollomns + x].r > 150 && pixels[y * numCollomns + x].b > 150)
                {
                    Tile tile = Instantiate(tilePrefab, transform);
                    Vector2 tilePos = new Vector2(x + (padding * x), y + (padding * y));
                    tile.transform.localPosition = tilePos;
                    tile.name = $"Tile_{x}_{y}";
                    tile.gridManeger = this;
                    tile.gridCords = new Vector2Int(x, y);
                    tiles[y * numCollomns + x] = tile;
                }
                else if (pixels[y * numCollomns + x].b > 150)
                {
                    player.startingCords = new Vector2Int(x, y);
                    Tile tile = Instantiate(tilePrefab, transform);
                    Vector2 tilePos = new Vector2(x + (padding * x), y + (padding * y));
                    tile.transform.localPosition = tilePos;
                    tile.name = $"Tile_{x}_{y}";
                    tile.gridManeger = this;
                    tile.gridCords = new Vector2Int(x, y);
                    tiles[y * numCollomns + x] = tile;
                }
                else if(pixels[y * numCollomns + x].r > 150)
                {
                    evilMoneky.startingCords = new Vector2Int(x, y);
                    Tile tile = Instantiate(tilePrefab, transform);
                    Vector2 tilePos = new Vector2(x + (padding * x), y + (padding * y));
                    tile.transform.localPosition = tilePos;
                    tile.name = $"Tile_{x}_{y}";
                    tile.gridManeger = this;
                    tile.gridCords = new Vector2Int(x, y);
                    tiles[y * numCollomns + x] = tile;
                }
                else if(pixels[y * numCollomns + x].g > 150)
                {
                    banana.startingCords = new Vector2Int(x, y);
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
