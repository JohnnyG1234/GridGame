using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    AudioSource uiClick;

    private void Start()
    {
        uiClick = GetComponent<AudioSource>();
    }

    public void Play()
    {
        uiClick.PlayOneShot(uiClick.GetComponent<AudioClip>());
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {
        uiClick.PlayOneShot(uiClick.GetComponent<AudioClip>());
        Application.Quit();
    }
}
