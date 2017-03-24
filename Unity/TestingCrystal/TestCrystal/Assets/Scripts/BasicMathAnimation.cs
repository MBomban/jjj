﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMathAnimation : IPlayerAnimator
{
    public void playAnimation(Animator crystalChan)
    {
        crystalChan.SetBool("isCalculating", true);
    }

    public void stopAnimation(Animator crystalChan)
    {
        crystalChan.SetBool("isCalculating", false);
    }
}