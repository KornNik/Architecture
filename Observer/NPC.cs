using System;
using UnityEngine;


namespace Assets.Scripts
{
    public sealed class NPC : MonoBehaviour, IHit, IAudio
    {
        public event Action<float> OnHitChange = delegate (float f) { };
        public event Action<AudioSource> OnHitAudio = delegate (AudioSource audioSource) { };

        public void Hit(float damage)
        {
            OnHitChange.Invoke(damage);
        }

        public void HitAudio(AudioSource audioSource)
        {
            OnHitAudio.Invoke(audioSource);
        }
    }
}
