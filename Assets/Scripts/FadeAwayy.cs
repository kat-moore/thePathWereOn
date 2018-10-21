using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(CountDownTimee))]
public class FadeAwayy : MonoBehaviour
{
    //
    private CountDownTimee countDownTimer;
    private Text textUI;
    //Number of seconds before the text completely fades away.

    private int startSeconds = 20;
    private bool fading = false;


    // Use this for initialization
    void Start()
    {
        textUI = GetComponent<Text>();
        countDownTimer = GetComponent<CountDownTimee>();

        StartFading(startSeconds);
    }


    // Update is called once per frame
    void Update()
    {
        if (fading)
        {
            //GEt the time remaining as a float betweeen 0.0 and 1.0
            float alphaRemaining = countDownTimer.GetProportionTimeRemaining();
            print(alphaRemaining);
            Color c = textUI.material.color;

            //set alpha to time remaining percentgae
            //s0 1.0 means full text color .5 means half transparent, etc.
            c.a = alphaRemaining;
            textUI.material.color = c;
            //stop fading one very small number
            if (alphaRemaining < 0.01)
            {
                fading = false;
            }
        }

        float beenOnScreenLongEnough = 45;
        if (Time.fixedTime > beenOnScreenLongEnough)
        {
            textUI.gameObject.SetActive(false);
        }

    }

    private void StartFading(int timerTotal)
    {
        countDownTimer.ResetTimer(timerTotal);

        fading = true;
    }
}
