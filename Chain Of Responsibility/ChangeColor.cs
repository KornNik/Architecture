using System.Collections;
using UnityEngine;

namespace ChainOfResponsibility
{
    class ChangeColor : GameHandler
    {
        [SerializeField] private Renderer _renderer;
        [SerializeField] private Color color;


        private IEnumerator SetColor(object request)
        {
            _renderer.material.color = color;
            yield return null;
            base.Handle(request);
        }

        public override object Handle(object request)
        {
            if (request is ChangeColor)
            {
                return StartCoroutine(SetColor(request));
            }
            else
            {
                var temp = request as ChangeColor;
                return StartCoroutine(SetColor(temp));
            }
        }
    }
}
