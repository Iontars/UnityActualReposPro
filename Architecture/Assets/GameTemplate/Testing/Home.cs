using System;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class Home : MonoBehaviour
{
    void Start()
    {
        print(Process(_ => new Engine().Run()));
    }

    private T Process<T>(Func<IRun, T> engine)
    {
       return engine.Invoke(null);
    }
}

interface IRun
{
    public int Run();
}
class Engine : IRun
{
    private int Value { get; set; } = 10;

    public int Run()
    {
        Debug.Log("value ");
        return Value;
    }
}
