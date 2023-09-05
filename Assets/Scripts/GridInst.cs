using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GridInst : MonoBehaviour
{
    [SerializeField] GameObject gridPrefab;
    [SerializeField] float number;
    public TMP_FontAsset font;
    public TMP_InputField inputField;

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
                    GameObject textObject = new GameObject("O");
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
                    GameObject textObject = new GameObject("O");
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
                if (i == a && y == b)
                {
                    GameObject textObject = new GameObject("Yýldýz");
                    textObject.transform.position = new Vector3(((float)i), ((float)y - 0.15f), 0f);
                    // TextMeshPro bileþenini ekleyin ve metni ayarlayýn
                    TextMeshPro textMeshPro = textObject.AddComponent<TextMeshPro>();
                    textMeshPro.text = "*"; // Metin içeriðini belirlediðiniz diziye göre alýn
                    textMeshPro.color = Color.white;
                    textMeshPro.fontSize = 9; // Metin boyutunu ayarlayabilirsiniz
                    textMeshPro.alignment = TextAlignmentOptions.Center; // Metin hizalamasýný ayarlayabilirsiniz
                    textMeshPro.font = font; // Kullanmak istediðiniz fontu ayarlayýn
                    continue;
                }
                if (i == a2 && y == b2)
                {
                    GameObject textObject = new GameObject("Yýldýz");
                    textObject.transform.position = new Vector3(((float)i), ((float)y - 0.15f), 0f);
                    // TextMeshPro bileþenini ekleyin ve metni ayarlayýn
                    TextMeshPro textMeshPro = textObject.AddComponent<TextMeshPro>();
                    textMeshPro.text = "*"; // Metin içeriðini belirlediðiniz diziye göre alýn
                    textMeshPro.color = Color.white;
                    textMeshPro.fontSize = 9; // Metin boyutunu ayarlayabilirsiniz
                    textMeshPro.alignment = TextAlignmentOptions.Center; // Metin hizalamasýný ayarlayabilirsiniz
                    textMeshPro.font = font; // Kullanmak istediðiniz fontu ayarlayýn
                    continue;
                }
                if (i == a3 && y == b3)
                {
                    GameObject textObject = new GameObject("Yýldýz");
                    textObject.transform.position = new Vector3(((float)i), ((float)y - 0.15f), 0f);
                    // TextMeshPro bileþenini ekleyin ve metni ayarlayýn
                    TextMeshPro textMeshPro = textObject.AddComponent<TextMeshPro>();
                    textMeshPro.text = "*"; // Metin içeriðini belirlediðiniz diziye göre alýn
                    textMeshPro.color = Color.white;
                    textMeshPro.fontSize = 9; // Metin boyutunu ayarlayabilirsiniz
                    textMeshPro.alignment = TextAlignmentOptions.Center; // Metin hizalamasýný ayarlayabilirsiniz
                    textMeshPro.font = font; // Kullanmak istediðiniz fontu ayarlayýn
                    continue;
                }
                if (i == a4 && y == b4)
                {
                    GameObject textObject = new GameObject("Yýldýz");
                    textObject.transform.position = new Vector3(((float)i), ((float)y - 0.15f), 0f);
                    // TextMeshPro bileþenini ekleyin ve metni ayarlayýn
                    TextMeshPro textMeshPro = textObject.AddComponent<TextMeshPro>();
                    textMeshPro.text = "*"; // Metin içeriðini belirlediðiniz diziye göre alýn
                    textMeshPro.color = Color.white;
                    textMeshPro.fontSize = 9; // Metin boyutunu ayarlayabilirsiniz
                    textMeshPro.alignment = TextAlignmentOptions.Center; // Metin hizalamasýný ayarlayabilirsiniz
                    textMeshPro.font = font; // Kullanmak istediðiniz fontu ayarlayýn
                    continue;
                }
                if (i == a5 && y == b5)
                {
                    GameObject textObject = new GameObject("Yýldýz");
                    textObject.transform.position = new Vector3(((float)i), ((float)y - 0.15f), 0f);
                    // TextMeshPro bileþenini ekleyin ve metni ayarlayýn
                    TextMeshPro textMeshPro = textObject.AddComponent<TextMeshPro>();
                    textMeshPro.text = "*"; // Metin içeriðini belirlediðiniz diziye göre alýn
                    textMeshPro.color = Color.white;
                    textMeshPro.fontSize = 9; // Metin boyutunu ayarlayabilirsiniz
                    textMeshPro.alignment = TextAlignmentOptions.Center; // Metin hizalamasýný ayarlayabilirsiniz
                    textMeshPro.font = font; // Kullanmak istediðiniz fontu ayarlayýn
                    continue;
                }
                if (i == a6 && y == b6)
                {
                    GameObject textObject = new GameObject("Yýldýz");
                    textObject.transform.position = new Vector3(((float)i), ((float)y - 0.15f), 0f);
                    // TextMeshPro bileþenini ekleyin ve metni ayarlayýn
                    TextMeshPro textMeshPro = textObject.AddComponent<TextMeshPro>();
                    textMeshPro.text = "*"; // Metin içeriðini belirlediðiniz diziye göre alýn
                    textMeshPro.color = Color.white;
                    textMeshPro.fontSize = 9; // Metin boyutunu ayarlayabilirsiniz
                    textMeshPro.alignment = TextAlignmentOptions.Center; // Metin hizalamasýný ayarlayabilirsiniz
                    textMeshPro.font = font; // Kullanmak istediðiniz fontu ayarlayýn
                    continue;
                }
                if (i == a7 && y == b7)
                {
                    GameObject textObject = new GameObject("Yýldýz");
                    textObject.transform.position = new Vector3(((float)i), ((float)y - 0.15f), 0f);
                    // TextMeshPro bileþenini ekleyin ve metni ayarlayýn
                    TextMeshPro textMeshPro = textObject.AddComponent<TextMeshPro>();
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

    void Update()
    {
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
            Debug.Log("O eþleþti 1");
        }
        if (c == 0 && (o3 + 1) == d && (o4 + 1) == e)
        {
            Debug.Log("O eþleþti 2");
        }


        if ((a + 1) == c && (b + 1) == d)
        {
            Debug.Log("Eþleþti");
        }
        if ((a2 + 1) == c && (b2 + 1) == d)
        {
            Debug.Log("Eþleþti2");
        }
        if ((a3 + 1) == c && (b3 + 1) == d)
        {
            Debug.Log("Eþleþti3");
        }
        if ((a4 + 1) == c && (b4 + 1) == d)
        {
            Debug.Log("Eþleþti4");
        }
        if ((a5 + 1) == c && (b5 + 1) == d)
        {
            Debug.Log("Eþleþti5");
        }
        if ((a6 + 1) == c && (b6 + 1) == d)
        {
            Debug.Log("Eþleþti6");
        }
        if ((a7 + 1) == c && (b7 + 1) == d)
        {
            Debug.Log("Eþleþti7");
        }
    }
}
