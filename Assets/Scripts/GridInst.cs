using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class GridInst : MonoBehaviour
{
    [SerializeField] GameObject gridPrefab;
    [SerializeField] float number;
    public TextMeshProUGUI puan;
    public TextMeshProUGUI hatapuan;
    int puann;
    int hatapuann;
    public TMP_FontAsset font;
    public TMP_InputField inputField;
    private GameObject textObject;
    private GameObject textObject2;
    private GameObject textObject3;
    private GameObject textObject4;
    private GameObject textObject5;
    private GameObject textObject6;
    private GameObject textObject7;
    private GameObject textObject8;
    private GameObject textObject9;


    int a;
    int b;
    int a2;
    int b2;
    int a3;
    int b3;
    int a4;
    int b4;
    int a5;
    int b5;
    int a6;
    int b6;
    int a7;
    int b7;
    int o1 = 11;
    int o2 = 11;
    int o3 = 11;
    int o4 = 11;

    int c;
    int d;
    int e;
    void Start()
    {
        int min = 0;
        int max = 9;
        a = Random.Range(min, max);
        b = Random.Range(min, max);
        a2 = Random.Range(min, max);
        b2 = Random.Range(min, max);
        a3 = Random.Range(min, max);
        b3 = Random.Range(min, max);
        a4 = Random.Range(min, max);
        b4 = Random.Range(min, max);
        a5 = Random.Range(min, max);
        b5 = Random.Range(min, max);
        a6 = Random.Range(min, max);
        b6 = Random.Range(min, max);
        a7 = Random.Range(min, max);
        b7 = Random.Range(min, max);

        int orandom = Random.Range(1, 11);

        if (orandom == 4)
        {
            o1 = Random.Range(min, max);
            o2 = Random.Range(min, max);
        }
        if (orandom == 5)
        {
            o1 = Random.Range(min, max);
            o2 = Random.Range(min, max);
            o3 = Random.Range(min, max);
            o4 = Random.Range(min, max);
        }
        Debug.Log(o1 + " " + o2);
        Debug.Log(o3 + " " + o4);
        Debug.Log(a + " " + b);
        Debug.Log(a2 + " " + b2);
        Debug.Log(a3 + " " + b3);
        Debug.Log(a4 + " " + b4);
        Debug.Log(a5 + " " + b5);
        Debug.Log(a6 + " " + b6);
        Debug.Log(a7 + " " + b7);


        for (int i = 0; i < number; i++)
        {
            for (int y = 0; y < number; y++)
            {
                GameObject grid = Instantiate(gridPrefab) as GameObject;
                grid.transform.position = new Vector3((i), (y), 0f);
                if (i == o1 && y == o2)
                {
                    textObject = new GameObject("O");
                    textObject.transform.position = new Vector3(((float)i), ((float)y), 0f);
                    // TextMeshPro bileþenini ekleyin ve metni ayarlayýn
                    TextMeshPro textMeshPro = textObject.AddComponent<TextMeshPro>();
                    textMeshPro.text = "o"; // Metin içeriðini belirlediðiniz diziye göre alýn
                    textMeshPro.color = Color.white;
                    textMeshPro.fontSize = 9; // Metin boyutunu ayarlayabilirsiniz
                    textMeshPro.alignment = TextAlignmentOptions.Center; // Metin hizalamasýný ayarlayabilirsiniz
                    textMeshPro.font = font; // Kullanmak istediðiniz fontu ayarlayýn
                    continue;
                }
                if (i == o3 && y == o4)
                {
                    textObject2 = new GameObject("O1");
                    textObject2.transform.position = new Vector3(((float)i), ((float)y), 0f);
                    // TextMeshPro bileþenini ekleyin ve metni ayarlayýn
                    TextMeshPro textMeshPro = textObject2.AddComponent<TextMeshPro>();
                    textMeshPro.text = "o"; // Metin içeriðini belirlediðiniz diziye göre alýn
                    textMeshPro.color = Color.white;
                    textMeshPro.fontSize = 9; // Metin boyutunu ayarlayabilirsiniz
                    textMeshPro.alignment = TextAlignmentOptions.Center; // Metin hizalamasýný ayarlayabilirsiniz
                    textMeshPro.font = font; // Kullanmak istediðiniz fontu ayarlayýn
                    continue;
                }
                if (i == a && y == b)
                {
                    textObject3 = new GameObject("Yýldýz1");
                    textObject3.transform.position = new Vector3(((float)i), ((float)y - 0.15f), 0f);
                    // TextMeshPro bileþenini ekleyin ve metni ayarlayýn
                    TextMeshPro textMeshPro = textObject3.AddComponent<TextMeshPro>();
                    textMeshPro.text = "*"; // Metin içeriðini belirlediðiniz diziye göre alýn
                    textMeshPro.color = Color.white;
                    textMeshPro.fontSize = 9; // Metin boyutunu ayarlayabilirsiniz
                    textMeshPro.alignment = TextAlignmentOptions.Center; // Metin hizalamasýný ayarlayabilirsiniz
                    textMeshPro.font = font; // Kullanmak istediðiniz fontu ayarlayýn
                    continue;
                }
                if (i == a2 && y == b2)
                {
                    textObject4 = new GameObject("Yýldýz2");
                    textObject4.transform.position = new Vector3(((float)i), ((float)y - 0.15f), 0f);
                    // TextMeshPro bileþenini ekleyin ve metni ayarlayýn
                    TextMeshPro textMeshPro = textObject4.AddComponent<TextMeshPro>();
                    textMeshPro.text = "*"; // Metin içeriðini belirlediðiniz diziye göre alýn
                    textMeshPro.color = Color.white;
                    textMeshPro.fontSize = 9; // Metin boyutunu ayarlayabilirsiniz
                    textMeshPro.alignment = TextAlignmentOptions.Center; // Metin hizalamasýný ayarlayabilirsiniz
                    textMeshPro.font = font; // Kullanmak istediðiniz fontu ayarlayýn
                    continue;
                }
                if (i == a3 && y == b3)
                {
                    textObject5 = new GameObject("Yýldýz3");
                    textObject5.transform.position = new Vector3(((float)i), ((float)y - 0.15f), 0f);
                    // TextMeshPro bileþenini ekleyin ve metni ayarlayýn
                    TextMeshPro textMeshPro = textObject5.AddComponent<TextMeshPro>();
                    textMeshPro.text = "*"; // Metin içeriðini belirlediðiniz diziye göre alýn
                    textMeshPro.color = Color.white;
                    textMeshPro.fontSize = 9; // Metin boyutunu ayarlayabilirsiniz
                    textMeshPro.alignment = TextAlignmentOptions.Center; // Metin hizalamasýný ayarlayabilirsiniz
                    textMeshPro.font = font; // Kullanmak istediðiniz fontu ayarlayýn
                    continue;
                }
                if (i == a4 && y == b4)
                {
                    textObject6 = new GameObject("Yýldýz4");
                    textObject6.transform.position = new Vector3(((float)i), ((float)y - 0.15f), 0f);
                    // TextMeshPro bileþenini ekleyin ve metni ayarlayýn
                    TextMeshPro textMeshPro = textObject6.AddComponent<TextMeshPro>();
                    textMeshPro.text = "*"; // Metin içeriðini belirlediðiniz diziye göre alýn
                    textMeshPro.color = Color.white;
                    textMeshPro.fontSize = 9; // Metin boyutunu ayarlayabilirsiniz
                    textMeshPro.alignment = TextAlignmentOptions.Center; // Metin hizalamasýný ayarlayabilirsiniz
                    textMeshPro.font = font; // Kullanmak istediðiniz fontu ayarlayýn
                    continue;
                }
                if (i == a5 && y == b5)
                {
                    textObject7 = new GameObject("Yýldýz5");
                    textObject7.transform.position = new Vector3(((float)i), ((float)y - 0.15f), 0f);
                    // TextMeshPro bileþenini ekleyin ve metni ayarlayýn
                    TextMeshPro textMeshPro = textObject7.AddComponent<TextMeshPro>();
                    textMeshPro.text = "*"; // Metin içeriðini belirlediðiniz diziye göre alýn
                    textMeshPro.color = Color.white;
                    textMeshPro.fontSize = 9; // Metin boyutunu ayarlayabilirsiniz
                    textMeshPro.alignment = TextAlignmentOptions.Center; // Metin hizalamasýný ayarlayabilirsiniz
                    textMeshPro.font = font; // Kullanmak istediðiniz fontu ayarlayýn
                    continue;
                }
                if (i == a6 && y == b6)
                {
                    textObject8 = new GameObject("Yýldýz6");
                    textObject8.transform.position = new Vector3(((float)i), ((float)y - 0.15f), 0f);
                    // TextMeshPro bileþenini ekleyin ve metni ayarlayýn
                    TextMeshPro textMeshPro = textObject8.AddComponent<TextMeshPro>();
                    textMeshPro.text = "*"; // Metin içeriðini belirlediðiniz diziye göre alýn
                    textMeshPro.color = Color.white;
                    textMeshPro.fontSize = 9; // Metin boyutunu ayarlayabilirsiniz
                    textMeshPro.alignment = TextAlignmentOptions.Center; // Metin hizalamasýný ayarlayabilirsiniz
                    textMeshPro.font = font; // Kullanmak istediðiniz fontu ayarlayýn
                    continue;
                }
                if (i == a7 && y == b7)
                {
                    textObject9 = new GameObject("Yýldýz7");
                    textObject9.transform.position = new Vector3(((float)i), ((float)y - 0.15f), 0f);
                    // TextMeshPro bileþenini ekleyin ve metni ayarlayýn
                    TextMeshPro textMeshPro = textObject9.AddComponent<TextMeshPro>();
                    textMeshPro.text = "*"; // Metin içeriðini belirlediðiniz diziye göre alýn
                    textMeshPro.color = Color.white;
                    textMeshPro.fontSize = 9; // Metin boyutunu ayarlayabilirsiniz
                    textMeshPro.alignment = TextAlignmentOptions.Center; // Metin hizalamasýný ayarlayabilirsiniz
                    textMeshPro.font = font; // Kullanmak istediðiniz fontu ayarlayýn
                    continue;
                }
            }
        }
    }

    public void EnterButton()
    {
        puann = puann;
        if (inputField == null)
        {
            return;
        }

        // Text bileþeninden metni alýn
        string text = inputField.text;

        if (text.Length > 0)
        {
            // Metni int'e dönüþtürün (0. indexli karakteri)
            int intValue;
            if (int.TryParse(text[0].ToString(), out intValue))
            {
                c = intValue;
            }
        }

        if (inputField == null)
        {
            return;
        }

        if (text.Length > 2)
        {
            // Metni int'e dönüþtürün (2. indexli karakteri)
            int intValue;
            if (int.TryParse(text[2].ToString(), out intValue))
            {
                d = intValue;
            }
        }

        if (inputField == null)
        {
            return;
        }

        if (text.Length > 4)
        {
            // Metni int'e dönüþtürün (4. indexli karakteri)
            int intValue;
            if (int.TryParse(text[4].ToString(), out intValue))
            {
                e = intValue;
            }
        }


        if (c == 0 && (o1 + 1) == d && (o2 + 1) == e)
        {
            puann++;
            puan.text = puann.ToString();
            inputField.text = "";
            c = 11;
            d = 11;
            e = 11;
            Destroy(textObject);
        }
        else if (c == 0 && (o3 + 1) == d && (o4 + 1) == e)
        {
            puann++;
            puan.text = puann.ToString();
            inputField.text = "";
            c = 11;
            d = 11;
            e = 11;
            Destroy(textObject2);
        }
        else if((a + 1) == c && (b + 1) == d)
        {
            puann++;
            puan.text = puann.ToString();
            inputField.text = "";
            c = 11;
            d = 11;
            Destroy(textObject3);
        }
        else if ((a2 + 1) == c && (b2 + 1) == d)
        {
            puann++;
            puan.text = puann.ToString();
            inputField.text = "";
            c = 11;
            d = 11;
            Destroy(textObject4);
        }
        else if ((a3 + 1) == c && (b3 + 1) == d)
        {
            puann++;
            puan.text = puann.ToString();
            inputField.text = "";
            c = 11;
            d = 11;
            Destroy(textObject5);
        }
        else if ((a4 + 1) == c && (b4 + 1) == d)
        {
            puann++;
            puan.text = puann.ToString();
            inputField.text = "";
            c = 11;
            d = 11;
            Destroy(textObject6);
        }
        else if ((a5 + 1) == c && (b5 + 1) == d)
        {
            puann++;
            puan.text = puann.ToString();
            inputField.text = "";
            c = 11;
            d = 11;
            Destroy(textObject7);
        }
        else if ((a6 + 1) == c && (b6 + 1) == d)
        {
            puann++;
            puan.text = puann.ToString();
            inputField.text = "";
            c = 11;
            d = 11;
            Destroy(textObject8);
        }
        else if ((a7 + 1) == c && (b7 + 1) == d)
        {
            puann++;
            puan.text = puann.ToString();
            inputField.text = "";
            c = 11;
            d = 11;
            Destroy(textObject9);
        }
        else
        {
            hatapuann++;
            hatapuan.text = hatapuann.ToString();
            inputField.text = "";
        }
    }

    void Yenileme()
    {
        Destroy(textObject);
        Destroy(textObject2);
        Destroy(textObject3);
        Destroy(textObject4);
        Destroy(textObject5);
        Destroy(textObject6);
        Destroy(textObject7);
        Destroy(textObject8);
        Destroy(textObject9);
        a = 11;
        b = 11;
        a2 = 11;
        b2 = 11;
        a3 = 11;
        b3 = 11;
        a4 = 11;
        b4 = 11;
        a5 = 11;
        b5 = 11;
        a6 = 11;
        b6 = 11;
        a7 = 11;
        b7 = 11;
        o1 = 11;
        o2 = 11;
        o3 = 11;
        o4 = 11;
        Start();
    }

}
