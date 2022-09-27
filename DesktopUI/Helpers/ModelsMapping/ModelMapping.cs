using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopUI.Helpers.ModelsMapping
{
    internal abstract class ModelMapping<FromObj, ToObj>
    {
        public List<ToObj> CreateMap(List<FromObj> fromList)
        {
            List<ToObj> _toList = new();

            fromList.ForEach(obj => _toList.Add(SpecificMapping(obj!)));

            return _toList;
        }
        protected abstract ToObj SpecificMapping(FromObj fromObj);
    }
}
