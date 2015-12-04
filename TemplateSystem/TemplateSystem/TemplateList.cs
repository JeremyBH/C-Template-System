using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Serialization;

namespace TemplateSystem {
    /// <summary>
    ///     The purpose of this class is to contain a list of data that will hold all of the information for every object
    ///     within the template.
    ///     TODO: Add class content.
    /// </summary>
    [XmlInclude(typeof(TemplateItem))]
    [XmlInclude(typeof(TemplateHandler))]
    [XmlInclude(typeof(TemplateHandlerColumn))]
    [XmlInclude(typeof(TemplateHandlerMultiCol))]
    [XmlInclude(typeof(TemplateHandlerWell))]
    [XmlInclude(typeof(TemplateContent))]
    [XmlInclude(typeof(TemplateContentText))]
    [XmlInclude(typeof(TemplateContentImage))]
    public class TemplateList {
        public List<TemplateItem> TemplateItems { get; set; }

        public void TemplateItem()
        {
            TemplateItems = new List<TemplateItem>();
        }
    }
}