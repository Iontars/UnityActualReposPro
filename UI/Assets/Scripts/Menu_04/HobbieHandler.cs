using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HobbieHandler : UIHandler<HobbieFlag>
{
    protected override void SetActivePanel(GameObject go)
    {
        go.SetActive(!go.activeSelf);
    }
}
