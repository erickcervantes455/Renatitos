namespace Renatitos
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            puntoDeVentaToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            salirToolStripMenuItem = new ToolStripMenuItem();
            inventarioToolStripMenuItem = new ToolStripMenuItem();
            entradaToolStripMenuItem = new ToolStripMenuItem();
            salidaToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            almacenToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, inventarioToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(577, 27);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { puntoDeVentaToolStripMenuItem, toolStripMenuItem2, salirToolStripMenuItem });
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(54, 23);
            inicioToolStripMenuItem.Text = "&Inicio";
            // 
            // puntoDeVentaToolStripMenuItem
            // 
            puntoDeVentaToolStripMenuItem.Name = "puntoDeVentaToolStripMenuItem";
            puntoDeVentaToolStripMenuItem.Size = new Size(168, 24);
            puntoDeVentaToolStripMenuItem.Text = "Punto de venta";
            puntoDeVentaToolStripMenuItem.Click += puntoDeVentaToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(165, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(168, 24);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click_1;
            // 
            // inventarioToolStripMenuItem
            // 
            inventarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { entradaToolStripMenuItem, salidaToolStripMenuItem, toolStripMenuItem1, almacenToolStripMenuItem });
            inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            inventarioToolStripMenuItem.Size = new Size(81, 23);
            inventarioToolStripMenuItem.Text = "&Inventario";
            // 
            // entradaToolStripMenuItem
            // 
            entradaToolStripMenuItem.Name = "entradaToolStripMenuItem";
            entradaToolStripMenuItem.Size = new Size(131, 24);
            entradaToolStripMenuItem.Text = "Entrada";
            entradaToolStripMenuItem.Click += entradaToolStripMenuItem_Click;
            // 
            // salidaToolStripMenuItem
            // 
            salidaToolStripMenuItem.Name = "salidaToolStripMenuItem";
            salidaToolStripMenuItem.Size = new Size(131, 24);
            salidaToolStripMenuItem.Text = "Salida";
            salidaToolStripMenuItem.Click += salidaToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(128, 6);
            // 
            // almacenToolStripMenuItem
            // 
            almacenToolStripMenuItem.Name = "almacenToolStripMenuItem";
            almacenToolStripMenuItem.Size = new Size(131, 24);
            almacenToolStripMenuItem.Text = "Almacen";
            almacenToolStripMenuItem.Click += almacenToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(577, 419);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 450);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Renatitos Software Solutions";
            Load += Form2_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem inventarioToolStripMenuItem;
        private ToolStripMenuItem entradaToolStripMenuItem;
        private ToolStripMenuItem salidaToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem almacenToolStripMenuItem;
        private ToolStripMenuItem puntoDeVentaToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}