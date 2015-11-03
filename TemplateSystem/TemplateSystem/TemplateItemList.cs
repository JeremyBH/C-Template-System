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
    public class TemplateItemList {
        public List<TemplateItem> TemplateItems;

        public TemplateItemList() {
            TemplateItems = new List<TemplateItem>();
        }

        #region Add(itemType item)
        public void Add(Window item, string uid) {
            TemplateItems.Add(new TemplateItem {
                ItemType = TemplateItemTypeFlag.Window.ToString(),
                Uid = uid,
                Width = item.Width,
                Height = item.Height
            });
        }

        public void Add(TextBlock item, string uid, int gridX, int gridY) {
            TemplateItems.Add(new TemplateItem {
                ItemType = TemplateItemTypeFlag.TextBlock.ToString(),
                Uid = uid,
                Width = item.Width,
                Height = item.Height,
                MarginBottom = item.Margin.Bottom,
                MarginTop = item.Margin.Top,
                MarginLeft = item.Margin.Left,
                MarginRight = item.Margin.Right,
                GridX = gridX,
                GridY = gridY,
                Content = item.Text,
                FontSize = item.FontSize,
                FontStyle = item.FontStyle
            });
        }

        public void Add(Image item, string uid, int gridX, int gridY) {
            
            TemplateItems.Add(new TemplateItem {
                ItemType = TemplateItemTypeFlag.Image.ToString(),
                Uid = uid,
                Width = item.Width,
                Height = item.Height,
                MarginBottom = item.Margin.Bottom,
                MarginTop = item.Margin.Top,
                MarginLeft = item.Margin.Left,
                MarginRight = item.Margin.Right,
                GridX = gridX,
                GridY = gridY,
                Content = item.Source.ToString()
            });
        }
        #endregion
    }

    /// <summary>
    ///     The subclass that will be listed.
    /// </summary>
    public class TemplateItem {
        //---Item holders---
        //Item Descriptors
        public string ItemType { get; set; }
        public string Uid { get; set; }

        //Margins
        public double MarginTop { get; set; }
        public double MarginLeft { get; set; }
        public double MarginRight { get; set; }
        public double MarginBottom { get; set; }

        //Physical properties
        public double Width { get; set; }
        public double Height { get; set; }

        //Grid
        public int GridX { get; set; }
        public int GridY { get; set; }

        //Font information
        public double FontSize { get; set; }
        public FontStyle FontStyle { get; set; }

        //Content
        public string Content { get; set; }
    }
}