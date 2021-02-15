﻿using UnityEngine;


namespace BrunoMikoski.UIManager.Animation
{
    public enum FlowType 
    { 
        Append, 
        With 
    }

    public enum AnimationDirection
    {
        To, 
        From
    }

    public class AnimationController : MonoBehaviour
    {
        [SerializeReference]
        private BaseAnimationStep[] animationSteps = new BaseAnimationStep[0];
        public BaseAnimationStep[] AnimationSteps => animationSteps;

        // [ContextMenu("Play")]
        // public void Play()
        // {
        //     float totalTime = 0;
        //     for (int i = 0; i < animationSequence.Count; i++)
        //     {
        //         AnimatedItemFade animatedItemFade = animationSequence[i];
        //         animatedItemFade.Play(ref totalTime);
        //         totalTime += animatedItemFade.Delay + animatedItemFade.Duration;
        //     }
        // }
    }
}
