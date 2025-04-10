using System;
using Unity.VisualScripting;
using UnityEngine;
using Zenject;

namespace DI.Scripts
{
    public class GamePlaySceneInstaller : MonoInstaller
    {
        private DesktopInput DesktopInput;
        private enum MyEnum
        {
            DesktopInput, MobileInput
        }
        
        [SerializeField] private MyEnum _input;
        
        public override void InstallBindings()
        {
            // switch (_input)
            // {
            //     case MyEnum.DesktopInput:
            //         Container.Bind<IInput>().To<DesktopInput>().FromNew().AsSingle();
            //         break;
            //     case MyEnum.MobileInput:
            //         Container.Bind<IInput>().To<MobileInput>().FromNew().AsSingle();
            //         break;
            //     default:
            //         throw new ArgumentOutOfRangeException();
            // } 
            
            
            //Container.Bind<MovementHandler>().FromNew().AsSingle();
            //Container.Bind<TestClass>().FromNew().AsSingle().NonLazy();
        }
    }
}
