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
namespace playgame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Visible=false;
            label4.Visible=false;   

        }

   

        private void button1_Click(object sender, EventArgs e)
        {
          
            button1.Visible = false;
            
            Refresh();
            Thread.Sleep(500);
            
            label3.Visible=true;
            label4.Visible=true;
            
            Refresh();
            Thread.Sleep(2000);
           
            label4.Text="2";
           
            Refresh();
            Thread.Sleep(2000);
           
            label4.Text ="1";
            Refresh();
           
            Thread.Sleep(2000);
            
            label4.Visible=false;
            label3.Visible=false;
           
            Refresh();
            Thread.Sleep(200);
           
            this.BackColor=Color.Red;

        }

        
    }
}
