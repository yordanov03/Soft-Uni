using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Logger.Models
{
    using Models.Contracts;
    public class ConsoleAppender : IAppender
    {

        public ConsoleAppender(ILayout layout, ErrorLevel level)
        {
            this.Layout = layout;
            this.Level = level;
        }
        public ILayout Layout { get; }
        public ErrorLevel Level { get; }

        public void Append(IError error)
        {
            string formattedError = this.Layout.FormatError(error);
            Console.WriteLine(formattedError);
        }
    }
}
