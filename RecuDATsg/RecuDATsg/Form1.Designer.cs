namespace RecuDATsg
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.BtnVentanaIngresar = new Controles.NSButton();
            this.BtnBuscar = new Controles.NSButton();
            this.PanelFill = new System.Windows.Forms.Panel();
            this.PanelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLeft
            // 
            this.PanelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.PanelLeft.Controls.Add(this.BtnVentanaIngresar);
            this.PanelLeft.Controls.Add(this.BtnBuscar);
            this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft.Location = new System.Drawing.Point(0, 0);
            this.PanelLeft.Margin = new System.Windows.Forms.Padding(8);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Padding = new System.Windows.Forms.Padding(8);
            this.PanelLeft.Size = new System.Drawing.Size(150, 461);
            this.PanelLeft.TabIndex = 0;
            // 
            // BtnVentanaIngresar
            // 
            this.BtnVentanaIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.BtnVentanaIngresar.BackGroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.BtnVentanaIngresar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.BtnVentanaIngresar.BorderRadius = 16;
            this.BtnVentanaIngresar.BorderSize = 2;
            this.BtnVentanaIngresar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnVentanaIngresar.FlatAppearance.BorderSize = 0;
            this.BtnVentanaIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVentanaIngresar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVentanaIngresar.ForeColor = System.Drawing.Color.White;
            this.BtnVentanaIngresar.Location = new System.Drawing.Point(8, 72);
            this.BtnVentanaIngresar.Margin = new System.Windows.Forms.Padding(4, 16, 4, 4);
            this.BtnVentanaIngresar.Name = "BtnVentanaIngresar";
            this.BtnVentanaIngresar.Size = new System.Drawing.Size(134, 64);
            this.BtnVentanaIngresar.TabIndex = 1;
            this.BtnVentanaIngresar.Text = "+ Ingresar Nuevo";
            this.BtnVentanaIngresar.TextColor = System.Drawing.Color.White;
            this.BtnVentanaIngresar.UseVisualStyleBackColor = false;
            this.BtnVentanaIngresar.Click += new System.EventHandler(this.BtnVentanaIngresar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.BtnBuscar.BackGroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.BtnBuscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.BtnBuscar.BorderRadius = 16;
            this.BtnBuscar.BorderSize = 2;
            this.BtnBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.Location = new System.Drawing.Point(8, 8);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4, 16, 4, 4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(134, 64);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextColor = System.Drawing.Color.White;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // PanelFill
            // 
            this.PanelFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.PanelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFill.Location = new System.Drawing.Point(150, 0);
            this.PanelFill.Margin = new System.Windows.Forms.Padding(8);
            this.PanelFill.Name = "PanelFill";
            this.PanelFill.Padding = new System.Windows.Forms.Padding(16);
            this.PanelFill.Size = new System.Drawing.Size(634, 461);
            this.PanelFill.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.PanelFill);
            this.Controls.Add(this.PanelLeft);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NicoS92 App Recu DAT SG";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Panel PanelFill;
        private Controles.NSButton BtnVentanaIngresar;
        private Controles.NSButton BtnBuscar;
    }
}

