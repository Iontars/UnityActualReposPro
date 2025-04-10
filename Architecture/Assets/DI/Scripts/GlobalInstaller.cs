using System;
using DI.Scripts;
using UnityEngine;
using Zenject;

public class GlobalInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        switch (SystemInfo.deviceType)
        {
            case DeviceType.Desktop:
                Container.Bind<IInput>().To<DesktopInput>().FromNew().AsSingle();
                break;
            case DeviceType.Handheld:
                Container.Bind<IInput>().To<MobileInput>().FromNew().AsSingle();
                break;
            default:
                throw new ArgumentOutOfRangeException();
            
        }
    }
}
