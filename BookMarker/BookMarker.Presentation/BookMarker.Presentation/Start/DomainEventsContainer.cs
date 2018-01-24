using System;
using System.Collections.Generic;
using BookMarker.Core.Domain.Interfaces;

namespace BookMarker.Presentation.Start
{
    public class DomainEventsContainer : IContainer
    {

        public IEnumerable<T> GetAllInstances<T>()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> GetAllInstances(Type serviceType)
        {
            throw new NotImplementedException();
        }

        public T GetInstance<T>()
        {
            throw new NotImplementedException();
        }

        public object GetInstance(Type serviceType)
        {
            throw new NotImplementedException();
        }
    }
}
