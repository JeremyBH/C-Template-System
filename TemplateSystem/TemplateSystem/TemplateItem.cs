using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateSystem
{
    public abstract class TemplateItem
    {
        /// <summary>
        /// The Unique ID of the item. (should be required when making a template item)
        /// </summary>
        public string Uid { get; set; }
    }
}
