using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[RequireComponent(typeof(CanvasGroup))]
public class MenuView : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _destinationPoint;
    [SerializeField] private Transform _startPoint;
    [SerializeField] private Image _image;

    private float _distance;
    private CanvasGroup _canvasGroup;

    private void Start()
    {
        transform.position = _startPoint.position;
        _canvasGroup = GetComponent<CanvasGroup>(); // теперь включаю менюшку тут перенести из скритпа Menu логику этого
        _distance = Vector2.Distance(_startPoint.position, _destinationPoint.position);
        StartCoroutine(Animating());
    }

    private IEnumerator Animating()
    {
        while (transform.position.x < _destinationPoint.position.x)
        {
            transform.position = Vector2.MoveTowards(transform.position, _destinationPoint.position, _speed * Time.deltaTime);
            float distanceXTraveled = Vector2.Distance(_startPoint.position, transform.position);
            float distanceProgress = distanceXTraveled / _distance;
            _image.fillAmount = distanceProgress;
            yield return null;
        }
    }

    private void OnAnimationFinished()
    {

    }
}
