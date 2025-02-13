namespace RecuDATsg
{
    partial class Form1RecuDat
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1RecuDat));
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.BtnVentanaIngreso = new FontAwesome.Sharp.IconButton();
            this.BtnVentanaBusqueda = new FontAwesome.Sharp.IconButton();
            this.BtnMenu = new FontAwesome.Sharp.IconButton();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.PanelFill = new System.Windows.Forms.Panel();
            this.PanelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLeft
            // 
            this.PanelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.PanelLeft.Controls.Add(this.BtnVentanaIngreso);
            this.PanelLeft.Controls.Add(this.BtnVentanaBusqueda);
            this.PanelLeft.Controls.Add(this.BtnMenu);
            this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft.Location = new System.Drawing.Point(0, 0);
            this.PanelLeft.Margin = new System.Windows.Forms.Padding(8);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(128, 461);
            this.PanelLeft.TabIndex = 0;
            // 
            // BtnVentanaIngreso
            // 
            this.BtnVentanaIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.BtnVentanaIngreso.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnVentanaIngreso.FlatAppearance.BorderSize = 0;
            this.BtnVentanaIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVentanaIngreso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnVentanaIngreso.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnVentanaIngreso.IconColor = System.Drawing.Color.White;
            this.BtnVentanaIngreso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnVentanaIngreso.IconSize = 32;
            this.BtnVentanaIngreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVentanaIngreso.Location = new System.Drawing.Point(0, 128);
            this.BtnVentanaIngreso.Margin = new System.Windows.Forms.Padding(0);
            this.BtnVentanaIngreso.Name = "BtnVentanaIngreso";
            this.BtnVentanaIngreso.Size = new System.Drawing.Size(128, 64);
            this.BtnVentanaIngreso.TabIndex = 5;
            this.BtnVentanaIngreso.Text = "Ingresar";
            this.BtnVentanaIngreso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnVentanaIngreso.UseVisualStyleBackColor = false;
            this.BtnVentanaIngreso.Click += new System.EventHandler(this.BtnVentanaIngresar_Click);
            // 
            // BtnVentanaBusqueda
            // 
            this.BtnVentanaBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.BtnVentanaBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnVentanaBusqueda.FlatAppearance.BorderSize = 0;
            this.BtnVentanaBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVentanaBusqueda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnVentanaBusqueda.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BtnVentanaBusqueda.IconColor = System.Drawing.Color.White;
            this.BtnVentanaBusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnVentanaBusqueda.IconSize = 32;
            this.BtnVentanaBusqueda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVentanaBusqueda.Location = new System.Drawing.Point(0, 64);
            this.BtnVentanaBusqueda.Margin = new System.Windows.Forms.Padding(0);
            this.BtnVentanaBusqueda.Name = "BtnVentanaBusqueda";
            this.BtnVentanaBusqueda.Size = new System.Drawing.Size(128, 64);
            this.BtnVentanaBusqueda.TabIndex = 4;
            this.BtnVentanaBusqueda.Text = "Buscar";
            this.BtnVentanaBusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVentanaBusqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnVentanaBusqueda.UseVisualStyleBackColor = false;
            this.BtnVentanaBusqueda.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.BtnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMenu.FlatAppearance.BorderSize = 0;
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.BtnMenu.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMenu.IconSize = 32;
            this.BtnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMenu.Location = new System.Drawing.Point(0, 0);
            this.BtnMenu.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(128, 64);
            this.BtnMenu.TabIndex = 6;
            this.BtnMenu.Text = "Menú";
            this.BtnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "lupa");
            this.ImageList.Images.SetKeyName(1, "fileplus");
            this.ImageList.Images.SetKeyName(2, "búsqueda50white.png");
            this.ImageList.Images.SetKeyName(3, "insertarpágina48white.png");
            this.ImageList.Images.SetKeyName(4, "arrow-left-to-line.png");
            this.ImageList.Images.SetKeyName(5, "arrow-right-long-to-line.png");
            this.ImageList.Images.SetKeyName(6, "rectangle-list.png");
            this.ImageList.Images.SetKeyName(7, "magnifying-glass.ico");
            // 
            // PanelFill
            // 
            this.PanelFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.PanelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFill.Location = new System.Drawing.Point(128, 0);
            this.PanelFill.Margin = new System.Windows.Forms.Padding(8);
            this.PanelFill.Name = "PanelFill";
            this.PanelFill.Padding = new System.Windows.Forms.Padding(16);
            this.PanelFill.Size = new System.Drawing.Size(656, 461);
            this.PanelFill.TabIndex = 1;
            // 
            // Form1RecuDat
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.PanelFill);
            this.Controls.Add(this.PanelLeft);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1RecuDat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NicoS92 App Recu DAT SG";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Panel PanelFill;
        private System.Windows.Forms.ImageList ImageList;
        private FontAwesome.Sharp.IconButton BtnVentanaBusqueda;
        private FontAwesome.Sharp.IconButton BtnVentanaIngreso;
        private FontAwesome.Sharp.IconButton BtnMenu;
    }
}

