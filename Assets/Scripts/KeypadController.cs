using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeypadController : MonoBehaviour
{
    public TMP_InputField inputField;
    int a;

    // Düðme týklandýðýnda çaðrýlacak fonksiyon
    public void OnButtonClick(string value)
    {
        // InputField'daki mevcut metni al
        string currentText = inputField.text;
        // Eðer metin uzunluðu 0 ise, sadece rakamý ekle
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
                // Eðer metin uzunluðu 1 ise, aralarýna "-" iþareti ekleyerek iki rakamý birleþtir
                if (currentText.Length == 1)
                {
                    currentText += "-" + value;
                }
                // Eðer metin uzunluðu 3'ten küçükse, sadece son rakamý ekleyerek mevcut metni güncelle
                else if (currentText.Length < 3)
                {
                    currentText = currentText.Substring(0, 2) + value;
                }
            }
        }

        // Yeni metni InputField'a atayýn
        inputField.text = currentText;
    }

    // Sil tuþuna bastýðýnýzda çaðrýlacak fonksiyon
    public void OnDeleteButtonClick()
    {
        // InputField'daki mevcut metni al
        string currentText = inputField.text;

        // Eðer metin uzunluðu en az 1 ise, son karakteri ve aradaki "-" iþaretini sil
        if (currentText.Length >= 1)
        {
            // Eðer metin uzunluðu 1 ise, sadece son karakteri sil
            if (currentText.Length == 1)
            {
                currentText = "";
            }
            else if (currentText.Length < 4)
            {
                currentText = currentText.Substring(0, currentText.Length - 2);
            }
            // Eðer metin uzunluðu 4'ten küçükse, son karakteri ve aradaki "-" iþaretini sil
            else if (currentText.Length < 6)
            {
                currentText = currentText.Substring(0, currentText.Length - 2);
            }
        }

        // Yeni metni InputField'a atayýn
        inputField.text = currentText;
    }

    public void EnterButton()
    {
        Debug.Log("Basýldý");
    }
}
