using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class positionManeger : MonoBehaviour
{
    [SerializeField] private playerMovement player;
    [SerializeField] private playerAnimation playerAnimator;
    [SerializeField] private evilMonkey evilMonkey;

    [SerializeField] private banana banana;
    [SerializeField] private spikes spikes;

    [SerializeField] private GameOVer gameOver;
    [SerializeField] private loadNext loadNext;


    private void Update()
    {
        if (player.currentTile == evilMonkey.currentTile)
        {
            gameOver.gameOver();
        }

        if (player.currentTile == evilMonkey.currentTile && player.currentTile == banana.bannanaTile())
        {
            gameOver.gameOver();
        }

        if (player.currentTile == banana.bannanaTile() && player.currentTile != evilMonkey.currentTile)
        {
            loadNext.NextLevel();
        }

        if (player.currentTile == spikes.spikeTile())
        {
            gameOver.gameOver();
        }
    }
}
