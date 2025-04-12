using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagButtonHandler : MonoBehaviour, IDisposable
{
    [Header("Чек боксы кнопки")][Space]
    [SerializeField] private List<FlagButtonPanel>  checkboxes;
    
    private void SetActivePanel(GameObject go)
    {
        foreach (var item in checkboxes)
        {
            if (go == item.MyChild)
            {
                go.SetActive(true);
                continue;
            }
            item?.MyChild.SetActive(false);
        }
    }
    
    private void OnEnable()
    {
        foreach (var item in checkboxes)
        {
            item.OnSelect += SetActivePanel;
        } 
    }
    
    public void Dispose()
    {
        foreach (var item in checkboxes)
        {
            item.OnSelect -= SetActivePanel;
        } 
    }
}
