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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Copy = new Controles.NSButton();
            this.BtnRecover = new Controles.NSButton();
            this.PanelFill.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelFill
            // 
            this.PanelFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.PanelFill.Controls.Add(this.tableLayoutPanel1);
            this.PanelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFill.Location = new System.Drawing.Point(2, 2);
            this.PanelFill.Margin = new System.Windows.Forms.Padding(8);
            this.PanelFill.Name = "PanelFill";
            this.PanelFill.Padding = new System.Windows.Forms.Padding(16);
            this.PanelFill.Size = new System.Drawing.Size(630, 457);
            this.PanelFill.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(598, 425);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(34)))));
            this.TxtBuscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.TxtBuscar.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.TxtBuscar.BorderSize = 2;
            this.TxtBuscar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtBuscar.Location = new System.Drawing.Point(124, 16);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(16);
            this.TxtBuscar.Multiline = false;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Padding = new System.Windows.Forms.Padding(7);
            this.TxtBuscar.PasswordChar = false;
            this.TxtBuscar.Size = new System.Drawing.Size(350, 31);
            this.TxtBuscar.TabIndex = 0;
            this.TxtBuscar.UnderLinesStyle = false;
            this.TxtBuscar._TextChanged += new System.EventHandler(this.TxtBuscar__TextChanged);
            // 
            // ListViewDAT
            // 
            this.ListViewDAT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewDAT.HideSelection = false;
            this.ListViewDAT.Location = new System.Drawing.Point(16, 79);
            this.ListViewDAT.Margin = new System.Windows.Forms.Padding(16);
            this.ListViewDAT.Name = "ListViewDAT";
            this.ListViewDAT.Size = new System.Drawing.Size(566, 265);
            this.ListViewDAT.TabIndex = 1;
            this.ListViewDAT.UseCompatibleStateImageBehavior = false;
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 363);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(592, 59);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // Copy
            // 
            this.Copy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Copy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.Copy.BackGroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.Copy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.Copy.BorderRadius = 16;
            this.Copy.BorderSize = 2;
            this.Copy.FlatAppearance.BorderSize = 0;
            this.Copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Copy.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copy.ForeColor = System.Drawing.Color.White;
            this.Copy.Location = new System.Drawing.Point(121, 5);
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
            this.BtnRecover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.BtnRecover.BackGroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.BtnRecover.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.BtnRecover.BorderRadius = 16;
            this.BtnRecover.BorderSize = 2;
            this.BtnRecover.FlatAppearance.BorderSize = 0;
            this.BtnRecover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRecover.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRecover.ForeColor = System.Drawing.Color.White;
            this.BtnRecover.Location = new System.Drawing.Point(357, 5);
            this.BtnRecover.Name = "BtnRecover";
            this.BtnRecover.Size = new System.Drawing.Size(112, 48);
            this.BtnRecover.TabIndex = 5;
            this.BtnRecover.Text = "Recover1";
            this.BtnRecover.TextColor = System.Drawing.Color.White;
            this.BtnRecover.UseVisualStyleBackColor = false;
            this.BtnRecover.Click += new System.EventHandler(this.BtnRecover_Click);
            // 
            // BuscarDat
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.PanelFill);
            this.Name = "BuscarDat";
            this.Padding = new System.Windows.Forms.Padding(2);
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
    }
}
