using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriteriasOfDeciding
{
    public partial class Form1 : Form
    {
        private List<RichTextBox> _matrixParams;
        private double[,] _array;
        private string[] _qs;

        #region Events
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClrMatrix_Click(object sender, EventArgs e)
        {
            DelMatrix();
        }

        private void tbRowsCols_MouseEnter(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(tbRowsCols, "Maximum value is 10");
        }

        private void tbRowsCols_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnCreateMatrix_Click(object sender, EventArgs e)
        {
            AddParams(int.Parse(tbRowsCols.Text));
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            CreateArrayOfParams(int.Parse(tbRowsCols.Text));
            Solutions solutions = new Solutions();

            #region MinMax
            if (minMaxToolStripMenuItem.Checked)
            {
                

                MessageBox.Show(solutions.MinMax(_array, int.Parse(tbRowsCols.Text)).ToString());
            }
            #endregion

            #region BL

            if (bLToolStripMenuItem.Checked)
            {
                _qs = new string[int.Parse(tbRowsCols.Text)];
                _qs = (tbQs.Text).Split(',');
                solutions.BLc(_array, int.Parse(tbRowsCols.Text), _qs);
            }

            #endregion

            #region S
            if (sToolStripMenuItem.Checked)
            {
                solutions.S(_array, int.Parse(tbRowsCols.Text));
            }
            #endregion

            #region HW
            if (hWToolStripMenuItem.Checked)
            {
                
            }
           
            #endregion

            #region G
            if (gToolStripMenuItem.Checked)
            {
                
            }
            #endregion

            #region BL-MM

            if (bLMMToolStripMenuItem.Checked)
            {
                solutions.Bl_Mm(_array, int.Parse(tbRowsCols.Text), _qs);
            }
            #endregion

            #region P
            if (pToolStripMenuItem.Checked)
            {
                
            }
            #endregion
        }
#endregion

        private void AddParams(int count)
        {
            var x = 4;
            var y = 3;
            _matrixParams = new List<RichTextBox>();
            for (var i = 0; i < Math.Pow(count, 2); i++)
            {
                _matrixParams.Add(new RichTextBox()); 

                if (i % count == 0)
                {
                    y = y + 31;
                    x = 4;
                }
                else
                {
                    x = x + 31;
                }
                _matrixParams[i].Location = new Point(x, y);
                _matrixParams[i].Size = new Size(25, 25);
                matrixPanel.Controls.Add(_matrixParams[i]);
            }
        }

        private void DelMatrix()
        {
            _matrixParams.Clear();
            matrixPanel.Controls.Clear();
        }

        private void CreateArrayOfParams(int count)
        {
            _array = new double[count,count];
            var k = 0;
            for (var i = 0; i < count; i++)
            {
                for (var j = 0; j < count; j++)
                {
                    _array[i, j] = double.Parse(_matrixParams[k].Text);
                    k++;
                }
            }
        }

        private void bLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckOtherToolStripMenuItems((ToolStripMenuItem)sender);
            tbQs.Enabled = true;
            tbV.Enabled = false;
            tbXi.Enabled = false;
            tbC.Enabled = false;
        }

        private void bLMMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckOtherToolStripMenuItems((ToolStripMenuItem)sender);
            tbQs.Enabled = true;
            tbV.Enabled = false;
            tbXi.Enabled = true;
            tbC.Enabled = false;
        }  

        private void hLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckOtherToolStripMenuItems((ToolStripMenuItem)sender);
            tbQs.Enabled = true;
            tbXi.Enabled = false;
            tbV.Enabled = false;
            tbC.Enabled = false;
        }

       

        private void minMaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckOtherToolStripMenuItems((ToolStripMenuItem)sender);
            tbQs.Enabled = false;
            tbV.Enabled = false;
            tbXi.Enabled = false;
            tbC.Enabled = false;
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckOtherToolStripMenuItems((ToolStripMenuItem)sender);
            tbQs.Enabled = false;
            tbV.Enabled = false;
            tbXi.Enabled = false;
            tbC.Enabled = false;
        }

        private void hWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckOtherToolStripMenuItems((ToolStripMenuItem)sender);
            tbQs.Enabled = false;
            tbV.Enabled = false;
            tbXi.Enabled = false;
            tbC.Enabled = false;
        }

        private void gToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckOtherToolStripMenuItems((ToolStripMenuItem)sender);
            tbQs.Enabled = false;
            tbV.Enabled = false;
            tbC.Enabled = true;
            tbXi.Enabled = false;
            
        }

        private void pToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckOtherToolStripMenuItems((ToolStripMenuItem)sender);
            tbQs.Enabled = false;
            tbV.Enabled = false;
            tbXi.Enabled = false;
            tbC.Enabled = false;

        }


        // Only one ToolStripMenuItem can by chooosen
        private void UncheckOtherToolStripMenuItems(ToolStripMenuItem selectedMenuItem)
        {
            selectedMenuItem.Checked = true;

            // Select the other MenuItens from the ParentMenu(OwnerItens) and unchecked this,
            // The current Linq Expression verify if the item is a real ToolStripMenuItem
            // and if the item is a another ToolStripMenuItem to uncheck this.
            foreach (var ltoolStripMenuItem in (from object
                                                    item in selectedMenuItem.Owner.Items
                                                let ltoolStripMenuItem = item as ToolStripMenuItem
                                                where ltoolStripMenuItem != null
                                                where !item.Equals(selectedMenuItem)
                                                select ltoolStripMenuItem))
                (ltoolStripMenuItem).Checked = false;

            // This line is optional, for show the mainMenu after click
            selectedMenuItem.Owner.Show();
        }
    }
}
