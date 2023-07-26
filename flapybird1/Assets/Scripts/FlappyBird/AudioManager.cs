using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static AudioManager Instance;
    public AudioSource audioSource;
    public AudioClip Swing;
    public AudioClip Die;
    public AudioClip Hit;
    public AudioClip Point;
    
    void Start()
    {
        Instance = this;
    }

    public void PlaySwing()
    {
        audioSource.PlayOneShot(Swing);
    }

    public void PlayDie()
    {
        audioSource.PlayOneShot(Die);
    }

    public void PlayHit()
    {
        audioSource.PlayOneShot(Hit);
    }
    public void PlayPoint()
    {
        audioSource.PlayOneShot(Point);
    }
    
}
