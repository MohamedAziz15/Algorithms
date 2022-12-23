namespace InsertionSort
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
            this.InsertionSortBTN = new MetroFramework.Controls.MetroButton();
            this.beforeSortedLBL = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.afterSortedLBL = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // InsertionSortBTN
            // 
            this.InsertionSortBTN.Location = new System.Drawing.Point(392, 149);
            this.InsertionSortBTN.Name = "InsertionSortBTN";
            this.InsertionSortBTN.Size = new System.Drawing.Size(93, 32);
            this.InsertionSortBTN.TabIndex = 0;
            this.InsertionSortBTN.Text = "insertion";
            this.InsertionSortBTN.UseSelectable = true;
            this.InsertionSortBTN.Click += new System.EventHandler(this.SortBTN_Click);
            // 
            // beforeSortedLBL
            // 
            this.beforeSortedLBL.AutoSize = true;
            this.beforeSortedLBL.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.beforeSortedLBL.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.beforeSortedLBL.Location = new System.Drawing.Point(103, 233);
            this.beforeSortedLBL.Name = "beforeSortedLBL";
            this.beforeSortedLBL.Size = new System.Drawing.Size(56, 25);
            this.beforeSortedLBL.TabIndex = 2;
            this.beforeSortedLBL.Text = "array";
            this.beforeSortedLBL.UseStyleColors = true;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(248, 2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(94, 149);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Multiline = true;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(278, 32);
            this.metroTextBox1.TabIndex = 3;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox1_KeyPress);
            // 
            // afterSortedLBL
            // 
            this.afterSortedLBL.AutoSize = true;
            this.afterSortedLBL.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.afterSortedLBL.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.afterSortedLBL.ForeColor = System.Drawing.Color.Crimson;
            this.afterSortedLBL.Location = new System.Drawing.Point(103, 306);
            this.afterSortedLBL.Name = "afterSortedLBL";
            this.afterSortedLBL.Size = new System.Drawing.Size(56, 25);
            this.afterSortedLBL.TabIndex = 4;
            this.afterSortedLBL.Text = "array";
            this.afterSortedLBL.UseCustomForeColor = true;
            this.afterSortedLBL.UseStyleColors = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.afterSortedLBL);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.beforeSortedLBL);
            this.Controls.Add(this.InsertionSortBTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton InsertionSortBTN;
        private MetroFramework.Controls.MetroLabel beforeSortedLBL;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel afterSortedLBL;
    }
}

