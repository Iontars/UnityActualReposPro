using Task_1.Scripts.Main;
using UnityEngine;

namespace Task_1.Scripts.Menu_04
{
    public class HobbieHandler : UIHandler<HobbieFlag>
    {
        protected override void SetActivePanel(GameObject go)
        {
            go.SetActive(!go.activeSelf);
        }
    }
}
