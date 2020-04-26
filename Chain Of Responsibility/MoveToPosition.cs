using System.Collections;
using UnityEngine;


namespace ChainOfResponsibility
{
    public sealed class MoveToPosition : GameHandler
    {
        [SerializeField] private Vector3 _positionToMove;
        [SerializeField] private float _speed;

        private IEnumerator StartMoving(object request)
        {
            while ((transform.position -_positionToMove).sqrMagnitude > 0.0f)
            {
                transform.position = Vector2.MoveTowards(transform.position, _positionToMove, Time.deltaTime * _speed);
                yield return null;
            }
            base.Handle(request);
        }

        public override object Handle(object request)
        {
            if (request is MoveToPosition)
            {
                return StartCoroutine(StartMoving(request));
            }
            else
            {
                var temp = request as MoveToPosition;
                return StartCoroutine(StartMoving(temp));
            }
        }
    }
}
