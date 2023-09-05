using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI[] starTexts; // "*" karakterlerini temsil eden TMP Text nesnelerini bu diziye sürükleyip býrakýn veya atayýn.
    public TextMeshProUGUI[] oTexts;    // "O" karakterlerini temsil eden TMP Text nesnelerini bu diziye sürükleyip býrakýn veya atayýn.

    private void Start()
    {
        // Rastgele 10 "*" karakterini aç
        RandomlyOpenStars(10);
    }

    private void RandomlyOpenStars(int countToOpen)
    {
        if (countToOpen <= 0 || countToOpen > starTexts.Length)
        {
            Debug.LogWarning("Geçersiz yýldýz sayýsý.");
            return;
        }

        int openedCount = 0;
        while (openedCount < countToOpen)
        {
            int randomIndex = Random.Range(0, starTexts.Length);

            // Eðer bu TMP Text nesnesi kapalýysa, "*" karakterini göster
            if (!starTexts[randomIndex].gameObject.activeSelf)
            {
                starTexts[randomIndex].gameObject.SetActive(true);
                openedCount++;
            }
        }
    }
}
