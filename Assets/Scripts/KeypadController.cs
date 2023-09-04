using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeypadController : MonoBehaviour
{
    public TMP_InputField inputField;

    // Düðme týklandýðýnda çaðrýlacak fonksiyon
    public void OnButtonClick(string value)
    {
        // InputField'daki mevcut metni al
        string currentText = inputField.text;

        // Eðer metin uzunluðu 0 ise, sadece rakamý ekle
        if (currentText.Length == 0)
        {
            currentText = value;
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

        // Yeni metni InputField'a atayýn
        inputField.text = currentText;
    }
}
