namespace Aplikasi_Hotel_Reception
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            nama = new TextBox();
            pss = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mona Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 84);
            label1.Name = "label1";
            label1.Size = new Size(67, 24);
            label1.TabIndex = 0;
            label1.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mona Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 166);
            label2.Name = "label2";
            label2.Size = new Size(100, 24);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // nama
            // 
            nama.Font = new Font("Mona Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nama.Location = new Point(179, 84);
            nama.Name = "nama";
            nama.Size = new Size(325, 30);
            nama.TabIndex = 2;
            // 
            // pss
            // 
            pss.Font = new Font("Mona Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pss.Location = new Point(179, 162);
            pss.Name = "pss";
            pss.PasswordChar = '#';
            pss.Size = new Size(325, 30);
            pss.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Mona Sans SemiBold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(179, 251);
            button1.Name = "button1";
            button1.Size = new Size(99, 28);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Mona Sans SemiBold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(405, 251);
            button2.Name = "button2";
            button2.Size = new Size(99, 28);
            button2.TabIndex = 5;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Mona Sans", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(186, 9);
            label3.Name = "label3";
            label3.Size = new Size(192, 30);
            label3.TabIndex = 6;
            label3.Text = "Halaman Login";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(575, 332);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pss);
            Controls.Add(nama);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Mona Sans SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            Name = "Form1";
            Text = "BRTWL Hotel Login Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox nama;
        private TextBox pss;
        private Button button1;
        private Button button2;
        private Label label3;
    }
}
