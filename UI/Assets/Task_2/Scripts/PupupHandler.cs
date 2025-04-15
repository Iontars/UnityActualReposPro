using System.Collections;
using UnityEngine;
using UnityEngine.VFX;

public class PupupHandler : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private StartAnimButton _startAnimButton;
    [SerializeField] private VisualEffect _skyVFX;
    [SerializeField] private VisualEffect _leftPetard;
    [SerializeField] private VisualEffect _rightPetard;
    
    private AnimatorStateInfo stateInfo;


    private void Awake()
    {
        
    }

    
    private void RunPopupAnim()
    {
        _animator.gameObject.SetActive(true);
        _animator.SetBool(Constants.PopupStartAnim, true);
        _animator.Play("MainPopup");
        
        StartCoroutine(WaitForAnimationEnd("MainPopup"));
    }
    
    private IEnumerator WaitForAnimationEnd(string stateName)
    {
        yield return new WaitUntil(() =>
            _animator.GetCurrentAnimatorStateInfo(0).IsName(stateName)
        );
        
        yield return new WaitUntil(() =>
            _animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.9f
        );
        
        RunVFX(); 
    }
    
    private void RunVFX()
    {
        _skyVFX.Play();
        _leftPetard.Play();
        _rightPetard.Play();
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
