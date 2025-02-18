using UnityEngine;

namespace Entry
{
    public class Three : MonoBehaviour, IRunCode
    {
        [SerializeField] private TwoScri _twoScri;
        public bool Run()
        {
            if (_twoScri != null)
            {
                print(GetType().Name);
                return true;
            }
            return false;
        }
    }
}