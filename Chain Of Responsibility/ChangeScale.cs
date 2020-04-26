using System.Collections;
using UnityEngine;

namespace ChainOfResponsibility
{
    class ChangeScale : GameHandler
    {
        [SerializeField] private float _scaleNeed = 2.0f;
        [SerializeField] private float _scaleDuration = 10.0f;
        private Vector3 _scale;

        private void Awake()
        {
            _scale = transform.localScale;
        }
        private IEnumerator StartScaling(object request)
        {
            var t = 0.0f;
            while (t < _scaleDuration)
            {
                t += Time.deltaTime;
                transform.localScale = new Vector3(Mathf.Lerp(_scale.x, _scaleNeed, t/_scaleDuration),
                    Mathf.Lerp(_scale.y, _scaleNeed, t /_scaleDuration), Mathf.Lerp(_scale.z, _scaleNeed, t /_scaleDuration));
                yield return null;
            }
            base.Handle(request);

        }
        public override object Handle(object request)
        {
            if (request is ChangeScale)
            {
                return StartCoroutine(StartScaling(request));
            }
            else
            {
                var temp = request as ChangeScale;
                return StartCoroutine(StartScaling(temp));
            }
        }
    }
}
