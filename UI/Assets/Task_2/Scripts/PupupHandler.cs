using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class PupupHandler : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private StartAnimButton _startAnimButton;
    [SerializeField] private List<VisualEffect> _vfxEffects;
    private float _vfxOnSet = 0.2f;
    
    private void RunPopupAnim()
    {
        _animator.gameObject.SetActive(true);
        _animator.SetBool(Constants.PopupStartAnim, true);
        _animator.Play(Constants.MainPopupAnimName);
        
        StartCoroutine(WaitForAnimationEnd(Constants.MainPopupAnimName));
    }
    
    private IEnumerator WaitForAnimationEnd(string stateName)
    {
        yield return new WaitUntil(() =>
            _animator.GetCurrentAnimatorStateInfo(0).IsName(stateName)
        );
        
        yield return new WaitUntil(() =>
            _animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= _vfxOnSet
        );
        
        RunVFX(); 
    }
    
    private void RunVFX()
    {
        foreach (var effect in _vfxEffects)
        {
            effect.gameObject.SetActive(true);
            effect.Play();
        }
    }

    private void OnEnable()
    {
        _startAnimButton.StartButtonPressed += RunPopupAnim;
    }
    
    private void OnDisable()
    {
        _startAnimButton.StartButtonPressed -= RunPopupAnim;
    }
    
}
