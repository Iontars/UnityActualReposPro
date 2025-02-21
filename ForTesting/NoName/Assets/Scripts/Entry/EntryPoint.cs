using System.Collections.Generic;
using UnityEngine;

namespace Entry
{
    /// <summary> </summary>
    public class EntryPoint : MonoBehaviour
    {
        [SerializeField] private List<GameObject> _runObjects;
        private List<IRunCode> _runCodes = new();
        private List<bool> isSuccess = new();
        void Start()
        {
            Activate();
        }

        private void Activate()
        {
            for (var i = 0; i < _runObjects.Count; i++)
            {
                if (_runObjects[i] == null)
                {
                    ErrorData.LogError(1);
                    break;
                }
                _runCodes.Add(_runObjects[i].GetComponent<IRunCode>());
                isSuccess.Add(_runCodes[i].Check());
            }

            IntegrityCheck();
        }

        private void IntegrityCheck()
        {
            if (isSuccess.Contains(false))
            {
                ErrorData.LogError(1);
            }
        }

        private void LoadScripts()
        {
            foreach (var r in _runCodes)
            {
                r.Run();
            }
        }
    }
}
