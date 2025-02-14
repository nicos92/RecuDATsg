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
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.PanelFill = new System.Windows.Forms.Panel();
            this.BtnVentanaIngreso = new Controles.NSButton();
            this.BtnVentanaBusqueda = new Controles.NSButton();
            this.BtnMenu = new Controles.NSButton();
            this.PanelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLeft
            // 
            this.PanelLeft.BackColor = System.Drawing.Color.WhiteSmoke;
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
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "bars-solid (1).png");
            this.ImageList.Images.SetKeyName(1, "plus-solid (1).png");
            this.ImageList.Images.SetKeyName(2, "search-solid (1).png");
            this.ImageList.Images.SetKeyName(3, "bars-solidv.ico");
            this.ImageList.Images.SetKeyName(4, "bars-solidg.ico");
            this.ImageList.Images.SetKeyName(5, "bars-solid (1) (Personalizado).png");
            this.ImageList.Images.SetKeyName(6, "bars-solid (1) (Personalizado) (1).png");
            this.ImageList.Images.SetKeyName(7, "bars-solid (1) (Personalizado) (2).png");
            this.ImageList.Images.SetKeyName(8, "icons8búsqueda24.png");
            this.ImageList.Images.SetKeyName(9, "icons8mas24.png");
            this.ImageList.Images.SetKeyName(10, "icons8menu24.png");
            this.ImageList.Images.SetKeyName(11, "icons8mas128.png");
            this.ImageList.Images.SetKeyName(12, "search.png");
            this.ImageList.Images.SetKeyName(13, "bars-solid.png");
            this.ImageList.Images.SetKeyName(14, "plus-solid.png");
            this.ImageList.Images.SetKeyName(15, "search-solid.png");
            this.ImageList.Images.SetKeyName(16, "bars-solid (1) (Personalizado) (3).png");
            this.ImageList.Images.SetKeyName(17, "plus-solid (1) (Personalizado).png");
            this.ImageList.Images.SetKeyName(18, "search-solid (1) (Personalizado).png");
            this.ImageList.Images.SetKeyName(19, "icons8-búsqueda-24.png");
            this.ImageList.Images.SetKeyName(20, "icons8-búsqueda-50.png");
            this.ImageList.Images.SetKeyName(21, "icons8-búsqueda-24(1).png");
            this.ImageList.Images.SetKeyName(22, "icons8-búsqueda-50(1).png");
            // 
            // PanelFill
            // 
            this.PanelFill.BackColor = System.Drawing.Color.White;
            this.PanelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFill.Location = new System.Drawing.Point(128, 0);
            this.PanelFill.Margin = new System.Windows.Forms.Padding(8);
            this.PanelFill.Name = "PanelFill";
            this.PanelFill.Padding = new System.Windows.Forms.Padding(16);
            this.PanelFill.Size = new System.Drawing.Size(656, 461);
            this.PanelFill.TabIndex = 1;
            // 
            // BtnVentanaIngreso
            // 
            this.BtnVentanaIngreso.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnVentanaIngreso.BackGroudColor = System.Drawing.Color.WhiteSmoke;
            this.BtnVentanaIngreso.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnVentanaIngreso.BorderRadius = 0;
            this.BtnVentanaIngreso.BorderSize = 0;
            this.BtnVentanaIngreso.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnVentanaIngreso.FlatAppearance.BorderSize = 0;
            this.BtnVentanaIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVentanaIngreso.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVentanaIngreso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnVentanaIngreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVentanaIngreso.ImageIndex = 14;
            this.BtnVentanaIngreso.ImageList = this.ImageList;
            this.BtnVentanaIngreso.Location = new System.Drawing.Point(0, 113);
            this.BtnVentanaIngreso.Name = "BtnVentanaIngreso";
            this.BtnVentanaIngreso.Size = new System.Drawing.Size(128, 49);
            this.BtnVentanaIngreso.TabIndex = 2;
            this.BtnVentanaIngreso.Text = "Ingresar";
            this.BtnVentanaIngreso.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnVentanaIngreso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnVentanaIngreso.UseVisualStyleBackColor = false;
            this.BtnVentanaIngreso.Click += new System.EventHandler(this.BtnVentanaIngresar_Click);
            // 
            // BtnVentanaBusqueda
            // 
            this.BtnVentanaBusqueda.BackColor = System.Drawing.Color.White;
            this.BtnVentanaBusqueda.BackGroudColor = System.Drawing.Color.White;
            this.BtnVentanaBusqueda.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnVentanaBusqueda.BorderRadius = 0;
            this.BtnVentanaBusqueda.BorderSize = 0;
            this.BtnVentanaBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnVentanaBusqueda.FlatAppearance.BorderSize = 0;
            this.BtnVentanaBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVentanaBusqueda.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVentanaBusqueda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnVentanaBusqueda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVentanaBusqueda.ImageIndex = 15;
            this.BtnVentanaBusqueda.ImageList = this.ImageList;
            this.BtnVentanaBusqueda.Location = new System.Drawing.Point(0, 49);
            this.BtnVentanaBusqueda.Name = "BtnVentanaBusqueda";
            this.BtnVentanaBusqueda.Size = new System.Drawing.Size(128, 64);
            this.BtnVentanaBusqueda.TabIndex = 1;
            this.BtnVentanaBusqueda.Text = "Buscar";
            this.BtnVentanaBusqueda.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnVentanaBusqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnVentanaBusqueda.UseVisualStyleBackColor = false;
            this.BtnVentanaBusqueda.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnMenu.BackGroudColor = System.Drawing.Color.WhiteSmoke;
            this.BtnMenu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnMenu.BorderRadius = 0;
            this.BtnMenu.BorderSize = 0;
            this.BtnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMenu.FlatAppearance.BorderSize = 0;
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMenu.ImageIndex = 13;
            this.BtnMenu.ImageList = this.ImageList;
            this.BtnMenu.Location = new System.Drawing.Point(0, 0);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(128, 49);
            this.BtnMenu.TabIndex = 0;
            this.BtnMenu.Text = "Menú";
            this.BtnMenu.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
        private Controles.NSButton BtnVentanaIngreso;
        private Controles.NSButton BtnVentanaBusqueda;
        private Controles.NSButton BtnMenu;
    }
}

