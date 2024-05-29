using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro
{
    public partial class Form5 : Form
    {
        int type;
        public Form5()
        {
            InitializeComponent();
            this.SetLanguage();
        }

        private void f5btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void f5btnChoiLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (type == 0)
            {
                Form3 f3 = new Form3();
                f3.ShowDialog();
            }
            else
            {
                Form4 f4 = new Form4();
                f4.ShowDialog();
            }
            this.Close();
        }
        public void SetMessen(string mes, int type)
        {
            this.f5lbMess.Text = mes;
            this.type = type;
        }
        void SetLanguage()
        {
            this.f5btnChoiLai.Text = GameManager.Instance.txtTitle[(int)TITLE_FORM.f5BtnPlayAgain, GameManager.Instance.language];
            this.f5btnThoat.Text = GameManager.Instance.txtTitle[(int)TITLE_FORM.f5BtnExit, GameManager.Instance.language];
        }
    }
}
