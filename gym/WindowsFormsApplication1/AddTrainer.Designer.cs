namespace WindowsFormsApplication1
{
    partial class AddTrainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTrainer));
            this.txbx_contact = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txbx_name = new System.Windows.Forms.TextBox();
            this.femalrb = new System.Windows.Forms.RadioButton();
            this.malerb = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_address = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbx_contact
            // 
            this.txbx_contact.Location = new System.Drawing.Point(511, 281);
            this.txbx_contact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbx_contact.Name = "txbx_contact";
            this.txbx_contact.Size = new System.Drawing.Size(247, 22);
            this.txbx_contact.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(296, 278);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "Trainer Contact";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(548, 367);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 38);
            this.button5.TabIndex = 28;
            this.button5.Text = "Cancel";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Green;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(361, 367);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(140, 38);
            this.btn_Add.TabIndex = 29;
            this.btn_Add.Text = "Submit";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // txbx_name
            // 
            this.txbx_name.Location = new System.Drawing.Point(511, 105);
            this.txbx_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbx_name.Name = "txbx_name";
            this.txbx_name.Size = new System.Drawing.Size(247, 22);
            this.txbx_name.TabIndex = 20;
            // 
            // femalrb
            // 
            this.femalrb.AutoSize = true;
            this.femalrb.BackColor = System.Drawing.Color.Transparent;
            this.femalrb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femalrb.ForeColor = System.Drawing.Color.Transparent;
            this.femalrb.Location = new System.Drawing.Point(644, 166);
            this.femalrb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.femalrb.Name = "femalrb";
            this.femalrb.Size = new System.Drawing.Size(104, 27);
            this.femalrb.TabIndex = 22;
            this.femalrb.Text = "Female";
            this.femalrb.UseVisualStyleBackColor = false;
            // 
            // malerb
            // 
            this.malerb.AutoSize = true;
            this.malerb.BackColor = System.Drawing.Color.Transparent;
            this.malerb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.malerb.ForeColor = System.Drawing.Color.Transparent;
            this.malerb.Location = new System.Drawing.Point(511, 166);
            this.malerb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.malerb.Name = "malerb";
            this.malerb.Size = new System.Drawing.Size(80, 27);
            this.malerb.TabIndex = 21;
            this.malerb.Text = "Male";
            this.malerb.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(296, 218);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 23);
            this.label11.TabIndex = 25;
            this.label11.Text = "Trainer Address";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(295, 105);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 23);
            this.label12.TabIndex = 26;
            this.label12.Text = "Name Of Trainer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(319, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 32;
            this.label1.Text = "Gender";
            // 
            // txbx_address
            // 
            this.txbx_address.Location = new System.Drawing.Point(511, 220);
            this.txbx_address.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbx_address.Name = "txbx_address";
            this.txbx_address.Size = new System.Drawing.Size(247, 22);
            this.txbx_address.TabIndex = 33;
            // 
            // AddTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.txbx_address);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbx_contact);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txbx_name);
            this.Controls.Add(this.femalrb);
            this.Controls.Add(this.malerb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddTrainer";
            this.Size = new System.Drawing.Size(1144, 581);
            this.Load += new System.EventHandler(this.AddTrainer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbx_contact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txbx_name;
        private System.Windows.Forms.RadioButton femalrb;
        private System.Windows.Forms.RadioButton malerb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_address;
    }
}
