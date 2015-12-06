using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern
{
    /// <summary>
    /// Renders list of string with adding lines before and after rendered text
    /// </summary>
    class DataRenderer
    {
        private readonly IEnumerable<string> _elements; 

        public DataRenderer(IEnumerable<string> elementsToRender)
        {
            _elements = elementsToRender; 
        }

        public void Render(TextWriter writer)
        {
            writer.WriteLine("Starting rendering...");

            foreach(var elem in _elements)
            {
                writer.WriteLine(elem); 
            }

            writer.WriteLine("Ending rendering...");
        }
    }
}
