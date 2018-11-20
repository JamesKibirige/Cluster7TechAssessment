using System.Data;

namespace TabularTextSorter.Interfaces
{
    public interface ITabularTextParser
    {
        DataTable ParseText();
    }
}