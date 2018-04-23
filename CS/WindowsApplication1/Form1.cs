using DevExpress.Utils;
using DevExpress.XtraNavBar;
using DevExpress.XtraNavBar.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            navBarControl1.Click += navBarControl1_Click;
            navBarControl1.ActiveGroupChanged += navBarControl1_ActiveGroupChanged;
        }

        private void ShowActiveGroupPopup()
        {
            if (navBarControl1.OptionsNavPane.NavPaneState == NavPaneState.Collapsed)
            {
                NavBarViewInfo viewInfo = navBarControl1.GetViewInfo();
                var mi = viewInfo.GetType().GetMethod("DoContentButtonPress", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                mi.Invoke(viewInfo, null);
            }
        }
        void navBarControl1_ActiveGroupChanged(object sender, NavBarGroupEventArgs e)
        {
            if (navBarControl1.OptionsNavPane.NavPaneState == NavPaneState.Collapsed)
            {
                ShowActiveGroupPopup();
            }
        }

        void navBarControl1_Click(object sender, EventArgs e)
        {
            var args = (MouseEventArgs)e;
            var hi = navBarControl1.CalcHitInfo(args.Location);
            if (hi.InGroupCaption && hi.Group == navBarControl1.ActiveGroup)
                ShowActiveGroupPopup();
        }

        
    }


}