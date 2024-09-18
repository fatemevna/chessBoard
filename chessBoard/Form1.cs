using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chessBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   int xPosition = 0;
            int yPosition = 0;
            int j = 0;
            for (int i = 0; i < 64; i++)
            {
                if (i % 8 == 0) { xPosition = 0;
                    yPosition += 76;
                    j++;
                }
                if ( (i % 2 == 0) & ( (j % 2 == 0)))
                {
                    var Button = new Button
                    {   /*ForeColor = Color.Yellow,
                        Text = ($"button{i}"),*/ 
                        BackColor = Color.Black,
                        Location = new Point(xPosition, yPosition),
                        Name = ("button{i}"),
                        Size = new Size(75, 75)
                    };
                    xPosition += 76;
                    Controls.Add(Button);
                }
                else if (!(i%2==0)&!(j%2==0)) 
                {
                    var Button = new Button
                    {
                        /*ForeColor = Color.Yellow,
                        Text = ($"button{i}"),*/
                        
                        BackColor = Color.Black,
                        Location = new Point(xPosition, yPosition),
                        Name = ("button{i}"),
                        Size = new Size(75, 75)
                    };
                    xPosition += 76;
                    Controls.Add(Button);

                }
                else {
                    var Button = new Button
                    {
                        /*ForeColor = Color.Yellow,
                        Text = ($"button{i}"),*/
                        BackColor = Color.White,
                        Location = new Point(xPosition, yPosition),
                        Name = ("button{i}"),
                        Size = new Size(75, 75)
                    };
                    xPosition += 76;
                    Controls.Add(Button);
                }
        
    }
        }
    }
}
