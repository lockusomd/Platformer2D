using UnityEngine;

public class PlayerAnimatorData
{
    public static class Params
    {
        public static readonly int Run = Animator.StringToHash(nameof(Run));
        public static readonly int Jump = Animator.StringToHash(nameof(Jump));
    }
}
