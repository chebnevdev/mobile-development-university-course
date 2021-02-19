using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Tabbed.MasterDetail
{
    public class NamedColor
    {
        public NamedColor(string name, Color color)
        {
            Name = name;
            Color = color;
        }

        public string Name { get; set; }
        public Color Color { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
