using System;
using UnityEngine;

namespace DI.Scripts
{
    public class MobileInput : IInput
    {
        public event Action<Vector3> ClickDown;
        public event Action<Vector3> ClickUp;
        public event Action<Vector3> Drag;
    }
}
