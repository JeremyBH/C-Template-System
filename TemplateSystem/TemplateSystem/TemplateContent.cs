using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateSystem
{
    public abstract class TemplateContent : TemplateItem
    {
        //Content
        public string Content { get; set; }

        //Margins
        public int MarginTop { get; set; }
        public int MarginLeft { get; set; }
        public int MarginRight { get; set; }
        public int MarginBottom { get; set; }
    }
}
