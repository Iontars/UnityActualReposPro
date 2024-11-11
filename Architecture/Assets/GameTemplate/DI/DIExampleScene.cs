using UnityEngine;

namespace GameTemplate.DI
{
    public class DIExampleScene : MonoBehaviour
    {
        public void Init(DIContainer projectContainer)
        {
            var serviceWhithoutTag = projectContainer.Resolve<MyAwesomeProjectService>();
            var service1 = projectContainer.Resolve<MyAwesomeProjectService>("Option1");
            var service2 = projectContainer.Resolve<MyAwesomeProjectService>("Option2");
            
            var sceneContainer = new DIContainer(projectContainer);
            sceneContainer.RegisterSingleton(c => new MySceneService(c.Resolve<MyAwesomeProjectService>()));
        }
    }
}