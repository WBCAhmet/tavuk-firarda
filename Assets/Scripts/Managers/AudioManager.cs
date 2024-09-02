using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource jumpAS;
    public AudioSource positiveAS;
    public AudioSource backgroundAS;
    public AudioSource deathAS;
    public AudioSource carAS;
    public void PlayJumpSound()
    {
        jumpAS.Play();
    }

    public void PlayPositiveSound()
    {
        positiveAS.Play();
    }

    public void PlayBackgroundSound()
    {
        backgroundAS.Play();
    }

    public void PlayDeathSound()
    {
        deathAS.Play();
    }
    public void PlayCarSound()
    {
        carAS.Play();
    }
}
