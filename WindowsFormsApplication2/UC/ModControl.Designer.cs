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
            this.components = new System.ComponentModel.Container();
            this.Modname = new System.Windows.Forms.Label();
            this.Moddescription = new System.Windows.Forms.RichTextBox();
            this.Modlink = new System.Windows.Forms.Button();
            this.modBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.modBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Modname
            // 
            this.Modname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Modname.AutoSize = true;
            this.Modname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Modname.Location = new System.Drawing.Point(3, 0);
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
            this.Moddescription.Location = new System.Drawing.Point(8, 32);
            this.Moddescription.Name = "Moddescription";
            this.Moddescription.ReadOnly = true;
            this.Moddescription.Size = new System.Drawing.Size(284, 50);
            this.Moddescription.TabIndex = 1;
            this.Moddescription.Text = "Mod Description";
            // 
            // Modlink
            // 
            this.Modlink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Modlink.Location = new System.Drawing.Point(8, 89);
            this.Modlink.Name = "Modlink";
            this.Modlink.Size = new System.Drawing.Size(284, 23);
            this.Modlink.TabIndex = 2;
            this.Modlink.Text = "Mod Link";
            this.Modlink.UseVisualStyleBackColor = true;
            this.Modlink.Click += new System.EventHandler(this.ModLink_Click);
            // 
            // modBindingSource
            // 
            this.modBindingSource.DataSource = typeof(WindowsFormsApplication2.mod);
            // 
            // ModControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Modlink);
            this.Controls.Add(this.Moddescription);
            this.Controls.Add(this.Modname);
            this.Name = "ModControl";
            this.Size = new System.Drawing.Size(300, 150);
            ((System.ComponentModel.ISupportInitialize)(this.modBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource modBindingSource;
        private System.Windows.Forms.Label Modname;
        private System.Windows.Forms.RichTextBox Moddescription;
        private System.Windows.Forms.Button Modlink;
    }
}
