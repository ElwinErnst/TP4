
namespace CrucigramaForms.Forms
{
    partial class Login
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
            this.logbtn = new System.Windows.Forms.Button();
            this.registerbtn = new System.Windows.Forms.Button();
            this.extbtn = new System.Windows.Forms.Button();
            this.Usertxt = new System.Windows.Forms.TextBox();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logbtn
            // 
            this.logbtn.Location = new System.Drawing.Point(86, 58);
            this.logbtn.Name = "logbtn";
            this.logbtn.Size = new System.Drawing.Size(81, 23);
            this.logbtn.TabIndex = 0;
            this.logbtn.Text = "Login";
            this.logbtn.UseVisualStyleBackColor = true;
            this.logbtn.Click += new System.EventHandler(this.logbtn_Click);
            // 
            // registerbtn
            // 
            this.registerbtn.Location = new System.Drawing.Point(86, 87);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(81, 23);
            this.registerbtn.TabIndex = 5;
            this.registerbtn.Text = "Registrarse";
            this.registerbtn.UseVisualStyleBackColor = true;
            this.registerbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // extbtn
            // 
            this.extbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.extbtn.Location = new System.Drawing.Point(159, 116);
            this.extbtn.Name = "extbtn";
            this.extbtn.Size = new System.Drawing.Size(57, 24);
            this.extbtn.TabIndex = 6;
            this.extbtn.Text = "Salir";
            this.extbtn.UseVisualStyleBackColor = true;
            this.extbtn.Click += new System.EventHandler(this.extbtn_Click);
            // 
            // Usertxt
            // 
            this.Usertxt.Location = new System.Drawing.Point(77, 8);
            this.Usertxt.Name = "Usertxt";
            this.Usertxt.Size = new System.Drawing.Size(100, 20);
            this.Usertxt.TabIndex = 2;
            this.Usertxt.TextChanged += new System.EventHandler(this.Usertxt_TextChanged);
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Location = new System.Drawing.Point(77, 32);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(100, 20);
            this.Passwordtxt.TabIndex = 4;
            this.Passwordtxt.UseSystemPasswordChar = true;
            this.Passwordtxt.TextChanged += new System.EventHandler(this.Passwordtxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña:";
            // 
            // Login
            // 
            this.AcceptButton = this.logbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.extbtn;
            this.ClientSize = new System.Drawing.Size(219, 143);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.Usertxt);
            this.Controls.Add(this.extbtn);
            this.Controls.Add(this.registerbtn);
            this.Controls.Add(this.logbtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logbtn;
        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.Button extbtn;
        private System.Windows.Forms.TextBox Usertxt;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}