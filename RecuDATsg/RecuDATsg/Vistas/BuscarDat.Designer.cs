namespace RecuDATsg.Vistas
{
    partial class BuscarDat
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelFill = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ListViewDAT = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.ProgressBarTop = new Controles.NSProgressBar();
            this.Copy = new Controles.NSButton();
            this.BtnRecover = new Controles.NSButton();
            this.BtnRefresh = new Controles.NSButton();
            this.TxtBuscar = new Controles.NSTextBox();
            this.BtnBuscar = new Controles.NSButton();
            this.PanelFill.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelFill
            // 
            this.PanelFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.PanelFill.Controls.Add(this.tableLayoutPanel1);
            this.PanelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFill.Location = new System.Drawing.Point(0, 0);
            this.PanelFill.Margin = new System.Windows.Forms.Padding(8);
            this.PanelFill.Name = "PanelFill";
            this.PanelFill.Padding = new System.Windows.Forms.Padding(16);
            this.PanelFill.Size = new System.Drawing.Size(634, 461);
            this.PanelFill.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ListViewDAT, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(602, 429);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ListViewDAT
            // 
            this.ListViewDAT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.ListViewDAT.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.ListViewDAT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewDAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListViewDAT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ListViewDAT.FullRowSelect = true;
            this.ListViewDAT.HideSelection = false;
            this.ListViewDAT.Location = new System.Drawing.Point(16, 80);
            this.ListViewDAT.Margin = new System.Windows.Forms.Padding(16);
            this.ListViewDAT.MultiSelect = false;
            this.ListViewDAT.Name = "ListViewDAT";
            this.ListViewDAT.Size = new System.Drawing.Size(570, 268);
            this.ListViewDAT.TabIndex = 3;
            this.ListViewDAT.UseCompatibleStateImageBehavior = false;
            this.ListViewDAT.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ARCHIVO";
            this.columnHeader2.Width = 128;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "SECTOR";
            this.columnHeader3.Width = 196;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "CARTEL ERROR";
            this.columnHeader4.Width = 196;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "OBSERVACION";
            this.columnHeader5.Width = 256;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.Copy, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnRecover, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 367);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(596, 59);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.BtnRefresh, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.TxtBuscar, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.BtnBuscar, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(596, 58);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Palabra Clave:";
            // 
            // ProgressBarTop
            // 
            this.ProgressBarTop.ChannelColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.ProgressBarTop.ChannelHeight = 8;
            this.ProgressBarTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProgressBarTop.ForeBackColor = System.Drawing.Color.PaleVioletRed;
            this.ProgressBarTop.ForeColor = System.Drawing.Color.White;
            this.ProgressBarTop.Location = new System.Drawing.Point(0, 0);
            this.ProgressBarTop.Name = "ProgressBarTop";
            this.ProgressBarTop.ShowMaximun = false;
            this.ProgressBarTop.ShowValue = Controles.MiTextPosition.None;
            this.ProgressBarTop.Size = new System.Drawing.Size(634, 8);
            this.ProgressBarTop.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.ProgressBarTop.Sliderheight = 8;
            this.ProgressBarTop.SymbolAfter = "";
            this.ProgressBarTop.SymbolBefore = "";
            this.ProgressBarTop.TabIndex = 3;
            this.ProgressBarTop.Visible = false;
            // 
            // Copy
            // 
            this.Copy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Copy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(40)))), ((int)(((byte)(224)))));
            this.Copy.BackGroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(40)))), ((int)(((byte)(224)))));
            this.Copy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(194)))));
            this.Copy.BorderRadius = 16;
            this.Copy.BorderSize = 0;
            this.Copy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Copy.FlatAppearance.BorderSize = 0;
            this.Copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Copy.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copy.ForeColor = System.Drawing.Color.White;
            this.Copy.Location = new System.Drawing.Point(122, 5);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(112, 48);
            this.Copy.TabIndex = 4;
            this.Copy.Text = "Copy";
            this.Copy.TextColor = System.Drawing.Color.White;
            this.Copy.UseVisualStyleBackColor = false;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // BtnRecover
            // 
            this.BtnRecover.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnRecover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.BtnRecover.BackGroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.BtnRecover.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.BtnRecover.BorderRadius = 16;
            this.BtnRecover.BorderSize = 2;
            this.BtnRecover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRecover.FlatAppearance.BorderSize = 0;
            this.BtnRecover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRecover.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRecover.ForeColor = System.Drawing.Color.White;
            this.BtnRecover.Location = new System.Drawing.Point(360, 5);
            this.BtnRecover.Name = "BtnRecover";
            this.BtnRecover.Size = new System.Drawing.Size(112, 48);
            this.BtnRecover.TabIndex = 5;
            this.BtnRecover.Text = "Recover1";
            this.BtnRecover.TextColor = System.Drawing.Color.White;
            this.BtnRecover.UseVisualStyleBackColor = false;
            this.BtnRecover.Click += new System.EventHandler(this.BtnRecover_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(210)))), ((int)(((byte)(242)))));
            this.BtnRefresh.BackGroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(210)))), ((int)(((byte)(242)))));
            this.BtnRefresh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(194)))));
            this.BtnRefresh.BorderRadius = 16;
            this.BtnRefresh.BorderSize = 0;
            this.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefresh.FlatAppearance.BorderSize = 0;
            this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresh.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefresh.ForeColor = System.Drawing.Color.White;
            this.BtnRefresh.Image = global::RecuDATsg.Properties.Resources.icons8actualizacionesdisponibles5024;
            this.BtnRefresh.Location = new System.Drawing.Point(3, 5);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(48, 48);
            this.BtnRefresh.TabIndex = 4;
            this.BtnRefresh.TextColor = System.Drawing.Color.White;
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.TxtBuscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.TxtBuscar.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.TxtBuscar.BorderSize = 2;
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TxtBuscar.Location = new System.Drawing.Point(143, 13);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.TxtBuscar.MaxLenght = 32;
            this.TxtBuscar.Multiline = false;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Padding = new System.Windows.Forms.Padding(7);
            this.TxtBuscar.PasswordChar = false;
            this.TxtBuscar.ReadOnly = false;
            this.TxtBuscar.Size = new System.Drawing.Size(336, 35);
            this.TxtBuscar.TabIndex = 1;
            this.TxtBuscar.UnderLinesStyle = false;
            this.TxtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.BtnBuscar.BackGroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.BtnBuscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(194)))));
            this.BtnBuscar.BorderRadius = 16;
            this.BtnBuscar.BorderSize = 0;
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.Location = new System.Drawing.Point(501, 5);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(80, 48);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextColor = System.Drawing.Color.White;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BuscarDat
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.ProgressBarTop);
            this.Controls.Add(this.PanelFill);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "BuscarDat";
            this.Size = new System.Drawing.Size(634, 461);
            this.Load += new System.EventHandler(this.BuscarDat_Load);
            this.PanelFill.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelFill;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView ListViewDAT;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Controles.NSButton Copy;
        private Controles.NSButton BtnRecover;
        private Controles.NSButton BtnRefresh;
        private Controles.NSProgressBar ProgressBarTop;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Controles.NSButton BtnBuscar;
        private Controles.NSTextBox TxtBuscar;
        private System.Windows.Forms.Label label1;
    }
}
