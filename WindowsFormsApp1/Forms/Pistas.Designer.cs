
namespace crucigramaForm
{
    partial class Pistas
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
            this.tabla_pistas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_pistas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabla_pistas
            // 
            this.tabla_pistas.AllowUserToAddRows = false;
            this.tabla_pistas.AllowUserToDeleteRows = false;
            this.tabla_pistas.AllowUserToOrderColumns = true;
            this.tabla_pistas.AllowUserToResizeColumns = false;
            this.tabla_pistas.AllowUserToResizeRows = false;
            this.tabla_pistas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.tabla_pistas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.tabla_pistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_pistas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4});
            this.tabla_pistas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabla_pistas.Location = new System.Drawing.Point(0, 0);
            this.tabla_pistas.Name = "tabla_pistas";
            this.tabla_pistas.RowHeadersVisible = false;
            this.tabla_pistas.Size = new System.Drawing.Size(384, 530);
            this.tabla_pistas.TabIndex = 0;
            this.tabla_pistas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_pistas_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.Width = 39;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Direccion";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 77;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Pistas";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Pistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 530);
            this.Controls.Add(this.tabla_pistas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pistas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Pistas";
            this.Load += new System.EventHandler(this.forms1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_pistas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        public System.Windows.Forms.DataGridView tabla_pistas;
    }
}