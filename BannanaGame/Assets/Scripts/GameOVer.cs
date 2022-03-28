using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOVer : MonoBehaviour
{
    [SerializeField] private GameObject gameOverUi;
    [SerializeField] private AudioManeger audioManeger;
    [SerializeField] private GameObject player;

    private bool gameIsOver = false;

    public void gameOver()
    {
        if (gameIsOver == true)
            return;

        gameIsOver = true;
        gameOverUi.SetActive(true);
        audioManeger.Play("GAMEOVER");
        GameObject.Destroy(player);
        Invoke("resetScene", 1f);
    }

    private void resetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        gameIsOver = false;
    }
}
