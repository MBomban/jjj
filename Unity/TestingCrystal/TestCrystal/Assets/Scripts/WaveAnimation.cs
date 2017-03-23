﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveAnimation : IPlayerAnimator {

    public void playAnimation(Animator crystalChan)
    {
        crystalChan.SetBool("isWaving", true);
    }

    public void stopAnimation(Animator crystalChan)
    {
        crystalChan.SetBool("isWaving", false);
    }
}
