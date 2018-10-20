using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDownTimer : MonoBehaviour {
    private float countDownTimerStartTime;
    private int countDownTimerDuration;

    public int GetTotalSeconds()
    {
        return countDownTimerDuration;
    }
    public void ResetTimer(int seconds)
    {
        countDownTimerStartTime = Time.time;
        countDownTimerDuration = seconds;
    }
    public int GetSecondsRemaining()
    {
        int ElapsedSeconds = (int)(Time.time - countDownTimerStartTime);
        int SecondsLeft = (countDownTimerDuration - ElapsedSeconds);
        return SecondsLeft;
    }
    public float GetFractionsSecondsRemaining()
    {
        float ElapsedSeconds = (Time.time - countDownTimerStartTime);
        float SecondsLeft = (countDownTimerDuration - ElapsedSeconds);
        return SecondsLeft;
        
    }
    public float GetProportionTimeRemaining()
    {
        float ProportionLeft = (float)GetFractionsSecondsRemaining() / (float)GetTotalSeconds();
        return ProportionLeft;
    }
	
}
