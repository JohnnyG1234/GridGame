using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class portal : MonoBehaviour
{
    [SerializeField] private Vector2Int teloportDestination;
    [SerializeField] private GridManeger grid;
    [SerializeField] private AudioManeger audioManeger;

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
        audioManeger.Play("TELEPORT");
        player.currentTile = grid.GetTile(teloportDestination);
        DOTween.To(() => player.transform.position, x => player.transform.position = x, grid.GetTile(teloportDestination).transform.position, .5f);
    }
}
