using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainScreen
{
    public partial class FormMainScreen : Form
    {
        Slider sl;
        public FormMainScreen()
        {
            InitializeComponent();
            sl = new Slider("images", new List<PictureBox> { pictureBox1, pictureBox2, pictureBox3 });
            HistoryNBA.gethowOldNBA(labelInfo);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            sl.sliderRight();

        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            sl.sliderLeft();
        }

        private void buttonadmin_Click(object sender, EventArgs e)
        {

        }

        private void buttonvisitor_Click(object sender, EventArgs e)
        {
            VisitorMenu formVisitor = new VisitorMenu();
            formVisitor.ShowDialog();
        }
    }
}
