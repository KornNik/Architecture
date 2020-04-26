using System.Collections;
using UnityEngine;


namespace ChainOfResponsibility
{
    public sealed class RotateAFewSeconds : GameHandler
    {
        [SerializeField] private float _rotationSpeed = 10.0f;
        [SerializeField] private float _rotationDuration = 3.0f;

        private IEnumerator StartRotating(object request)
        {
            var t = 0.0f;
            while ( t  < _rotationDuration )
            {
                t += Time.deltaTime;
               transform.Rotate(Vector3.forward * (_rotationSpeed * Time.deltaTime));
               yield return null;
            }
            base.Handle(request);

        }
        public override object Handle(object request)
        {
            if (request is RotateAFewSeconds)
            {
                return StartCoroutine(StartRotating(request));
            }
            else
            {
                var temp = request as RotateAFewSeconds;
                return StartCoroutine(StartRotating(temp));
            }
        }



    }
}
