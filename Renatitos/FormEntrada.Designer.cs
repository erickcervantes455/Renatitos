namespace Renatitos
{
    partial class FormEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEntrada));
            txtnombre = new TextBox();
            labelnombre = new Label();
            labelcodigo = new Label();
            txtcodigo = new TextBox();
            labelprecio = new Label();
            txtprecio = new TextBox();
            labelcantidad = new Label();
            txtcantidad = new TextBox();
            btnentrada = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(170, 30);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(100, 23);
            txtnombre.TabIndex = 0;
            txtnombre.TextChanged += txtnombre_TextChanged;
            // 
            // labelnombre
            // 
            labelnombre.AutoSize = true;
            labelnombre.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelnombre.Location = new Point(9, 30);
            labelnombre.Name = "labelnombre";
            labelnombre.Size = new Size(154, 19);
            labelnombre.TabIndex = 1;
            labelnombre.Text = "Nombre del producto:";
            // 
            // labelcodigo
            // 
            labelcodigo.AutoSize = true;
            labelcodigo.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelcodigo.Location = new Point(9, 75);
            labelcodigo.Name = "labelcodigo";
            labelcodigo.Size = new Size(147, 19);
            labelcodigo.TabIndex = 2;
            labelcodigo.Text = "Codigo del producto:";
            // 
            // txtcodigo
            // 
            txtcodigo.Location = new Point(170, 75);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(100, 23);
            txtcodigo.TabIndex = 3;
            // 
            // labelprecio
            // 
            labelprecio.AutoSize = true;
            labelprecio.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelprecio.Location = new Point(9, 125);
            labelprecio.Name = "labelprecio";
            labelprecio.Size = new Size(142, 19);
            labelprecio.TabIndex = 4;
            labelprecio.Text = "Precio del producto:";
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(170, 125);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(100, 23);
            txtprecio.TabIndex = 5;
            // 
            // labelcantidad
            // 
            labelcantidad.AutoSize = true;
            labelcantidad.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelcantidad.Location = new Point(9, 172);
            labelcantidad.Name = "labelcantidad";
            labelcantidad.Size = new Size(145, 19);
            labelcantidad.TabIndex = 6;
            labelcantidad.Text = "Cantidad a ingresar:";
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(170, 168);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(100, 23);
            txtcantidad.TabIndex = 7;
            // 
            // btnentrada
            // 
            btnentrada.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnentrada.Location = new Point(113, 248);
            btnentrada.Name = "btnentrada";
            btnentrada.Size = new Size(157, 34);
            btnentrada.TabIndex = 8;
            btnentrada.Text = "Ingresar producto";
            btnentrada.UseVisualStyleBackColor = true;
            btnentrada.Click += btnentrada_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(257, -6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // FormEntrada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 331);
            Controls.Add(btnentrada);
            Controls.Add(txtcantidad);
            Controls.Add(labelcantidad);
            Controls.Add(txtprecio);
            Controls.Add(labelprecio);
            Controls.Add(txtcodigo);
            Controls.Add(labelcodigo);
            Controls.Add(labelnombre);
            Controls.Add(txtnombre);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormEntrada";
            Text = "Entrada";
            Load += FormEntrada_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnombre;
        private Label labelnombre;
        private Label labelcodigo;
        private TextBox txtcodigo;
        private Label labelprecio;
        private TextBox txtprecio;
        private Label labelcantidad;
        private TextBox txtcantidad;
        private Button btnentrada;
        private PictureBox pictureBox1;
    }
}