using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesktopUI.Helpers
{
    internal static class ModelMapping
    {
        public static To Map<To>(object fromObj)
        {
            var _toObj = Activator.CreateInstance<To>();
            var _properties = _toObj!.GetType().GetProperties();
            for (int i = 0; i < _properties.Length; i++)
            {
                var value = fromObj.GetType().GetProperty(_properties[i].Name)?.GetValue(fromObj);
                _properties[i].SetValue(_toObj, value);
            }

            return _toObj!;
        }

        public static List<To> MapList<From, To>(List<From> fromList)
        {
            List<To> _toList = new();

            fromList.ForEach(obj => _toList.Add(Map<To>(obj!)));

            return _toList;
        }
    }
}
