using System;

namespace TabularTextSorter.Options
{
    public class TextParserOptions
    {
        public string Inputfilepath { get; }
        public string OutputfilePath { get; }
        public string Delimeter { get; }
        public bool Hasheader { get; }
        public int Sortcolumn { get; }
        public Type SortcolumndataType { get; }

        public TextParserOptions(string inputfilepath, string outputfilePath, string delimeter, bool hasheader, int sortcolumn, Type sortcolumndataType)
        {
            Inputfilepath = inputfilepath;
            OutputfilePath = outputfilePath;
            Delimeter = delimeter;
            Hasheader = hasheader;
            Sortcolumn = sortcolumn;
            SortcolumndataType = sortcolumndataType;
        }

    }
}