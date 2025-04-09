using DI.Scripts;
using UnityEngine;
using Zenject;

public class Player : MonoBehaviour
{
    private MovementHandler _movementHandler;

    [Inject]
    private void CreateDependency(MovementHandler movementHandler)
    {
        _movementHandler = movementHandler;
        Debug.Log(_movementHandler.ToString());
    }
    
}
