﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetVolume : MonoBehaviour
{
    public AudioMixer mixer;

    public void ChangeVolume(float AudioSliderValue) {

        mixer.SetFloat("MusicVol", Mathf.Log10(AudioSliderValue) * 20);
    }
}
