using UnityEngine;

namespace Entry
{
    public class Three : MonoBehaviour, IRunCode
    {
        [SerializeField] private TwoScri _twoScri;
        public void Run()
        {
            print(GetType().Name);
        }

        public bool Check()
        {
            return _twoScri != null;
        }
    }
}