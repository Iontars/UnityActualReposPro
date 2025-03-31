using System;
using UnityEngine;
using System.Collections;
using DG.Tweening;

public class Cube : MonoBehaviour
{
    
    [SerializeField] Transform _cubeTransform;
    [SerializeField] Vector3 _rotate;
    [SerializeField] float _duration;
    private Vector3 _startPosition;
    private Vector3 _targetPosition;
    private Tween _animation;

    private void Awake()
    {
        _startPosition = _cubeTransform.position;
        _targetPosition = Vector3.right;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _animation = _cubeTransform.DOMove(_targetPosition * 10, _duration).From(_startPosition).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
            //_cubeTransform.DORotate(_rotate, _duration, RotateMode.FastBeyond360).From(_startPosition).SetLoops(-1, LoopType.Yoyo);
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            _animation.Kill(false);
            _animation.Complete(false);
        }
    }
}
