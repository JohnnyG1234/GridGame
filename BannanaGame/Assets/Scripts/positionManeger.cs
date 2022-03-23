using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class positionManeger : MonoBehaviour
{
    [SerializeField] private playerMovement player;
    [SerializeField] private evilMonkey evilMonkey;

    [SerializeField] private banana banana;
    [SerializeField] private spikes spikes;

    private void Update()
    {
        if (player.currentTile == evilMonkey.currentTile)
        {
            Invoke("killPlayer", .3f);
        }

        if (player.currentTile == banana.bannanaTile())
        {
            Debug.Log("VICTORY");
        }

        if (player.currentTile == spikes.spikeTile())
        {
            Invoke("killPlayer", .3f);
        }
    }

    private void killPlayer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
