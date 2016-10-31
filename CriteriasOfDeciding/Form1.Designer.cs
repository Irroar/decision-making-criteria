namespace CriteriasOfDeciding
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRowsCols = new System.Windows.Forms.Label();
            this.tbRowsCols = new System.Windows.Forms.TextBox();
            this.btnCreateMatrix = new System.Windows.Forms.Button();
            this.btnClrMatrix = new System.Windows.Forms.Button();
            this.matrixPanel = new System.Windows.Forms.Panel();
            this.lblPutCountOfElements = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.criteriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minMaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bLMMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramsPanel = new System.Windows.Forms.Panel();
            this.lblq = new System.Windows.Forms.Label();
            this.lblv = new System.Windows.Forms.Label();
            this.lblxi = new System.Windows.Forms.Label();
            this.tbQs = new System.Windows.Forms.TextBox();
            this.tbV = new System.Windows.Forms.TextBox();
            this.tbXi = new System.Windows.Forms.TextBox();
            this.tbC = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.paramsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRowsCols
            // 
            this.lblRowsCols.AutoSize = true;
            this.lblRowsCols.Location = new System.Drawing.Point(12, 66);
            this.lblRowsCols.Name = "lblRowsCols";
            this.lblRowsCols.Size = new System.Drawing.Size(78, 13);
            this.lblRowsCols.TabIndex = 0;
            this.lblRowsCols.Text = "Rows and Cols";
            // 
            // tbRowsCols
            // 
            this.tbRowsCols.Location = new System.Drawing.Point(96, 63);
            this.tbRowsCols.Name = "tbRowsCols";
            this.tbRowsCols.Size = new System.Drawing.Size(62, 20);
            this.tbRowsCols.TabIndex = 3;
            this.tbRowsCols.MouseEnter += new System.EventHandler(this.tbRowsCols_MouseEnter);
            this.tbRowsCols.MouseLeave += new System.EventHandler(this.tbRowsCols_MouseLeave);
            // 
            // btnCreateMatrix
            // 
            this.btnCreateMatrix.Location = new System.Drawing.Point(15, 89);
            this.btnCreateMatrix.Name = "btnCreateMatrix";
            this.btnCreateMatrix.Size = new System.Drawing.Size(143, 23);
            this.btnCreateMatrix.TabIndex = 6;
            this.btnCreateMatrix.Text = "Create Matrix";
            this.btnCreateMatrix.UseVisualStyleBackColor = true;
            this.btnCreateMatrix.Click += new System.EventHandler(this.btnCreateMatrix_Click);
            // 
            // btnClrMatrix
            // 
            this.btnClrMatrix.Location = new System.Drawing.Point(15, 147);
            this.btnClrMatrix.Name = "btnClrMatrix";
            this.btnClrMatrix.Size = new System.Drawing.Size(143, 23);
            this.btnClrMatrix.TabIndex = 7;
            this.btnClrMatrix.Text = "Clear Matrix";
            this.btnClrMatrix.UseVisualStyleBackColor = true;
            this.btnClrMatrix.Click += new System.EventHandler(this.btnClrMatrix_Click);
            // 
            // matrixPanel
            // 
            this.matrixPanel.Location = new System.Drawing.Point(164, 30);
            this.matrixPanel.Name = "matrixPanel";
            this.matrixPanel.Size = new System.Drawing.Size(340, 340);
            this.matrixPanel.TabIndex = 8;
            // 
            // lblPutCountOfElements
            // 
            this.lblPutCountOfElements.AutoSize = true;
            this.lblPutCountOfElements.Location = new System.Drawing.Point(13, 34);
            this.lblPutCountOfElements.Name = "lblPutCountOfElements";
            this.lblPutCountOfElements.Size = new System.Drawing.Size(166, 13);
            this.lblPutCountOfElements.TabIndex = 9;
            this.lblPutCountOfElements.Text = "Count of Rows and Cols in Matrix:";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(15, 118);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(142, 23);
            this.btnDone.TabIndex = 11;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criteriasToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(515, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // criteriasToolStripMenuItem
            // 
            this.criteriasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minMaxToolStripMenuItem,
            this.bLToolStripMenuItem,
            this.sToolStripMenuItem,
            this.hWToolStripMenuItem,
            this.hLToolStripMenuItem,
            this.gToolStripMenuItem,
            this.bLMMToolStripMenuItem,
            this.pToolStripMenuItem});
            this.criteriasToolStripMenuItem.Name = "criteriasToolStripMenuItem";
            this.criteriasToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.criteriasToolStripMenuItem.Text = "Criterias";
            // 
            // minMaxToolStripMenuItem
            // 
            this.minMaxToolStripMenuItem.CheckOnClick = true;
            this.minMaxToolStripMenuItem.Name = "minMaxToolStripMenuItem";
            this.minMaxToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.minMaxToolStripMenuItem.Text = "MinMax";
            this.minMaxToolStripMenuItem.Click += new System.EventHandler(this.minMaxToolStripMenuItem_Click);
            // 
            // bLToolStripMenuItem
            // 
            this.bLToolStripMenuItem.CheckOnClick = true;
            this.bLToolStripMenuItem.Name = "bLToolStripMenuItem";
            this.bLToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bLToolStripMenuItem.Text = "BL";
            this.bLToolStripMenuItem.Click += new System.EventHandler(this.bLToolStripMenuItem_Click);
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.CheckOnClick = true;
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sToolStripMenuItem.Text = "S";
            this.sToolStripMenuItem.Click += new System.EventHandler(this.sToolStripMenuItem_Click);
            // 
            // hWToolStripMenuItem
            // 
            this.hWToolStripMenuItem.CheckOnClick = true;
            this.hWToolStripMenuItem.Name = "hWToolStripMenuItem";
            this.hWToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hWToolStripMenuItem.Text = "HW";
            this.hWToolStripMenuItem.Click += new System.EventHandler(this.hWToolStripMenuItem_Click);
            // 
            // hLToolStripMenuItem
            // 
            this.hLToolStripMenuItem.CheckOnClick = true;
            this.hLToolStripMenuItem.Name = "hLToolStripMenuItem";
            this.hLToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hLToolStripMenuItem.Text = "HL";
            this.hLToolStripMenuItem.Click += new System.EventHandler(this.hLToolStripMenuItem_Click);
            // 
            // gToolStripMenuItem
            // 
            this.gToolStripMenuItem.CheckOnClick = true;
            this.gToolStripMenuItem.Name = "gToolStripMenuItem";
            this.gToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gToolStripMenuItem.Text = "G";
            this.gToolStripMenuItem.Click += new System.EventHandler(this.gToolStripMenuItem_Click);
            // 
            // bLMMToolStripMenuItem
            // 
            this.bLMMToolStripMenuItem.CheckOnClick = true;
            this.bLMMToolStripMenuItem.Name = "bLMMToolStripMenuItem";
            this.bLMMToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bLMMToolStripMenuItem.Text = "BL-MM";
            this.bLMMToolStripMenuItem.Click += new System.EventHandler(this.bLMMToolStripMenuItem_Click);
            // 
            // pToolStripMenuItem
            // 
            this.pToolStripMenuItem.CheckOnClick = true;
            this.pToolStripMenuItem.Name = "pToolStripMenuItem";
            this.pToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pToolStripMenuItem.Text = "P";
            this.pToolStripMenuItem.Click += new System.EventHandler(this.pToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            // 
            // paramsPanel
            // 
            this.paramsPanel.Controls.Add(this.lblC);
            this.paramsPanel.Controls.Add(this.tbC);
            this.paramsPanel.Controls.Add(this.tbXi);
            this.paramsPanel.Controls.Add(this.tbV);
            this.paramsPanel.Controls.Add(this.tbQs);
            this.paramsPanel.Controls.Add(this.lblxi);
            this.paramsPanel.Controls.Add(this.lblv);
            this.paramsPanel.Controls.Add(this.lblq);
            this.paramsPanel.Location = new System.Drawing.Point(16, 177);
            this.paramsPanel.Name = "paramsPanel";
            this.paramsPanel.Size = new System.Drawing.Size(141, 193);
            this.paramsPanel.TabIndex = 13;
            // 
            // lblq
            // 
            this.lblq.AutoSize = true;
            this.lblq.Location = new System.Drawing.Point(4, 8);
            this.lblq.Name = "lblq";
            this.lblq.Size = new System.Drawing.Size(18, 13);
            this.lblq.TabIndex = 0;
            this.lblq.Text = "qs";
            // 
            // lblv
            // 
            this.lblv.AutoSize = true;
            this.lblv.Location = new System.Drawing.Point(4, 34);
            this.lblv.Name = "lblv";
            this.lblv.Size = new System.Drawing.Size(13, 13);
            this.lblv.TabIndex = 1;
            this.lblv.Text = "v";
            // 
            // lblxi
            // 
            this.lblxi.AutoSize = true;
            this.lblxi.Location = new System.Drawing.Point(4, 61);
            this.lblxi.Name = "lblxi";
            this.lblxi.Size = new System.Drawing.Size(12, 13);
            this.lblxi.TabIndex = 2;
            this.lblxi.Text = "ξ";
            // 
            // tbQs
            // 
            this.tbQs.Enabled = false;
            this.tbQs.Location = new System.Drawing.Point(44, 5);
            this.tbQs.Name = "tbQs";
            this.tbQs.Size = new System.Drawing.Size(91, 20);
            this.tbQs.TabIndex = 3;
            // 
            // tbV
            // 
            this.tbV.Enabled = false;
            this.tbV.Location = new System.Drawing.Point(44, 31);
            this.tbV.Name = "tbV";
            this.tbV.Size = new System.Drawing.Size(91, 20);
            this.tbV.TabIndex = 4;
            // 
            // tbXi
            // 
            this.tbXi.Enabled = false;
            this.tbXi.Location = new System.Drawing.Point(44, 54);
            this.tbXi.Name = "tbXi";
            this.tbXi.Size = new System.Drawing.Size(91, 20);
            this.tbXi.TabIndex = 5;
            // 
            // tbC
            // 
            this.tbC.Enabled = false;
            this.tbC.Location = new System.Drawing.Point(44, 81);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(91, 20);
            this.tbC.TabIndex = 6;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(4, 84);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(13, 13);
            this.lblC.TabIndex = 7;
            this.lblC.Text = "c";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 380);
            this.Controls.Add(this.paramsPanel);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblPutCountOfElements);
            this.Controls.Add(this.matrixPanel);
            this.Controls.Add(this.btnClrMatrix);
            this.Controls.Add(this.btnCreateMatrix);
            this.Controls.Add(this.tbRowsCols);
            this.Controls.Add(this.lblRowsCols);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.paramsPanel.ResumeLayout(false);
            this.paramsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRowsCols;
        private System.Windows.Forms.TextBox tbRowsCols;
        private System.Windows.Forms.Button btnCreateMatrix;
        private System.Windows.Forms.Button btnClrMatrix;
        private System.Windows.Forms.Panel matrixPanel;
        private System.Windows.Forms.Label lblPutCountOfElements;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem criteriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minMaxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bLMMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.Panel paramsPanel;
        private System.Windows.Forms.TextBox tbXi;
        private System.Windows.Forms.TextBox tbV;
        private System.Windows.Forms.TextBox tbQs;
        private System.Windows.Forms.Label lblxi;
        private System.Windows.Forms.Label lblv;
        private System.Windows.Forms.Label lblq;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox tbC;
    }
}

