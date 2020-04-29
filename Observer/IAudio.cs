using System;
using UnityEngine;


namespace Assets.Scripts
{
    interface IAudio
    {
        event Action<AudioSource> OnHitAudio;
        void HitAudio(AudioSource audioSource);
    }
}
