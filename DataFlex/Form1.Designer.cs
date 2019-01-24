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
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConnString
            // 
            this.txtConnString.Location = new System.Drawing.Point(143, 22);
            this.txtConnString.Name = "txtConnString";
            this.txtConnString.Size = new System.Drawing.Size(599, 20);
            this.txtConnString.TabIndex = 0;
            this.txtConnString.Text = "DSN=DataFlex Data32; DBQ = .; SERVER = NotTheServer; DRIVER = DataFlex Driver";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connection String:";
            // 
            // gvResult
            // 
            this.gvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvResult.Location = new System.Drawing.Point(15, 229);
            this.gvResult.Name = "gvResult";
            this.gvResult.Size = new System.Drawing.Size(858, 360);
            this.gvResult.TabIndex = 2;
            // 
            // btnTestConn
            // 
            this.btnTestConn.Location = new System.Drawing.Point(760, 19);
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
            this.label2.Location = new System.Drawing.Point(10, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SQL Query:";
            // 
            // txtSql
            // 
            this.txtSql.Location = new System.Drawing.Point(143, 48);
            this.txtSql.Multiline = true;
            this.txtSql.Name = "txtSql";
            this.txtSql.Size = new System.Drawing.Size(599, 90);
            this.txtSql.TabIndex = 4;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(760, 48);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(113, 23);
            this.btnExecute.TabIndex = 3;
            this.btnExecute.Text = "Execute SQL Query";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(270, 153);
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
            this.lblMsj.Location = new System.Drawing.Point(642, 163);
            this.lblMsj.Name = "lblMsj";
            this.lblMsj.Size = new System.Drawing.Size(35, 13);
            this.lblMsj.TabIndex = 6;
            this.lblMsj.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "MaxRowCount:";
            // 
            // txtMaxRowCount
            // 
            this.txtMaxRowCount.Location = new System.Drawing.Point(511, 154);
            this.txtMaxRowCount.Name = "txtMaxRowCount";
            this.txtMaxRowCount.Size = new System.Drawing.Size(100, 20);
            this.txtMaxRowCount.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Table:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbTabla
            // 
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
            this.cbTabla.Location = new System.Drawing.Point(143, 153);
            this.cbTabla.Name = "cbTabla";
            this.cbTabla.Size = new System.Drawing.Size(121, 21);
            this.cbTabla.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 601);
            this.Controls.Add(this.cbTabla);
            this.Controls.Add(this.txtMaxRowCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMsj);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtSql);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.btnTestConn);
            this.Controls.Add(this.gvResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConnString);
            this.Name = "Form1";
            this.Text = "DataFlex";
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).EndInit();
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
    }
}

