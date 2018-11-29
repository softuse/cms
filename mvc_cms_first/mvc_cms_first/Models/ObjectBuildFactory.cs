using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_cms_first.Models
{
    public class ObjectBuildFactory<T>
    {
        public static T Instance(string key)
        {
            Type obj = Type.GetType(key);
            if (obj == null) return default(T);

            T factory =(T) obj.Assembly.CreateInstance(obj.FullName);
            return factory;
        }
    }
}
