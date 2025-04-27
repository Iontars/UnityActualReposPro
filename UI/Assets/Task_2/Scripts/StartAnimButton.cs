using System;
using UnityEngine;

namespace Task_2.Scripts
{
    public class StartAnimButton : MonoBehaviour
    {
        public Action StartButtonPressed;
        private void OnMouseDown() => StartButtonPressed?.Invoke();
    }
}
