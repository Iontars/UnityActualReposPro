using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class Popup : MonoBehaviour
{
    [SerializeField] private CanvasGroup _bodyAlfaGroup;
    [SerializeField] private RectTransform _body;
    [SerializeField] private Button _button;

    private Vector2 _targetBodyPosition;
    private Vector2 _startShift;
    private Sequence _animationSequence;
    void Awake()
    {
        _targetBodyPosition = _body.anchoredPosition;
        _startShift = new Vector2(_targetBodyPosition.x, - Screen.height / 2);
    }

    public void Show()
    {
        if (InAnimation())
        {
            _bodyAlfaGroup.gameObject.SetActive(true);
            _animationSequence = DOTween.Sequence();

            _animationSequence
                .Append(_bodyAlfaGroup.DOFade(1, 1f).From(0))
                .Join(_body.DOAnchorPos(_targetBodyPosition, 1f).From(_startShift))
                .Append(_button.transform.DOScale(1, 0.5f).From(0)).SetEase(Ease.OutBounce)
                .OnComplete(() => print("Ready to start"));
        }
    }

    public void Hide(Action callback)
    {
        if (InAnimation())
        {
            _animationSequence = DOTween.Sequence();

            _animationSequence
                .Append(_bodyAlfaGroup.DOFade(0, 1f).From(1))
                .Join(_body.DOAnchorPos(_startShift, 1f).From(_targetBodyPosition))
                .OnComplete(() => callback?.Invoke());
        }
    }

    public bool InAnimation() => _animationSequence == null || !_animationSequence.IsPlaying();
    
    public void CompleteCurrentAnimation() => _animationSequence.Complete(true);
}
