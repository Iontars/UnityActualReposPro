using UnityEngine;

public class FlagButtonHandler : UIHandler<FlagButtonPanel>
{
    protected override void SetActivePanel(GameObject go)
    {
        go.SetActive(!go.activeSelf);
    }
}
