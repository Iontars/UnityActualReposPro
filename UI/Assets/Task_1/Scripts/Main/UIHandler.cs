using System.Collections.Generic;
using UnityEngine;

namespace Task_1.Scripts.Main
{
    public abstract class UIHandler<T> : MonoBehaviour  where T: UIPanel
    {
        [Header("Элементы UI")]
        [SerializeField] private List<T> elements;
    
        protected virtual void SetActivePanel(GameObject go)
        {
            foreach (var item in elements)
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
}
