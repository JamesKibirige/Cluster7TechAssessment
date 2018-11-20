using System;

namespace TabularTextSorter.Interfaces
{
    public interface IDataTypeFactory
    {
        Type GetDataType(string dataTypeName);
    }
}