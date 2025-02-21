using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public static AudioPlayer instance;

    public AudioSource playerBGM;
    public AudioSource playerSFX;

    public List<AudioClip> bgmClip;

    public List<AudioClip> sfxClip;


    private void Awake()
    {
        instance = this;
    }


    private void Start()
    {
        PlayBGM(0);
    }

    public void PlayBGM(int index)
    {
        playerBGM.Stop();
        playerBGM.clip = bgmClip[index];
        playerBGM.loop = true;
        playerBGM.Play();
    }


    public void PlaySFX(int index)
    {
        playerSFX.Stop();
        playerSFX.clip = sfxClip[index]; //play audio sfx sesuai index di sfxClip
        playerSFX.Play();
    }
}
