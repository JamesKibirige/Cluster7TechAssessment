using System.Data;
using TabularTextSorter.Interfaces;
using TabularTextSorter.Options;

namespace TabularTextSorter
{
    public class TabularTextParser : ITabularTextParser
    {
        private readonly TextParserOptions options;

        public TabularTextParser(TextParserOptions options)
        {
            this.options = options;
        }

        public DataTable ParseText()
        {
            throw new System.NotImplementedException();
        }
    }
}