using System;
using UnityEngine;
using Zenject;

namespace DI.Scripts
{
    public class TestClass
    {
        [Inject]
        public TestClass()
        {
            Debug.Log("TestClass");
        }
    }
    
    
    public class MovementHandler : IDisposable
    {
        private IInput _input;


        public MovementHandler(IInput input)
        {
            _input = input;
            
            Debug.Log(_input.GetType());
            
            _input.ClickDown += OnClickDown;
            _input.ClickUp += OnClickUp;
            _input.Drag += OnDrag;

        }

        public void OnClickDown(Vector3 position)
        {
            Debug.Log("Down");
        }
        
        public void OnClickUp(Vector3 position)
        {
            Debug.Log("Up");
        }
        
        public void OnDrag(Vector3 position)
        {
            Debug.Log("Drag");
        }

        public void Dispose()
        {
            _input.ClickDown -= OnClickDown;
            _input.ClickUp -= OnClickUp;
            _input.Drag -= OnDrag;
        }
    }
}
