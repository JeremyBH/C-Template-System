using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateSystem
{
    public abstract class TemplateHandler : TemplateItem
    {
        public List<TemplateItem> ItemHold { get; set; }
        public string StartDiv { get; set; }
        public string EndDiv { get; set; }
    }
}
