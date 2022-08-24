using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class MenuView : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private Transform _startPoint;
    [SerializeField] private Transform _destinationPoint;
    [SerializeField] private float _speed;

    private float _distance;

    public UnityAction AnimationFinished;

    private void OnEnable()
    {
        transform.position = _startPoint.position;
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

        AnimationFinished?.Invoke();
    }
}
