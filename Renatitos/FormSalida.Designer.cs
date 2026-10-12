namespace Renatitos
{
    partial class FormSalida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSalida));
            btnsalida = new Button();
            txtcodigo = new TextBox();
            txtcantidad = new TextBox();
            labellcodigo = new Label();
            labellcantidad = new Label();
            SuspendLayout();
            // 
            // btnsalida
            // 
            btnsalida.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsalida.Location = new Point(87, 180);
            btnsalida.Name = "btnsalida";
            btnsalida.Size = new Size(128, 30);
            btnsalida.TabIndex = 0;
            btnsalida.Text = "Registrar salida";
            btnsalida.UseVisualStyleBackColor = true;
            btnsalida.Click += btnsalida_Click_1;
            // 
            // txtcodigo
            // 
            txtcodigo.Location = new Point(172, 38);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(100, 23);
            txtcodigo.TabIndex = 1;
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(172, 86);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(100, 23);
            txtcantidad.TabIndex = 2;
            // 
            // labellcodigo
            // 
            labellcodigo.AutoSize = true;
            labellcodigo.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labellcodigo.Location = new Point(12, 42);
            labellcodigo.Name = "labellcodigo";
            labellcodigo.Size = new Size(147, 19);
            labellcodigo.TabIndex = 3;
            labellcodigo.Text = "Codigo del producto:";
            // 
            // labellcantidad
            // 
            labellcantidad.AutoSize = true;
            labellcantidad.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labellcantidad.Location = new Point(12, 90);
            labellcantidad.Name = "labellcantidad";
            labellcantidad.Size = new Size(133, 19);
            labellcantidad.TabIndex = 4;
            labellcantidad.Text = "Cantidad a retirar:";
            // 
            // FormSalida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 252);
            Controls.Add(labellcantidad);
            Controls.Add(labellcodigo);
            Controls.Add(txtcantidad);
            Controls.Add(txtcodigo);
            Controls.Add(btnsalida);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormSalida";
            Text = "Salida";
            Load += FormSalida_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnsalida;
        private TextBox txtcodigo;
        private TextBox txtcantidad;
        private Label labellcodigo;
        private Label labellcantidad;
    }
}