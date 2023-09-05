using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeypadController : MonoBehaviour
{
    public TMP_InputField inputField;
    int a;

    // D��me t�kland���nda �a�r�lacak fonksiyon
    public void OnButtonClick(string value)
    {
        // InputField'daki mevcut metni al
        string currentText = inputField.text;
        // E�er metin uzunlu�u 0 ise, sadece rakam� ekle
        if (currentText.Length == 0)
        {
            currentText = value;
            int intValue;
            if (int.TryParse(currentText[0].ToString(), out intValue))
            {
                a = intValue;
            }
        }
        else
        {

            if (a == 0)
            {
                if (currentText.Length == 1)
                {
                    currentText += "-" + value;
                }
                else if (currentText.Length == 3)
                {
                    currentText += "-" + value;
                }
                else if (currentText.Length < 5)
                {
                    currentText = currentText.Substring(0, 4) + value;
                }
            }
            else
            {
                // E�er metin uzunlu�u 1 ise, aralar�na "-" i�areti ekleyerek iki rakam� birle�tir
                if (currentText.Length == 1)
                {
                    currentText += "-" + value;
                }
                // E�er metin uzunlu�u 3'ten k���kse, sadece son rakam� ekleyerek mevcut metni g�ncelle
                else if (currentText.Length < 3)
                {
                    currentText = currentText.Substring(0, 2) + value;
                }
            }
        }

        // Yeni metni InputField'a atay�n
        inputField.text = currentText;
    }

    // Sil tu�una bast���n�zda �a�r�lacak fonksiyon
    public void OnDeleteButtonClick()
    {
        // InputField'daki mevcut metni al
        string currentText = inputField.text;

        // E�er metin uzunlu�u en az 1 ise, son karakteri ve aradaki "-" i�aretini sil
        if (currentText.Length >= 1)
        {
            // E�er metin uzunlu�u 1 ise, sadece son karakteri sil
            if (currentText.Length == 1)
            {
                currentText = "";
            }
            else if (currentText.Length < 4)
            {
                currentText = currentText.Substring(0, currentText.Length - 2);
            }
            // E�er metin uzunlu�u 4'ten k���kse, son karakteri ve aradaki "-" i�aretini sil
            else if (currentText.Length < 6)
            {
                currentText = currentText.Substring(0, currentText.Length - 2);
            }
        }

        // Yeni metni InputField'a atay�n
        inputField.text = currentText;
    }

    public void EnterButton()
    {
        Debug.Log("Bas�ld�");
    }
}
