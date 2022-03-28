using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    [SerializeField] private AudioManeger audioManeger;

    public void Play()
    {
        audioManeger.Play("UICLICK");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {
        audioManeger.Play("UICLICK");
        Application.Quit();
    }
}
