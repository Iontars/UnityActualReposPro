using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class MusicPanelHandler : MonoBehaviour
{
    [FormerlySerializedAs("checkboxes")]
    [Header("Радио кнопки выбора музыки")][Space]
    [SerializeField] private List<MusicPanel>  FlagBoxes;

    private void SetActivePanel(GameObject go)
    {
        foreach (var item in FlagBoxes)
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
        foreach (var item in FlagBoxes)
        {
            item.OnSelect += SetActivePanel;
        } 
    }
    
    public void Dispose()
    {
        foreach (var item in FlagBoxes)
        {
            item.OnSelect -= SetActivePanel;
        } 
    }
}
