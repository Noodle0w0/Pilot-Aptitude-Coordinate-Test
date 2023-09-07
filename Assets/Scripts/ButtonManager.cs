using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ButtonManager : MonoBehaviour
{
    public TextMeshProUGUI puan;
    public TextMeshProUGUI hatapuan;
    private void Start()
    {
        string puann = PlayerPrefs.GetString("puan");
        string hatapuann = PlayerPrefs.GetString("hatapuan");
        puan.text = puann;
        hatapuan.text = hatapuann;

    }
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
