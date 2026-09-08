namespace Renatitos
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
            panelinicio = new Panel();
            txtcontroldeinventario = new Label();
            btniniciar = new Button();
            labeliniciar = new Label();
            pictureBox1 = new PictureBox();
            panelsiguiente = new Panel();
            btniniciarsecion = new Button();
            textBox2 = new TextBox();
            txtboxusuario = new TextBox();
            txtcontraseño = new Label();
            txtusuario = new Label();
            pictureBox2 = new PictureBox();
            txtinventario = new Label();
            panelinicio.SuspendLayout();
            panelsiguiente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelinicio
            // 
            panelinicio.Controls.Add(txtcontroldeinventario);
            panelinicio.Controls.Add(btniniciar);
            panelinicio.Controls.Add(labeliniciar);
            panelinicio.Controls.Add(pictureBox1);
            panelinicio.Dock = DockStyle.Fill;
            panelinicio.Location = new Point(0, 0);
            panelinicio.Name = "panelinicio";
            panelinicio.Size = new Size(465, 450);
            panelinicio.TabIndex = 2;
            // 
            // txtcontroldeinventario
            // 
            txtcontroldeinventario.AutoSize = true;
            txtcontroldeinventario.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtcontroldeinventario.Location = new Point(66, 348);
            txtcontroldeinventario.Name = "txtcontroldeinventario";
            txtcontroldeinventario.Size = new Size(322, 26);
            txtcontroldeinventario.TabIndex = 3;
            txtcontroldeinventario.Text = "Control de inventario de stock";
            txtcontroldeinventario.Click += label1_Click;
            // 
            // btniniciar
            // 
            btniniciar.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btniniciar.Location = new Point(123, 388);
            btniniciar.Name = "btniniciar";
            btniniciar.Size = new Size(196, 31);
            btniniciar.TabIndex = 2;
            btniniciar.Text = "Iniciar";
            btniniciar.UseVisualStyleBackColor = true;
            btniniciar.Click += btniniciar_Click;
            // 
            // labeliniciar
            // 
            labeliniciar.AutoSize = true;
            labeliniciar.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeliniciar.Location = new Point(3, 9);
            labeliniciar.Name = "labeliniciar";
            labeliniciar.Size = new Size(479, 42);
            labeliniciar.TabIndex = 1;
            labeliniciar.Text = "Renatitos Software Solutions ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(81, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 279);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelsiguiente
            // 
            panelsiguiente.Controls.Add(btniniciarsecion);
            panelsiguiente.Controls.Add(textBox2);
            panelsiguiente.Controls.Add(txtboxusuario);
            panelsiguiente.Controls.Add(txtcontraseño);
            panelsiguiente.Controls.Add(txtusuario);
            panelsiguiente.Controls.Add(pictureBox2);
            panelsiguiente.Controls.Add(txtinventario);
            panelsiguiente.Dock = DockStyle.Fill;
            panelsiguiente.Location = new Point(0, 0);
            panelsiguiente.Name = "panelsiguiente";
            panelsiguiente.Size = new Size(465, 450);
            panelsiguiente.TabIndex = 4;
            // 
            // btniniciarsecion
            // 
            btniniciarsecion.Location = new Point(138, 322);
            btniniciarsecion.Name = "btniniciarsecion";
            btniniciarsecion.Size = new Size(138, 23);
            btniniciarsecion.TabIndex = 6;
            btniniciarsecion.Text = "Iniciar sesion";
            btniniciarsecion.UseVisualStyleBackColor = true;
            btniniciarsecion.Click += btniniciarsecion_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(176, 239);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // txtboxusuario
            // 
            txtboxusuario.Location = new Point(176, 191);
            txtboxusuario.Name = "txtboxusuario";
            txtboxusuario.Size = new Size(100, 23);
            txtboxusuario.TabIndex = 4;
            // 
            // txtcontraseño
            // 
            txtcontraseño.AutoSize = true;
            txtcontraseño.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtcontraseño.Location = new Point(41, 237);
            txtcontraseño.Name = "txtcontraseño";
            txtcontraseño.Size = new Size(110, 22);
            txtcontraseño.TabIndex = 3;
            txtcontraseño.Text = "Contraseña:";
            // 
            // txtusuario
            // 
            txtusuario.AutoSize = true;
            txtusuario.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtusuario.Location = new Point(41, 192);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(79, 22);
            txtusuario.TabIndex = 2;
            txtusuario.Text = "Usuario:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(323, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(130, 142);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // txtinventario
            // 
            txtinventario.AutoSize = true;
            txtinventario.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtinventario.Location = new Point(23, 64);
            txtinventario.Name = "txtinventario";
            txtinventario.Size = new Size(268, 32);
            txtinventario.TabIndex = 0;
            txtinventario.Text = "Inventario de tienda ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 450);
            Controls.Add(panelsiguiente);
            Controls.Add(panelinicio);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Renatitos";
            Load += Form1_Load;
            panelinicio.ResumeLayout(false);
            panelinicio.PerformLayout();
            panelsiguiente.ResumeLayout(false);
            panelsiguiente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelinicio;
        private Label labeliniciar;
        private PictureBox pictureBox1;
        private Button btniniciar;
        private Label txtcontroldeinventario;
        private Panel panelsiguiente;
        private PictureBox pictureBox2;
        private Label txtinventario;
        private TextBox textBox2;
        private TextBox txtboxusuario;
        private Label txtcontraseño;
        private Label txtusuario;
        private Button btniniciarsecion;
    }
}