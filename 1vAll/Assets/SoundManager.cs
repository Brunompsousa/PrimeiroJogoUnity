using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{

    public static AudioClip shotSound;
    public static AudioClip deadSound;
    public static AudioClip deadEnemy;

    static AudioSource audioSrc;

    public AudioMixer mixer;


    // Start is called before the first frame update
    void Start()
    {
        shotSound = Resources.Load<AudioClip>("shot");
        deadSound = Resources.Load<AudioClip>("deadsound");
        deadEnemy = Resources.Load<AudioClip>("deadenemy"); 

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound()
    {
        audioSrc.PlayOneShot(shotSound);
    }

    public static void PlaySoundGameover()
    {
        audioSrc.PlayOneShot(deadSound);
    }

    public static void PlaySounddeadEnemy()
    {
        audioSrc.PlayOneShot(deadEnemy);
    }

    public void Soundvol(float vol)
    {
        mixer.SetFloat("MasterVol", Mathf.Log10(vol) * 20);
    }
}
