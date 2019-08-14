namespace hanoi.GUI
{
    partial class HanoiUI
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
            this.peg0Base = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.peg0 = new System.Windows.Forms.FlowLayoutPanel();
            this.disc2 = new System.Windows.Forms.Panel();
            this.disc1 = new System.Windows.Forms.Panel();
            this.disc0 = new System.Windows.Forms.Panel();
            this.peg1 = new System.Windows.Forms.FlowLayoutPanel();
            this.peg1Base = new System.Windows.Forms.Panel();
            this.peg2Base = new System.Windows.Forms.Panel();
            this.peg2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPlay2 = new System.Windows.Forms.Button();
            this.peg02base = new System.Windows.Forms.Panel();
            this.peg02 = new System.Windows.Forms.FlowLayoutPanel();
            this.disc32 = new System.Windows.Forms.Panel();
            this.disc22 = new System.Windows.Forms.Panel();
            this.disc12 = new System.Windows.Forms.Panel();
            this.disc02 = new System.Windows.Forms.Panel();
            this.peg22base = new System.Windows.Forms.Panel();
            this.peg12 = new System.Windows.Forms.FlowLayoutPanel();
            this.peg32base = new System.Windows.Forms.Panel();
            this.peg22 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblBFS = new System.Windows.Forms.Label();
            this.lblDLS = new System.Windows.Forms.Label();
            this.peg0.SuspendLayout();
            this.peg02.SuspendLayout();
            this.SuspendLayout();
            // 
            // peg0Base
            // 
            this.peg0Base.BackColor = System.Drawing.Color.Black;
            this.peg0Base.Location = new System.Drawing.Point(91, 247);
            this.peg0Base.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.peg0Base.Name = "peg0Base";
            this.peg0Base.Size = new System.Drawing.Size(120, 5);
            this.peg0Base.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(84, 51);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(3, 21, 3, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(270, 38);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Towers of Hanoi";
            // 
            // peg0
            // 
            this.peg0.Controls.Add(this.disc2);
            this.peg0.Controls.Add(this.disc1);
            this.peg0.Controls.Add(this.disc0);
            this.peg0.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.peg0.Location = new System.Drawing.Point(91, 129);
            this.peg0.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.peg0.Name = "peg0";
            this.peg0.Size = new System.Drawing.Size(120, 115);
            this.peg0.TabIndex = 2;
            // 
            // disc2
            // 
            this.disc2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.disc2.Location = new System.Drawing.Point(10, 85);
            this.disc2.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.disc2.Name = "disc2";
            this.disc2.Size = new System.Drawing.Size(100, 25);
            this.disc2.TabIndex = 3;
            // 
            // disc1
            // 
            this.disc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(231)))));
            this.disc1.Location = new System.Drawing.Point(22, 50);
            this.disc1.Margin = new System.Windows.Forms.Padding(22, 5, 22, 5);
            this.disc1.Name = "disc1";
            this.disc1.Size = new System.Drawing.Size(76, 25);
            this.disc1.TabIndex = 4;
            // 
            // disc0
            // 
            this.disc0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(0)))), ((int)(((byte)(104)))));
            this.disc0.Location = new System.Drawing.Point(35, 15);
            this.disc0.Margin = new System.Windows.Forms.Padding(35, 0, 35, 5);
            this.disc0.Name = "disc0";
            this.disc0.Size = new System.Drawing.Size(50, 25);
            this.disc0.TabIndex = 4;
            // 
            // peg1
            // 
            this.peg1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.peg1.Location = new System.Drawing.Point(231, 129);
            this.peg1.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.peg1.Name = "peg1";
            this.peg1.Size = new System.Drawing.Size(120, 115);
            this.peg1.TabIndex = 3;
            // 
            // peg1Base
            // 
            this.peg1Base.BackColor = System.Drawing.Color.Black;
            this.peg1Base.Location = new System.Drawing.Point(231, 247);
            this.peg1Base.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.peg1Base.Name = "peg1Base";
            this.peg1Base.Size = new System.Drawing.Size(120, 5);
            this.peg1Base.TabIndex = 1;
            // 
            // peg2Base
            // 
            this.peg2Base.BackColor = System.Drawing.Color.Black;
            this.peg2Base.Location = new System.Drawing.Point(371, 247);
            this.peg2Base.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.peg2Base.Name = "peg2Base";
            this.peg2Base.Size = new System.Drawing.Size(120, 5);
            this.peg2Base.TabIndex = 4;
            // 
            // peg2
            // 
            this.peg2.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.peg2.Location = new System.Drawing.Point(371, 129);
            this.peg2.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.peg2.Name = "peg2";
            this.peg2.Size = new System.Drawing.Size(120, 115);
            this.peg2.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(597, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Esc";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Lucida Handwriting", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(12, 129);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(76, 128);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.Text = "P\r\nl\r\na\r\ny";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPlay2
            // 
            this.btnPlay2.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay2.Font = new System.Drawing.Font("Lucida Handwriting", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnPlay2.Location = new System.Drawing.Point(12, 326);
            this.btnPlay2.Name = "btnPlay2";
            this.btnPlay2.Size = new System.Drawing.Size(76, 148);
            this.btnPlay2.TabIndex = 15;
            this.btnPlay2.Text = "P\r\nl\r\na\r\ny";
            this.btnPlay2.UseVisualStyleBackColor = false;
            this.btnPlay2.Click += new System.EventHandler(this.btnPlay2_Click);
            // 
            // peg02base
            // 
            this.peg02base.BackColor = System.Drawing.Color.Black;
            this.peg02base.Location = new System.Drawing.Point(91, 469);
            this.peg02base.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.peg02base.Name = "peg02base";
            this.peg02base.Size = new System.Drawing.Size(120, 5);
            this.peg02base.TabIndex = 9;
            // 
            // peg02
            // 
            this.peg02.Controls.Add(this.disc32);
            this.peg02.Controls.Add(this.disc22);
            this.peg02.Controls.Add(this.disc12);
            this.peg02.Controls.Add(this.disc02);
            this.peg02.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.peg02.Location = new System.Drawing.Point(91, 326);
            this.peg02.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.peg02.Name = "peg02";
            this.peg02.Size = new System.Drawing.Size(120, 140);
            this.peg02.TabIndex = 11;
            // 
            // disc32
            // 
            this.disc32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(147)))), ((int)(((byte)(111)))));
            this.disc32.Location = new System.Drawing.Point(10, 110);
            this.disc32.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.disc32.Name = "disc32";
            this.disc32.Size = new System.Drawing.Size(100, 25);
            this.disc32.TabIndex = 3;
            // 
            // disc22
            // 
            this.disc22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(116)))), ((int)(((byte)(165)))));
            this.disc22.Location = new System.Drawing.Point(22, 75);
            this.disc22.Margin = new System.Windows.Forms.Padding(22, 5, 22, 5);
            this.disc22.Name = "disc22";
            this.disc22.Size = new System.Drawing.Size(76, 25);
            this.disc22.TabIndex = 4;
            // 
            // disc12
            // 
            this.disc12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(63)))), ((int)(((byte)(111)))));
            this.disc12.Location = new System.Drawing.Point(35, 40);
            this.disc12.Margin = new System.Windows.Forms.Padding(35, 5, 35, 5);
            this.disc12.Name = "disc12";
            this.disc12.Size = new System.Drawing.Size(50, 25);
            this.disc12.TabIndex = 4;
            // 
            // disc02
            // 
            this.disc02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.disc02.Location = new System.Drawing.Point(47, 5);
            this.disc02.Margin = new System.Windows.Forms.Padding(47, 5, 47, 5);
            this.disc02.Name = "disc02";
            this.disc02.Size = new System.Drawing.Size(26, 25);
            this.disc02.TabIndex = 16;
            // 
            // peg22base
            // 
            this.peg22base.BackColor = System.Drawing.Color.Black;
            this.peg22base.Location = new System.Drawing.Point(231, 469);
            this.peg22base.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.peg22base.Name = "peg22base";
            this.peg22base.Size = new System.Drawing.Size(120, 5);
            this.peg22base.TabIndex = 16;
            // 
            // peg12
            // 
            this.peg12.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.peg12.Location = new System.Drawing.Point(231, 326);
            this.peg12.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.peg12.Name = "peg12";
            this.peg12.Size = new System.Drawing.Size(120, 140);
            this.peg12.TabIndex = 17;
            // 
            // peg32base
            // 
            this.peg32base.BackColor = System.Drawing.Color.Black;
            this.peg32base.Location = new System.Drawing.Point(371, 469);
            this.peg32base.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.peg32base.Name = "peg32base";
            this.peg32base.Size = new System.Drawing.Size(120, 5);
            this.peg32base.TabIndex = 18;
            // 
            // peg22
            // 
            this.peg22.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.peg22.Location = new System.Drawing.Point(371, 326);
            this.peg22.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.peg22.Name = "peg22";
            this.peg22.Size = new System.Drawing.Size(120, 140);
            this.peg22.TabIndex = 19;
            // 
            // lblBFS
            // 
            this.lblBFS.AutoSize = true;
            this.lblBFS.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblBFS.ForeColor = System.Drawing.Color.Black;
            this.lblBFS.Location = new System.Drawing.Point(20, 94);
            this.lblBFS.Name = "lblBFS";
            this.lblBFS.Size = new System.Drawing.Size(68, 32);
            this.lblBFS.TabIndex = 20;
            this.lblBFS.Text = "BFS";
            // 
            // lblDLS
            // 
            this.lblDLS.AutoSize = true;
            this.lblDLS.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDLS.ForeColor = System.Drawing.Color.Black;
            this.lblDLS.Location = new System.Drawing.Point(20, 291);
            this.lblDLS.Name = "lblDLS";
            this.lblDLS.Size = new System.Drawing.Size(68, 32);
            this.lblDLS.TabIndex = 21;
            this.lblDLS.Text = "DLS";
            // 
            // HanoiUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(702, 498);
            this.Controls.Add(this.lblDLS);
            this.Controls.Add(this.lblBFS);
            this.Controls.Add(this.btnPlay2);
            this.Controls.Add(this.peg32base);
            this.Controls.Add(this.peg22);
            this.Controls.Add(this.peg22base);
            this.Controls.Add(this.peg12);
            this.Controls.Add(this.peg02base);
            this.Controls.Add(this.peg02);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.peg2Base);
            this.Controls.Add(this.peg2);
            this.Controls.Add(this.peg1Base);
            this.Controls.Add(this.peg1);
            this.Controls.Add(this.peg0Base);
            this.Controls.Add(this.peg0);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HanoiUI";
            this.Text = "T. of Hanoi";
            this.peg0.ResumeLayout(false);
            this.peg02.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel peg0Base;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel peg0;
        private System.Windows.Forms.Panel disc2;
        private System.Windows.Forms.Panel disc1;
        private System.Windows.Forms.Panel disc0;
        private System.Windows.Forms.FlowLayoutPanel peg1;
        private System.Windows.Forms.Panel peg1Base;
        private System.Windows.Forms.Panel peg2Base;
        private System.Windows.Forms.FlowLayoutPanel peg2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPlay2;
        private System.Windows.Forms.Panel peg02base;
        private System.Windows.Forms.FlowLayoutPanel peg02;
        private System.Windows.Forms.Panel disc32;
        private System.Windows.Forms.Panel disc22;
        private System.Windows.Forms.Panel disc12;
        private System.Windows.Forms.Panel disc02;
        private System.Windows.Forms.Panel peg22base;
        private System.Windows.Forms.FlowLayoutPanel peg12;
        private System.Windows.Forms.Panel peg32base;
        private System.Windows.Forms.FlowLayoutPanel peg22;
        private System.Windows.Forms.Label lblBFS;
        private System.Windows.Forms.Label lblDLS;
    }
}

