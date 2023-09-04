using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void Level1Start()
    {
        SceneManager.LoadScene("Level1");
    }

    public void QuitGame()
    {
        // Çýkýþ butonuna baðlý iþlev
        // Oyunu kapatýr
        Application.Quit();
    }
}
