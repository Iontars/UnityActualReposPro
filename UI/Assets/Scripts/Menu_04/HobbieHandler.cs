using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HobbieHandler : MonoBehaviour
{
    [Header("Элементы UI")]
    [SerializeField] private List<HobbieFlag> elements;
    
    
    private void SetActivePanel(GameObject go)
    {
        go.SetActive(!go.activeSelf);
    }
    
    private void OnEnable()
    {
        foreach (var item in elements)
        {
            item.OnSelect += SetActivePanel;
        } 
    }
    
    public void OnDisable()
    {
        foreach (var item in elements)
        {
            item.OnSelect -= SetActivePanel;
        } 
    }
    
    
}
