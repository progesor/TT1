namespace WindowsFormsApplication2.UC
{
    partial class ModControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Modname = new System.Windows.Forms.Label();
            this.Moddescription = new System.Windows.Forms.RichTextBox();
            this.Modlink = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Modname
            // 
            this.Modname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Modname.AutoSize = true;
            this.Modname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Modname.Location = new System.Drawing.Point(4, 0);
            this.Modname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Modname.Name = "Modname";
            this.Modname.Size = new System.Drawing.Size(132, 29);
            this.Modname.TabIndex = 0;
            this.Modname.Text = "Mod Name";
            // 
            // Moddescription
            // 
            this.Moddescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Moddescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Moddescription.Location = new System.Drawing.Point(12, 49);
            this.Moddescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Moddescription.Name = "Moddescription";
            this.Moddescription.ReadOnly = true;
            this.Moddescription.Size = new System.Drawing.Size(424, 89);
            this.Moddescription.TabIndex = 1;
            this.Moddescription.Text = "Mod Description";
            // 
            // Modlink
            // 
            this.Modlink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Modlink.Location = new System.Drawing.Point(9, 148);
            this.Modlink.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Modlink.Name = "Modlink";
            this.Modlink.Size = new System.Drawing.Size(426, 35);
            this.Modlink.TabIndex = 2;
            this.Modlink.Text = "Mod Link";
            this.Modlink.UseVisualStyleBackColor = true;
            this.Modlink.Click += new System.EventHandler(this.ModLink_Click);
            // 
            // ModControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.Controls.Add(this.Modlink);
            this.Controls.Add(this.Moddescription);
            this.Controls.Add(this.Modname);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ModControl";
            this.Size = new System.Drawing.Size(450, 200);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Modname;
        private System.Windows.Forms.RichTextBox Moddescription;
        private System.Windows.Forms.Button Modlink;
    }
}
