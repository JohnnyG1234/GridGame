using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadNext : MonoBehaviour
{
    [SerializeField] private GameObject victoryUI;
    [SerializeField] private AudioManeger audioManeger;
    [SerializeField] private AudioSource music;

    private bool levelCleared = false;

    private void next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        music.mute = false;
        victoryUI.SetActive(false);
        levelCleared = false;
    }

    public void NextLevel()
    {
        if (levelCleared == true)
            return;

        levelCleared = true;
        music.mute = true;
        victoryUI.SetActive(true);
        audioManeger.Play("WIN");
        Invoke("next", 1f);
    }
}
