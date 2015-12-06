using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern
{
    /// <summary>
    /// Adapter class implements the same interface as client using it requires
    /// </summary>
    class DataRendererAdapter : IDataRenderer
    {
        private DataRenderer _dataRenderer; // our legacy renderer (already working and tested)

        /// <summary>
        /// This method allows to combine incompatible interfaces
        /// </summary>
        /// <param name="patterns"></param>
        /// <returns></returns>
        public string ListPatterns(IEnumerable<Pattern> patterns)
        {
            _dataRenderer = new DataRenderer(patterns.Select(s => s.Id + " " + s.Name));
            StringWriter writer = new StringWriter();

            _dataRenderer.Render(writer);

            return writer.ToString(); 
        }
    }
}
