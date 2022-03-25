using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class positionManeger : MonoBehaviour
{
    [SerializeField] private playerMovement player;
    [SerializeField] private playerAnimation playerAnimator;
    [SerializeField] private evilMonkey evilMonkey;

    [SerializeField] private banana banana;
    [SerializeField] private spikes spikes;


    private void Update()
    {
        if (player.currentTile == evilMonkey.currentTile)
        {
            playDeathAnim();
            Invoke("killPlayer", .2f);
        }

        if (player.currentTile == evilMonkey.currentTile && player.currentTile == banana.bannanaTile())
        {
            playDeathAnim();
            Invoke("killPlayer", .2f);
        }

        if (player.currentTile == banana.bannanaTile() && player.currentTile != evilMonkey.currentTile)
        {
            Invoke("loadNext", .2f);
        }

        if (player.currentTile == spikes.spikeTile())
        {
            playDeathAnim();
            Invoke("killPlayer", .2f);
        }
    }

    private void killPlayer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void loadNext()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void playDeathAnim()
    {
        playerAnimator.playDeathAnimation();
    }

}
