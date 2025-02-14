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
            this.TxtBuscar = new Controles.NSTextBox();
            this.ListViewDAT = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Copy = new Controles.NSButton();
            this.BtnRecover = new Controles.NSButton();
            this.ProgressBarTop = new Controles.NSProgressBar();
            this.PanelFill.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelFill
            // 
            this.PanelFill.BackColor = System.Drawing.Color.White;
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
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.TxtBuscar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ListViewDAT, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
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
            // TxtBuscar
            // 
            this.TxtBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtBuscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.TxtBuscar.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.TxtBuscar.BorderSize = 2;
            this.TxtBuscar.Font = new System.Drawing.Font("SUSE", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.ForeColor = System.Drawing.Color.Black;
            this.TxtBuscar.Location = new System.Drawing.Point(126, 14);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(8);
            this.TxtBuscar.MaxLenght = 32;
            this.TxtBuscar.Multiline = false;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Padding = new System.Windows.Forms.Padding(7);
            this.TxtBuscar.PasswordChar = false;
            this.TxtBuscar.ReadOnly = false;
            this.TxtBuscar.Size = new System.Drawing.Size(350, 35);
            this.TxtBuscar.TabIndex = 1;
            this.TxtBuscar.UnderLinesStyle = true;
            this.TxtBuscar._TextChanged += new System.EventHandler(this.TxtBuscar__TextChanged);
            // 
            // ListViewDAT
            // 
            this.ListViewDAT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ListViewDAT.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.ListViewDAT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewDAT.Font = new System.Drawing.Font("SUSE", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListViewDAT.ForeColor = System.Drawing.Color.Black;
            this.ListViewDAT.FullRowSelect = true;
            this.ListViewDAT.HideSelection = false;
            this.ListViewDAT.Location = new System.Drawing.Point(16, 80);
            this.ListViewDAT.Margin = new System.Windows.Forms.Padding(16);
            this.ListViewDAT.MultiSelect = false;
            this.ListViewDAT.Name = "ListViewDAT";
            this.ListViewDAT.Size = new System.Drawing.Size(570, 268);
            this.ListViewDAT.TabIndex = 2;
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
            this.columnHeader2.Width = 86;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "SECTOR";
            this.columnHeader3.Width = 128;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ERROR";
            this.columnHeader4.Width = 128;
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
            // Copy
            // 
            this.Copy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Copy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(40)))), ((int)(((byte)(224)))));
            this.Copy.BackGroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(40)))), ((int)(((byte)(224)))));
            this.Copy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(194)))));
            this.Copy.BorderRadius = 16;
            this.Copy.BorderSize = 0;
            this.Copy.FlatAppearance.BorderSize = 0;
            this.Copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Copy.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copy.ForeColor = System.Drawing.Color.White;
            this.Copy.Location = new System.Drawing.Point(122, 5);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(112, 48);
            this.Copy.TabIndex = 3;
            this.Copy.Text = "Copy";
            this.Copy.TextColor = System.Drawing.Color.White;
            this.Copy.UseVisualStyleBackColor = false;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // BtnRecover
            // 
            this.BtnRecover.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnRecover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.BtnRecover.BackGroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.BtnRecover.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.BtnRecover.BorderRadius = 16;
            this.BtnRecover.BorderSize = 2;
            this.BtnRecover.FlatAppearance.BorderSize = 0;
            this.BtnRecover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRecover.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRecover.ForeColor = System.Drawing.Color.White;
            this.BtnRecover.Location = new System.Drawing.Point(360, 5);
            this.BtnRecover.Name = "BtnRecover";
            this.BtnRecover.Size = new System.Drawing.Size(112, 48);
            this.BtnRecover.TabIndex = 4;
            this.BtnRecover.Text = "Recover1";
            this.BtnRecover.TextColor = System.Drawing.Color.White;
            this.BtnRecover.UseVisualStyleBackColor = false;
            this.BtnRecover.Click += new System.EventHandler(this.BtnRecover_Click);
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
            // BuscarDat
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.ProgressBarTop);
            this.Controls.Add(this.PanelFill);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "BuscarDat";
            this.Size = new System.Drawing.Size(634, 461);
            this.Load += new System.EventHandler(this.BuscarDat_Load);
            this.PanelFill.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelFill;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Controles.NSTextBox TxtBuscar;
        private System.Windows.Forms.ListView ListViewDAT;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Controles.NSButton Copy;
        private Controles.NSButton BtnRecover;
        private Controles.NSProgressBar ProgressBarTop;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}
