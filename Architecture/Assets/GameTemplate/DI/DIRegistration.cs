using System;
using Unity.VisualScripting;

namespace GameTemplate.DI
{
    public class DIRegistration
    {
        public Func<DIContainer, object> Factory { get; set; }
        public bool isSingleton { get; set; }
        public object Instance { get; set; }
    }
}