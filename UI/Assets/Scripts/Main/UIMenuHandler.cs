using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMenuHandler : MonoBehaviour, IDisposable
{
    [Header("Список панелек выбора подменю")][Space]
    [SerializeField] private List<SelectPanel> selectPanels;
    
    private void SetActivePanel(GameObject go)
    {
        foreach (var item in selectPanels)
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
        foreach (var item in selectPanels)
        {
            item.OnSelect += SetActivePanel;
        } 
    }
    
    public void Dispose()
    {
        foreach (var item in selectPanels)
        {
            item.OnSelect -= SetActivePanel;
        } 
    }
}
