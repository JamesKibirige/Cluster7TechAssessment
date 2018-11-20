using System;
using System.Collections.Generic;
using TabularTextSorter.Interfaces;

namespace TabularTextSorter
{
    public class DataTypeFactory : IDataTypeFactory
    {
        private readonly IDictionary<string, Type> _dataTypeMappings;

        public DataTypeFactory(IDictionary<string, Type> dataTypeMappings)
        {
            this._dataTypeMappings = dataTypeMappings;
        }

        public Type GetDataType(string dataTypeName)
        {
            Type result = null;
            foreach (var mapping in _dataTypeMappings)
            {
                if (mapping.Key.Equals(dataTypeName, StringComparison.CurrentCultureIgnoreCase))
                {
                    result = mapping.Value;
                }
            }

            return result;
        }
    }
}