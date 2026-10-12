namespace Renatitos
{
    partial class FormAlmacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlmacen));
            dgvproductos = new DataGridView();
            btnactualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvproductos).BeginInit();
            SuspendLayout();
            // 
            // dgvproductos
            // 
            dgvproductos.BackgroundColor = Color.Honeydew;
            dgvproductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvproductos.Location = new Point(2, 37);
            dgvproductos.Name = "dgvproductos";
            dgvproductos.Size = new Size(703, 308);
            dgvproductos.TabIndex = 0;
            // 
            // btnactualizar
            // 
            btnactualizar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnactualizar.Location = new Point(289, 351);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new Size(99, 41);
            btnactualizar.TabIndex = 1;
            btnactualizar.Text = "Actualizar";
            btnactualizar.UseVisualStyleBackColor = true;
            btnactualizar.Click += btnactualizar_Click_1;
            // 
            // FormAlmacen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(708, 404);
            Controls.Add(btnactualizar);
            Controls.Add(dgvproductos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAlmacen";
            Text = "Almacen";
            Load += FormAlmacen_Load;
            ((System.ComponentModel.ISupportInitialize)dgvproductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvproductos;
        private Button btnactualizar;
    }
}