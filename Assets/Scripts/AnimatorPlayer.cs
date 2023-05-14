using UnityEngine;
using UnityEngine.Events;

public class AnimatorPlayer : MonoBehaviour
{    
    public event UnityAction OnKickedAnimationFinished;

    public void AnimationEvent()
    {
        OnKickedAnimationFinished.Invoke();
    }

    public static class Params
    {
        public const string IsAiming = ("isAiming");
    }

    public static class States
    {
        public const string Idle = nameof(Idle);
        public const string Strike = nameof(Strike);
    }
}
