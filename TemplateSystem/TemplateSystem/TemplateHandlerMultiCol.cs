using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateSystem
{
    public class TemplateHandlerMultiCol
    {
        public TemplateHandlerColumn[] ColumnArray { get; set; }

        /// <summary>
        /// Column array can only be 2-4. 
        /// </summary>
        /// <param name="colAmount"></param>
        /// <returns></returns>
        public bool AllocateCollumns(int colAmount)
        {
            if (colAmount < 2 || colAmount > 4)
                return false;
            ColumnArray = new TemplateHandlerColumn[colAmount];
            foreach (var item in ColumnArray)
            {
                item.ColSize = 12/colAmount;
            }
            return true;
        }
    }
}
