namespace DataFlex
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
            this.txtConnString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gvResult = new System.Windows.Forms.DataGridView();
            this.btnTestConn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSql = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblMsj = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaxRowCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTabla = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtConnString
            // 
            this.txtConnString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConnString.Location = new System.Drawing.Point(101, 13);
            this.txtConnString.Name = "txtConnString";
            this.txtConnString.Size = new System.Drawing.Size(578, 20);
            this.txtConnString.TabIndex = 0;
            this.txtConnString.Text = "DSN=DataFlex Data32; DBQ = .; SERVER = NotTheServer; DRIVER = DataFlex Driver";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connection String:";
            // 
            // gvResult
            // 
            this.gvResult.AllowUserToAddRows = false;
            this.gvResult.AllowUserToDeleteRows = false;
            this.gvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvResult.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvResult.Location = new System.Drawing.Point(3, 159);
            this.gvResult.Name = "gvResult";
            this.gvResult.Size = new System.Drawing.Size(882, 439);
            this.gvResult.TabIndex = 2;
            // 
            // btnTestConn
            // 
            this.btnTestConn.Location = new System.Drawing.Point(685, 13);
            this.btnTestConn.Name = "btnTestConn";
            this.btnTestConn.Size = new System.Drawing.Size(113, 23);
            this.btnTestConn.TabIndex = 3;
            this.btnTestConn.Text = "Test Connection";
            this.btnTestConn.UseVisualStyleBackColor = true;
            this.btnTestConn.Click += new System.EventHandler(this.btnTestConn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SQL Query:";
            // 
            // txtSql
            // 
            this.txtSql.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSql.Location = new System.Drawing.Point(101, 50);
            this.txtSql.Multiline = true;
            this.txtSql.Name = "txtSql";
            this.txtSql.Size = new System.Drawing.Size(578, 46);
            this.txtSql.TabIndex = 4;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(685, 50);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(113, 23);
            this.btnExecute.TabIndex = 3;
            this.btnExecute.Text = "Execute SQL Query";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(220, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(125, 23);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export Table to CSV";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblMsj
            // 
            this.lblMsj.AutoSize = true;
            this.lblMsj.Location = new System.Drawing.Point(685, 99);
            this.lblMsj.Name = "lblMsj";
            this.lblMsj.Size = new System.Drawing.Size(35, 13);
            this.lblMsj.TabIndex = 6;
            this.lblMsj.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "MaxRowCount:";
            // 
            // txtMaxRowCount
            // 
            this.txtMaxRowCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaxRowCount.Location = new System.Drawing.Point(455, 3);
            this.txtMaxRowCount.Name = "txtMaxRowCount";
            this.txtMaxRowCount.Size = new System.Drawing.Size(120, 20);
            this.txtMaxRowCount.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Table:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbTabla
            // 
            this.cbTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTabla.FormattingEnabled = true;
            this.cbTabla.Items.AddRange(new object[] {
            "DEFAULTS",
            "NPROXIMO",
            "PRODUCTO",
            "INGENIO",
            "BODEGA",
            "BOD_ORIG (Master Alias BODEGA)",
            "BOD_DEST (Alias BODEGA)",
            "PRESENTA",
            "FLETE",
            "PILOTO",
            "PLACAS",
            "EXXPRO",
            "EXXPRE",
            "EXXPREOR (Master alias EXXPRE)",
            "EXXPREDE (Alias EXXPRE)",
            "EXXEST",
            "EXXESTOR (Master Alias EXXEST)",
            "EXXESTDE (Alias EXXEST)",
            "AUT_TRSH",
            "AUT_TRSD",
            "CONVENIO",
            "CONV_DET",
            "ORD_TRS",
            "CONV_ORI",
            "INF_BOD",
            "TIPO_EGR",
            "DESP_TRS",
            "INF_REC",
            "REC_TRS",
            "TIPO_EVE",
            "DIAS_LEY",
            "TIPO_ING",
            "INF_INGR",
            "ING_PROD",
            "NOTAS_PR",
            "ZAFRA",
            "QPROXING",
            "NOTAS_QU",
            "QPROXPRO",
            "QPRCIXFC",
            "QPREXXFC",
            "QPROPROY",
            "CTLVAXIN",
            "ENV_VITA",
            "ENVVITAD",
            "NOTAS_VA",
            "PPTO_VA",
            "PPTOVA_D",
            "TURNOS",
            "CTL_PESO",
            "CTLPESOD",
            "ANLSS_VA",
            "POL",
            "LOADCOM2",
            "WK_CNC1",
            "WK_CNC2",
            "INFREC0",
            "RECTRS0",
            "INFBOD0",
            "DESPTRS0",
            "INFINGR0",
            "INGPROD0",
            "CTLPESH0",
            "CTLPESD0",
            "WK_DESP",
            "WKBP9601",
            "FACT_COM",
            "LOAD_EXP (D:)",
            "WKRPR11B",
            "LOAD_COM (D:)",
            "LOADWKEX",
            "LOADCCUA D: Cuadre x Día Cometro",
            "WKRPR11A",
            "CUM_EX",
            "WK_TRS2",
            "WK_TRS",
            "WK_CONV",
            "WK_CUOTA",
            "ERRCUACO Workfile errores cuadre",
            "WKEXCEL1 (D:) Archivo Trabajo",
            "WK_EXIS",
            "NOTAS_EX",
            "WK_EXIS2",
            "WKEXXDIA",
            "ACCESOS",
            "WK_EXIS3",
            "WK_CONCI",
            "WK_TRANS",
            "CONV_COM",
            "WKFACTRN"});
            this.cbTabla.Location = new System.Drawing.Point(3, 3);
            this.cbTabla.Name = "cbTabla";
            this.cbTabla.Size = new System.Drawing.Size(211, 21);
            this.cbTabla.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.76451F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.23549F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.tableLayoutPanel1.Controls.Add(this.lblMsj, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtConnString, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtSql, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnTestConn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnExecute, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.34615F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.65385F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(882, 150);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.94891F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.05109F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel2.Controls.Add(this.cbTabla, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtMaxRowCount, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnExport, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(101, 102);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(578, 40);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.gvResult, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.95674F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.04326F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(888, 601);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 601);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "Form1";
            this.Text = "DataFlex";
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConnString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvResult;
        private System.Windows.Forms.Button btnTestConn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSql;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblMsj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaxRowCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTabla;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}

