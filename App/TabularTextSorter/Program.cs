using System;
using System.Collections.Generic;
using TabularTextSorter.Options;

namespace TabularTextSorter
{
    public class Program
    {
        public static Type DataType { get; set; }
        public static void Main(string[] args)
        {
            try
            {
                //Get Input file path from User input
                Console.WriteLine("Please enter Input filepath: ");
                var inputfilePath = Console.ReadLine();

                //Get Output file path from User input
                Console.Write("Please enter Output filepath: ");
                var outputfilePath = Console.ReadLine();

                //Get Delimiter
                Console.WriteLine("Please enter csv File delimiter: ");
                var delimiter = Console.ReadLine();

                Console.WriteLine("Does Input file have header? ");
                var headerInput = Console.ReadLine();
                var hasheader = headerInput.Equals("yes", StringComparison.CurrentCultureIgnoreCase);


                Console.WriteLine("What is the index of the sort column:");
                var sortcolumn = int.Parse(Console.ReadLine());

                Console.WriteLine("What is the data type of the sort column:");

                var sortcolumndatatype = Console.ReadLine();
                var dataType = new DataTypeFactory
                (
                    new Dictionary<string, Type>()
                    {
                        {"string",typeof(string) },
                        {"integer",typeof(int) },
                        {"long",typeof(long) }
                    }
                ).GetDataType(sortcolumndatatype);

                //Parse data into a DataTable object instance
                var data = new TabularTextParser
                (
                    new TextParserOptions
                    (
                        inputfilePath,
                        outputfilePath,
                        delimiter,
                        hasheader,
                        sortcolumn,
                        dataType
                    )
                ).ParseText();

                //Sort the data
            }
            catch (Exception e)
            {
                Console.WriteLine("An error has occurred!");
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
