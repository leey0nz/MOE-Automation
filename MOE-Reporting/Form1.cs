using CAM;
using System;
using System.Windows.Forms;

namespace MOE_Reporting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            CreateNewCourse course = new CreateNewCourse();
            course.createNewCourse();

            ActionApprove approve = new ActionApprove();
            approve.actionApprove();
        }
    }
}
