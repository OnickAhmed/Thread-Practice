using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer
{
    public partial class Form1 : Form
    {

        int h = 3;


        Button[] buttonArray = new Button[8];
        public Form1()
        {
            InitializeComponent();

            Thread thread = new Thread(labelThread);
            thread.Start();
        }

        private void labelThread()
        {
            int count = 0;
            while (true)
            {
                label1.Invoke(new Action(() => label1.Text = count.ToString()));
                Thread.Sleep(500);
                count++;

                if (count>5)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        buttonArray[i] = new Button();
                        buttonArray[i].Size = new Size(75, 23);
                        buttonArray[i].Name = "" + 0 + "";
                        buttonArray[i].Text = "Button" + (i+1);
                        //buttonArray[0].Click += button_Click;//function
                        buttonArray[i].Location = new Point(20 + (i * 80), 40);
                        this.Invoke((MethodInvoker)delegate { this.Controls.Add(buttonArray[i]); });
                    }
                    
                    break;
                }
            }
            
            
        }
    }
}
