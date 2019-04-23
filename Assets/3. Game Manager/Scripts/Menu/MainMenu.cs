﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Animation mainMenuAnimator;
    [SerializeField] private AnimationClip fadeOutAnimation;
    [SerializeField] private AnimationClip fadeInAnimation;

    public void OnFadeOutComplete()
    {
        Debug.Log("FadeOut Complete");
    }

    public void OnFadeInComplete()
    {
        Debug.Log("FadeIn Complete");
    }

    public void FadeIn()
    {
        mainMenuAnimator.Stop();
        mainMenuAnimator.clip = fadeInAnimation;
        mainMenuAnimator.Play();
    }

    public void FadeOut()
    {
        mainMenuAnimator.Stop();
        mainMenuAnimator.clip = fadeOutAnimation;
        mainMenuAnimator.Play();
    }
}
