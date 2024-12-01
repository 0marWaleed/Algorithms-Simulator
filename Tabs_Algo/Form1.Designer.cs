namespace Tabs_Algo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_selection = new Guna.UI.WinForms.GunaButton();
            this.button_bubble = new Guna.UI.WinForms.GunaButton();
            this.button_binary = new Guna.UI.WinForms.GunaButton();
            this.button_linear = new Guna.UI.WinForms.GunaButton();
            this.panel_container = new System.Windows.Forms.Panel();
            this.label_move = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(57)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1093, 62);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1015, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Algorithms Simulator";
            this.label1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.Tan;
            this.panel2.Controls.Add(this.button_selection);
            this.panel2.Controls.Add(this.button_bubble);
            this.panel2.Controls.Add(this.button_binary);
            this.panel2.Controls.Add(this.button_linear);
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1096, 58);
            this.panel2.TabIndex = 1;
            // 
            // button_selection
            // 
            this.button_selection.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_selection.Animated = true;
            this.button_selection.AnimationHoverSpeed = 0.07F;
            this.button_selection.AnimationSpeed = 0.03F;
            this.button_selection.BaseColor = System.Drawing.Color.Tan;
            this.button_selection.BorderColor = System.Drawing.Color.Black;
            this.button_selection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_selection.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_selection.FocusedColor = System.Drawing.Color.Transparent;
            this.button_selection.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.button_selection.ForeColor = System.Drawing.Color.Black;
            this.button_selection.Image = null;
            this.button_selection.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_selection.ImageSize = new System.Drawing.Size(20, 20);
            this.button_selection.Location = new System.Drawing.Point(814, 0);
            this.button_selection.Name = "button_selection";
            this.button_selection.OnHoverBaseColor = System.Drawing.Color.Wheat;
            this.button_selection.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button_selection.OnHoverForeColor = System.Drawing.Color.Black;
            this.button_selection.OnHoverImage = null;
            this.button_selection.OnPressedColor = System.Drawing.Color.SaddleBrown;
            this.button_selection.Size = new System.Drawing.Size(279, 55);
            this.button_selection.TabIndex = 5;
            this.button_selection.Text = "Selection Sort";
            this.button_selection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_selection.Click += new System.EventHandler(this.button_selection_Click);
            // 
            // button_bubble
            // 
            this.button_bubble.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_bubble.Animated = true;
            this.button_bubble.AnimationHoverSpeed = 0.07F;
            this.button_bubble.AnimationSpeed = 0.03F;
            this.button_bubble.BaseColor = System.Drawing.Color.Tan;
            this.button_bubble.BorderColor = System.Drawing.Color.Black;
            this.button_bubble.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_bubble.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_bubble.FocusedColor = System.Drawing.Color.Transparent;
            this.button_bubble.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.button_bubble.ForeColor = System.Drawing.Color.Black;
            this.button_bubble.Image = null;
            this.button_bubble.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_bubble.ImageSize = new System.Drawing.Size(20, 20);
            this.button_bubble.Location = new System.Drawing.Point(541, 0);
            this.button_bubble.Name = "button_bubble";
            this.button_bubble.OnHoverBaseColor = System.Drawing.Color.Wheat;
            this.button_bubble.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button_bubble.OnHoverForeColor = System.Drawing.Color.Black;
            this.button_bubble.OnHoverImage = null;
            this.button_bubble.OnPressedColor = System.Drawing.Color.SaddleBrown;
            this.button_bubble.Size = new System.Drawing.Size(275, 55);
            this.button_bubble.TabIndex = 4;
            this.button_bubble.Text = "Bubble Sort";
            this.button_bubble.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_bubble.Click += new System.EventHandler(this.button_bubble_Click);
            // 
            // button_binary
            // 
            this.button_binary.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_binary.Animated = true;
            this.button_binary.AnimationHoverSpeed = 0.07F;
            this.button_binary.AnimationSpeed = 0.03F;
            this.button_binary.BaseColor = System.Drawing.Color.Tan;
            this.button_binary.BorderColor = System.Drawing.Color.Black;
            this.button_binary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_binary.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button_binary.FocusedColor = System.Drawing.Color.Transparent;
            this.button_binary.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.button_binary.ForeColor = System.Drawing.Color.Black;
            this.button_binary.Image = null;
            this.button_binary.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_binary.ImageSize = new System.Drawing.Size(20, 20);
            this.button_binary.Location = new System.Drawing.Point(266, 0);
            this.button_binary.Name = "button_binary";
            this.button_binary.OnHoverBaseColor = System.Drawing.Color.Wheat;
            this.button_binary.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button_binary.OnHoverForeColor = System.Drawing.Color.Black;
            this.button_binary.OnHoverImage = null;
            this.button_binary.OnPressedColor = System.Drawing.Color.SaddleBrown;
            this.button_binary.Size = new System.Drawing.Size(277, 55);
            this.button_binary.TabIndex = 2;
            this.button_binary.Text = "Binary Search";
            this.button_binary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_binary.Click += new System.EventHandler(this.button_binary_Click);
            // 
            // button_linear
            // 
            this.button_linear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_linear.Animated = true;
            this.button_linear.AnimationHoverSpeed = 0.07F;
            this.button_linear.AnimationSpeed = 0.03F;
            this.button_linear.BaseColor = System.Drawing.Color.Tan;
            this.button_linear.BorderColor = System.Drawing.Color.Black;
            this.button_linear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_linear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button_linear.FocusedColor = System.Drawing.Color.Transparent;
            this.button_linear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.button_linear.ForeColor = System.Drawing.Color.Black;
            this.button_linear.Image = null;
            this.button_linear.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_linear.ImageSize = new System.Drawing.Size(20, 20);
            this.button_linear.Location = new System.Drawing.Point(0, 0);
            this.button_linear.Name = "button_linear";
            this.button_linear.OnHoverBaseColor = System.Drawing.Color.Wheat;
            this.button_linear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button_linear.OnHoverForeColor = System.Drawing.Color.Black;
            this.button_linear.OnHoverImage = null;
            this.button_linear.OnPressedColor = System.Drawing.Color.SaddleBrown;
            this.button_linear.Size = new System.Drawing.Size(268, 55);
            this.button_linear.TabIndex = 1;
            this.button_linear.Text = "Linear Search";
            this.button_linear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_linear.Click += new System.EventHandler(this.button_linear_Click);
            // 
            // panel_container
            // 
            this.panel_container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_container.AutoSize = true;
            this.panel_container.BackColor = System.Drawing.Color.OldLace;
            this.panel_container.Controls.Add(this.label_move);
            this.panel_container.Location = new System.Drawing.Point(0, 117);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(1093, 502);
            this.panel_container.TabIndex = 2;
            // 
            // label_move
            // 
            this.label_move.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_move.AutoSize = true;
            this.label_move.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_move.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_move.Location = new System.Drawing.Point(344, 219);
            this.label_move.Name = "label_move";
            this.label_move.Size = new System.Drawing.Size(407, 44);
            this.label_move.TabIndex = 0;
            this.label_move.Text = "Choose an Algorithm!";
            this.label_move.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 619);
            this.Controls.Add(this.panel_container);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Algorithm Solver";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel_container.ResumeLayout(false);
            this.panel_container.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_move;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaButton button_linear;
        private Guna.UI.WinForms.GunaButton button_binary;
        private Guna.UI.WinForms.GunaButton button_selection;
        private Guna.UI.WinForms.GunaButton button_bubble;
    }
}

