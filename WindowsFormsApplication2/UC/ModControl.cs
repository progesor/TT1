using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2.UC
{
    public partial class ModControl : UserControl
    {
        [Bindable(true)]
        [DefaultValue(null)]
        public string ModName { get { return Modname.Text; } set { Modname.Text = value; } }

        [Bindable(true)]
        [DefaultValue(null)]
        public string ModDescription { get { return Moddescription.Text; } set { Moddescription.Text = value; } }

        [Bindable(true)]
        [DefaultValue(null)]
        public string ModLink { get { return Modlink.Text; } set { Modlink.Text = value; } }
        
        public ModControl()
        {
            InitializeComponent();
            
        }

        public ModControl(mod Mod)
        {
            InitializeComponent();
            ModName = Mod.Name;
            ModDescription = Mod.Desc;
            ModLink = Mod.Link;

        }

        private void ModLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Modlink.Text);
        }

    }
}
