using UnityEngine;

namespace Assets.Scripts
{
    class ListenerHitAudio
    {
        public void Add(IAudio value)
        {
            value.OnHitAudio += ValueOnHitAudio;
        }

        public void Remove(IAudio value)
        {
            value.OnHitAudio -= ValueOnHitAudio;
        }

        private void ValueOnHitAudio(AudioSource audioSource)
        {
            audioSource.Play();
        }
    }
}
