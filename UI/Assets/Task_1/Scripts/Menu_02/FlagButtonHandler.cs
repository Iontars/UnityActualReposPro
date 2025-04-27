using Task_1.Scripts.Main;
using UnityEngine;

namespace Task_1.Scripts.Menu_02
{
    public class FlagButtonHandler : UIHandler<FlagButtonPanel>
    {
        protected override void SetActivePanel(GameObject go)
        {
            go.SetActive(!go.activeSelf);
        }
    }
}
