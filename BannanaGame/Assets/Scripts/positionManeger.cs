using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class positionManeger : MonoBehaviour
{
    [SerializeField] private playerMovement player;
    [SerializeField] private evilMonkey evilMonkey;

    private void Update()
    {
        if (player.currentTile == evilMonkey.currentTile)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
