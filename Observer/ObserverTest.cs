using UnityEngine;


namespace Assets.Scripts
{
    public sealed class ObserverTest : MonoBehaviour
    {
        public Enemy Enemy;
        public NPC NPC;
        public float Damage;
        private Camera _mainCamera;
        private AudioSource _audioSource;
        private float _dedicateDistance = 20.0f;

        private void Start()
        {
            _audioSource = GetComponent<AudioSource>();
            _mainCamera = Camera.main;

            var listenerHitAudio = new ListenerHitAudio();
            listenerHitAudio.Add(NPC);
            var listenerHitShowDamage = new ListenerHitShowDamage();
            listenerHitShowDamage.Add(NPC);
            listenerHitShowDamage.Add(Enemy);
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (Physics.Raycast(_mainCamera.ScreenPointToRay(Input.mousePosition),
                    out var hit, _dedicateDistance))
                {
                    if (hit.collider.TryGetComponent<NPC>(out var npc))
                    {
                        npc.Hit(Damage);
                        npc.HitAudio(_audioSource);
                    }
                    if (hit.collider.TryGetComponent<Enemy>(out var enemy))
                    {
                        enemy.Hit(Damage);
                    }
                }
            }
        }
    }
}
