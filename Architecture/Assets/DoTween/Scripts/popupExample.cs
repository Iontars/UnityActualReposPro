using UnityEngine;

public class popupExample : MonoBehaviour
{
    [SerializeField] private Popup _popup;
    private Transform _children;

    private void Awake()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            _popup.gameObject.SetActive(true);
            _popup.Show();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            _children = _popup.transform.GetChild(0);
            _popup.Hide(() => _children?.gameObject.SetActive(false)); ;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            _popup.CompleteCurrentAnimation();
        }
        
        
        
    }
}
