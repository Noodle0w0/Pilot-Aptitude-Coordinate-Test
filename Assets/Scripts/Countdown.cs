using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class Countdown : MonoBehaviour
{
    public TextMeshProUGUI countdownText100;
    public TextMeshProUGUI countdownText5;

    private int countdownValue100 = 100;
    private int countdownValue5 = 5;
    private int countdownRepeatCount = 20;

    private bool isCountingDown100 = false;
    private bool isCountingDown5 = false;

    void Start()
    {
        // Baþlangýçta sayaç deðerlerini TMP nesnelerine yaz
        countdownText100.text = countdownValue100.ToString();
        countdownText5.text = countdownValue5.ToString();

        // Hem 100'den hem de 5'ten geriye saymayý baþlat
        StartCountdown100();
        StartCountdown5();
    }

    void StartCountdown100()
    {
        isCountingDown100 = true;
        StartCoroutine(Countdown100());
    }

    void StartCountdown5()
    {
        isCountingDown5 = true;
        StartCoroutine(Countdown5());
    }

    IEnumerator Countdown100()
    {
        while (countdownValue100 > 0 && isCountingDown100)
        {
            yield return new WaitForSeconds(1f); // Her saniyede bir 100'den geriye say
            countdownValue100--;
            countdownText100.text = countdownValue100.ToString();

            if (countdownValue100 == 0)
            {
                Debug.Log("100'den geriye sayma bitti");
                isCountingDown100 = false;

                SceneManager.LoadScene("MainScene");
            }
        }
    }

    IEnumerator Countdown5()
    {
        while (countdownRepeatCount > 0 && isCountingDown5)
        {
            yield return new WaitForSeconds(1f); // Her saniyede bir 5'ten geriye say
            countdownValue5--;
            countdownText5.text = countdownValue5.ToString();

            if (countdownValue5 == 0)
            {
                countdownRepeatCount--;
                Debug.Log("5'ten geriye sayma bitti");

                if (countdownRepeatCount == 0)
                {
                    Debug.Log("20 kere geriye sayma bitti");
                    isCountingDown5 = false;
                }
                else
                {
                    // 5'ten geriye sayma bittiðinde, bir sonraki 5'ten geriye saymayý baþlat
                    countdownValue5 = 5;
                }
            }
        }
    }
}
