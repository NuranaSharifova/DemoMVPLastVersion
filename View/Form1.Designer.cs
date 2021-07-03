namespace Lab.View
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.namelabel = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.addressTextbox = new System.Windows.Forms.TextBox();
            this.Addresslabel = new System.Windows.Forms.Label();
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.Emaillabel = new System.Windows.Forms.Label();
            this.Nationalitycombo = new System.Windows.Forms.ComboBox();
            this.Nationalitytextbox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(294, 292);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(395, 310);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(538, 310);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(392, 43);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(45, 17);
            this.namelabel.TabIndex = 3;
            this.namelabel.Text = "Name";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(395, 63);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(100, 22);
            this.nameTextbox.TabIndex = 4;
            // 
            // addressTextbox
            // 
            this.addressTextbox.Location = new System.Drawing.Point(395, 118);
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.Size = new System.Drawing.Size(100, 22);
            this.addressTextbox.TabIndex = 6;
            // 
            // Addresslabel
            // 
            this.Addresslabel.AutoSize = true;
            this.Addresslabel.Location = new System.Drawing.Point(392, 98);
            this.Addresslabel.Name = "Addresslabel";
            this.Addresslabel.Size = new System.Drawing.Size(60, 17);
            this.Addresslabel.TabIndex = 5;
            this.Addresslabel.Text = "Address";
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Location = new System.Drawing.Point(395, 176);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(100, 22);
            this.EmailTextbox.TabIndex = 8;
            // 
            // Emaillabel
            // 
            this.Emaillabel.AutoSize = true;
            this.Emaillabel.Location = new System.Drawing.Point(392, 156);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(42, 17);
            this.Emaillabel.TabIndex = 7;
            this.Emaillabel.Text = "Email";
            // 
            // Nationalitycombo
            // 
            this.Nationalitycombo.FormattingEnabled = true;
            this.Nationalitycombo.Items.AddRange(new object[] {
            "Russian",
            "Azerbaijanian",
            "English",
            "French",
            "German"});
            this.Nationalitycombo.Location = new System.Drawing.Point(395, 235);
            this.Nationalitycombo.Name = "Nationalitycombo";
            this.Nationalitycombo.Size = new System.Drawing.Size(121, 24);
            this.Nationalitycombo.TabIndex = 9;
            // 
            // Nationalitytextbox
            // 
            this.Nationalitytextbox.AutoSize = true;
            this.Nationalitytextbox.Location = new System.Drawing.Point(392, 215);
            this.Nationalitytextbox.Name = "Nationalitytextbox";
            this.Nationalitytextbox.Size = new System.Drawing.Size(74, 17);
            this.Nationalitytextbox.TabIndex = 10;
            this.Nationalitytextbox.Text = "Nationality";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Nationalitytextbox);
            this.Controls.Add(this.Nationalitycombo);
            this.Controls.Add(this.EmailTextbox);
            this.Controls.Add(this.Emaillabel);
            this.Controls.Add(this.addressTextbox);
            this.Controls.Add(this.Addresslabel);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.TextBox addressTextbox;
        private System.Windows.Forms.Label Addresslabel;
        private System.Windows.Forms.TextBox EmailTextbox;
        private System.Windows.Forms.Label Emaillabel;
        private System.Windows.Forms.ComboBox Nationalitycombo;
        private System.Windows.Forms.Label Nationalitytextbox;
    }
}