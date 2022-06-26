using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace boat_rental
{
    public partial class StartForm : Form
    {
        public int ProgressValue
        {
            get
            {
                return this.progressBar1.Value;
            }
            set
            {
                this.progressBar1.Value = value;
            }
        }
        
        public StartForm()
        {
            InitializeComponent();

            

            // MainForm mainForm = new MainForm();
            // this.Hide();
            //Thread.Sleep(3000);
            // mainForm.ShowDialog();
            //this.Close();
        }

        public void progress()
        {
            for (int i = 0; i < 100; i++)
            {
                this.ProgressValue = i;
            }
        }

        public void close()
        {
            this.Close();
        }
    }
}
