using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern
{
    /// <summary>
    /// Renders collection of patterns. 
    /// </summary>
    class PatternRendererClient
    {
        private IDataRenderer _dataRenderer;

        public PatternRendererClient(IDataRenderer dataRenderer)
        {
            _dataRenderer = dataRenderer; 
        }

        /// <summary>
        /// We want to list patterns using already existing DataRenderer class. 
        /// It's not compatible with our new "IDataRenderer" interface but it e.g. has great rendering capabilities 
        /// and we can't change legacy's object render method signature or implement interface for it. 
        /// </summary>
        /// <param name="patterns"></param>
        /// <returns></returns>
        public string ListPatterns(IEnumerable<Pattern> patterns)
        {
            return _dataRenderer.ListPatterns(patterns); 
        }
    }
}
