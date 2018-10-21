using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundController : MonoBehaviour {

    public AudioMixerSnapshot outsideWater;
    public AudioMixerSnapshot underWater;
    public AudioClip sting;
    public AudioSource stingSource;
    // random 60 bpm
    public float bpm = 60;

    private float m_TransitionIn;
    private float m_TransitionOut;
    private float m_QuarterNote;


    // Use this for initialization
    void Start () {
        m_QuarterNote = bpm / 60;
        m_TransitionIn = m_QuarterNote;
        m_TransitionOut = m_QuarterNote;
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TriggerWaterSound"))
        {
            outsideWater.TransitionTo(m_TransitionIn);
            stingSource.clip = sting;
            stingSource.Play();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("TriggerWaterSound"))
        {
            underWater.TransitionTo(m_TransitionOut);
        }
    }
}
