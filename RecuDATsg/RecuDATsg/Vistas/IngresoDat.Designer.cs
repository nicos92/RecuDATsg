namespace RecuDATsg.Vistas
{
    partial class IngresoDat
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresoDat));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ComBoxSectores = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.ErrorSector = new System.Windows.Forms.ErrorProvider(this.components);
            this.ProgressBarTop = new Controles.NSProgressBar();
            this.BtnIngresar = new Controles.NSButton();
            this.TxtCartelError = new Controles.NSTextBox();
            this.TxtArchivo = new Controles.NSTextBox();
            this.TxtObservacion = new Controles.NSTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorSector)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.LblTitulo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnIngresar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(634, 461);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblTitulo.Location = new System.Drawing.Point(180, 16);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(16);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(274, 25);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "INGRESO ARCHIVO DAT";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 60);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(628, 317);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.TxtCartelError, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.TxtArchivo, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.ComBoxSectores, 0, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(308, 311);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(16, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(16, 16, 16, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sector:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(16, 16, 16, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Archivo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(16, 235);
            this.label3.Margin = new System.Windows.Forms.Padding(16, 16, 16, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cartel Error:";
            // 
            // ComBoxSectores
            // 
            this.ComBoxSectores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComBoxSectores.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComBoxSectores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.ComBoxSectores.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComBoxSectores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComBoxSectores.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComBoxSectores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ComBoxSectores.FormattingEnabled = true;
            this.ComBoxSectores.Location = new System.Drawing.Point(8, 161);
            this.ComBoxSectores.Margin = new System.Windows.Forms.Padding(8, 8, 32, 8);
            this.ComBoxSectores.Name = "ComBoxSectores";
            this.ComBoxSectores.Size = new System.Drawing.Size(268, 26);
            this.ComBoxSectores.TabIndex = 2;
            this.ComBoxSectores.TextChanged += new System.EventHandler(this.ComBoxSectores_TextChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.TxtObservacion, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(317, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(308, 311);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(16, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Observaciones:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // ErrorSector
            // 
            this.ErrorSector.ContainerControl = this;
            this.ErrorSector.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorSector.Icon")));
            // 
            // ProgressBarTop
            // 
            this.ProgressBarTop.ChannelColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.ProgressBarTop.ChannelHeight = 8;
            this.ProgressBarTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProgressBarTop.ForeBackColor = System.Drawing.Color.PaleVioletRed;
            this.ProgressBarTop.ForeColor = System.Drawing.Color.White;
            this.ProgressBarTop.Location = new System.Drawing.Point(0, 0);
            this.ProgressBarTop.Margin = new System.Windows.Forms.Padding(0);
            this.ProgressBarTop.Name = "ProgressBarTop";
            this.ProgressBarTop.ShowMaximun = false;
            this.ProgressBarTop.ShowValue = Controles.MiTextPosition.None;
            this.ProgressBarTop.Size = new System.Drawing.Size(634, 8);
            this.ProgressBarTop.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.ProgressBarTop.Sliderheight = 8;
            this.ProgressBarTop.SymbolAfter = "";
            this.ProgressBarTop.SymbolBefore = "";
            this.ProgressBarTop.TabIndex = 4;
            this.ProgressBarTop.Visible = false;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.BtnIngresar.BackGroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.BtnIngresar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnIngresar.BorderRadius = 40;
            this.BtnIngresar.BorderSize = 0;
            this.BtnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIngresar.Enabled = false;
            this.BtnIngresar.FlatAppearance.BorderSize = 0;
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.BtnIngresar.Location = new System.Drawing.Point(242, 396);
            this.BtnIngresar.Margin = new System.Windows.Forms.Padding(16);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(150, 49);
            this.BtnIngresar.TabIndex = 5;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.EnabledChanged += new System.EventHandler(this.BtnIngresar_EnabledChanged);
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // TxtCartelError
            // 
            this.TxtCartelError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.TxtCartelError.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.TxtCartelError.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.TxtCartelError.BorderSize = 2;
            this.TxtCartelError.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtCartelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCartelError.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TxtCartelError.Location = new System.Drawing.Point(8, 263);
            this.TxtCartelError.Margin = new System.Windows.Forms.Padding(8, 8, 32, 8);
            this.TxtCartelError.MaxLenght = 32767;
            this.TxtCartelError.Multiline = false;
            this.TxtCartelError.Name = "TxtCartelError";
            this.TxtCartelError.Padding = new System.Windows.Forms.Padding(7);
            this.TxtCartelError.PasswordChar = false;
            this.TxtCartelError.ReadOnly = false;
            this.TxtCartelError.Size = new System.Drawing.Size(268, 35);
            this.TxtCartelError.TabIndex = 3;
            this.TxtCartelError.UnderLinesStyle = false;
            this.TxtCartelError._TextChanged += new System.EventHandler(this.TxtCartelError__TextChanged);
            // 
            // TxtArchivo
            // 
            this.TxtArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.TxtArchivo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.TxtArchivo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.TxtArchivo.BorderSize = 2;
            this.TxtArchivo.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtArchivo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TxtArchivo.Location = new System.Drawing.Point(8, 59);
            this.TxtArchivo.Margin = new System.Windows.Forms.Padding(8, 8, 32, 8);
            this.TxtArchivo.MaxLenght = 32767;
            this.TxtArchivo.Multiline = false;
            this.TxtArchivo.Name = "TxtArchivo";
            this.TxtArchivo.Padding = new System.Windows.Forms.Padding(7);
            this.TxtArchivo.PasswordChar = false;
            this.TxtArchivo.ReadOnly = false;
            this.TxtArchivo.Size = new System.Drawing.Size(268, 35);
            this.TxtArchivo.TabIndex = 1;
            this.TxtArchivo.UnderLinesStyle = false;
            this.TxtArchivo._TextChanged += new System.EventHandler(this.TxtArchivo__TextChanged);
            // 
            // TxtObservacion
            // 
            this.TxtObservacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.TxtObservacion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.TxtObservacion.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.TxtObservacion.BorderSize = 2;
            this.TxtObservacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtObservacion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TxtObservacion.Location = new System.Drawing.Point(16, 60);
            this.TxtObservacion.Margin = new System.Windows.Forms.Padding(16, 8, 16, 12);
            this.TxtObservacion.MaxLenght = 256;
            this.TxtObservacion.Multiline = true;
            this.TxtObservacion.Name = "TxtObservacion";
            this.TxtObservacion.Padding = new System.Windows.Forms.Padding(7);
            this.TxtObservacion.PasswordChar = false;
            this.TxtObservacion.ReadOnly = false;
            this.TxtObservacion.Size = new System.Drawing.Size(276, 239);
            this.TxtObservacion.TabIndex = 4;
            this.TxtObservacion.UnderLinesStyle = false;
            this.TxtObservacion._TextChanged += new System.EventHandler(this.TxtObservacion__TextChanged);
            // 
            // IngresoDat
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.ProgressBarTop);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "IngresoDat";
            this.Size = new System.Drawing.Size(634, 461);
            this.Load += new System.EventHandler(this.IngresoDat_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorSector)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LblTitulo;
        private Controles.NSButton BtnIngresar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private Controles.NSTextBox TxtArchivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Controles.NSTextBox TxtCartelError;
        private Controles.NSProgressBar ProgressBarTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label4;
        private Controles.NSTextBox TxtObservacion;
        private System.Windows.Forms.ComboBox ComBoxSectores;
        private System.Windows.Forms.ErrorProvider ErrorSector;
    }
}
