using System.Collections;
using System.Collections.Generic;
using Task_1.Scripts.Main;
using UnityEngine;
using UnityEngine.VFX;

namespace Task_2.Scripts
{
    public class PupupHandler : MonoBehaviour
    {
        [SerializeField] private Animator _animator;
        [SerializeField] private StartAnimButton _startAnimButton;
        [SerializeField] private List<VisualEffect> _vfxEffects;
        private float _vfxOnSet = 0.5f;
    
        private void RunPopupAnim()
        {
            StopVFX();
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

        private void StopVFX()
        {
            foreach (var effect in _vfxEffects)
            {
                effect.gameObject.SetActive(false);
                effect.Stop();
            }
        }
    
        private void RunVFX()
        {
            foreach (var effect in _vfxEffects)
            {
                effect.gameObject.SetActive(true);
                effect.Play();
            }
        }

        private void OnEnable() => _startAnimButton.StartButtonPressed += RunPopupAnim;
    
        private void OnDisable() => _startAnimButton.StartButtonPressed -= RunPopupAnim;
    
    }
}
