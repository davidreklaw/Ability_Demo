using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.ComponentModel.Design;

namespace UserControl1
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
    }
}
