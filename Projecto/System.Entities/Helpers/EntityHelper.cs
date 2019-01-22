using System;
using System.Collections;
using System.Collections.Generic;

namespace System.Entities.Helpers
{
    public static class EntityHelper
    {
        public static IList CreateList(Type type)
        {
            var genericList = typeof(List<>).MakeGenericType(type);
            return (IList)Activator.CreateInstance(genericList);
        }
    }
}
