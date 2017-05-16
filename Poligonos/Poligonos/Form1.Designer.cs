namespace Poligonos
{
    partial class Form1
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
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.MenuTab = new System.Windows.Forms.TabControl();
            this.tabPoligonos = new System.Windows.Forms.TabPage();
            this.pictureBoxCor = new System.Windows.Forms.PictureBox();
            this.btnPintar = new System.Windows.Forms.Button();
            this.btnCor = new System.Windows.Forms.Button();
            this.LBPoligono = new System.Windows.Forms.ListBox();
            this.DGVPontos = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPontos = new System.Windows.Forms.Label();
            this.lblPolig = new System.Windows.Forms.Label();
            this.tabTrans2D = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFlipVH = new System.Windows.Forms.Button();
            this.btnFlipH = new System.Windows.Forms.Button();
            this.btnFlipV = new System.Windows.Forms.Button();
            this.btnCisalhamento = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAngulo = new System.Windows.Forms.TextBox();
            this.btnRotacionar = new System.Windows.Forms.Button();
            this.btnEscalar = new System.Windows.Forms.Button();
            this.btnTransladar = new System.Windows.Forms.Button();
            this.txtY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtYP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtXP = new System.Windows.Forms.TextBox();
            this.rbP = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbO = new System.Windows.Forms.RadioButton();
            this.btnResetar = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnPintarScan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            this.MenuTab.SuspendLayout();
            this.tabPoligonos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPontos)).BeginInit();
            this.tabTrans2D.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxSearch
            // 
            this.pictureBoxSearch.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxSearch.Name = "pictureBoxSearch";
            this.pictureBoxSearch.Size = new System.Drawing.Size(754, 592);
            this.pictureBoxSearch.TabIndex = 0;
            this.pictureBoxSearch.TabStop = false;
            this.pictureBoxSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSearch_MouseClick);
            this.pictureBoxSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSearch_MouseDoubleClick);
            // 
            // MenuTab
            // 
            this.MenuTab.Controls.Add(this.tabPoligonos);
            this.MenuTab.Controls.Add(this.tabTrans2D);
            this.MenuTab.Location = new System.Drawing.Point(772, 12);
            this.MenuTab.Name = "MenuTab";
            this.MenuTab.SelectedIndex = 0;
            this.MenuTab.Size = new System.Drawing.Size(199, 592);
            this.MenuTab.TabIndex = 1;
            // 
            // tabPoligonos
            // 
            this.tabPoligonos.Controls.Add(this.btnPintarScan);
            this.tabPoligonos.Controls.Add(this.pictureBoxCor);
            this.tabPoligonos.Controls.Add(this.btnPintar);
            this.tabPoligonos.Controls.Add(this.btnCor);
            this.tabPoligonos.Controls.Add(this.LBPoligono);
            this.tabPoligonos.Controls.Add(this.DGVPontos);
            this.tabPoligonos.Controls.Add(this.lblPontos);
            this.tabPoligonos.Controls.Add(this.lblPolig);
            this.tabPoligonos.Location = new System.Drawing.Point(4, 22);
            this.tabPoligonos.Name = "tabPoligonos";
            this.tabPoligonos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPoligonos.Size = new System.Drawing.Size(191, 566);
            this.tabPoligonos.TabIndex = 0;
            this.tabPoligonos.Text = "Polígonos";
            this.tabPoligonos.UseVisualStyleBackColor = true;
            // 
            // pictureBoxCor
            // 
            this.pictureBoxCor.Location = new System.Drawing.Point(151, 19);
            this.pictureBoxCor.Name = "pictureBoxCor";
            this.pictureBoxCor.Size = new System.Drawing.Size(22, 23);
            this.pictureBoxCor.TabIndex = 8;
            this.pictureBoxCor.TabStop = false;
            // 
            // btnPintar
            // 
            this.btnPintar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPintar.Location = new System.Drawing.Point(116, 49);
            this.btnPintar.Name = "btnPintar";
            this.btnPintar.Size = new System.Drawing.Size(69, 23);
            this.btnPintar.TabIndex = 7;
            this.btnPintar.Text = "Pintar FF";
            this.btnPintar.UseVisualStyleBackColor = true;
            this.btnPintar.Click += new System.EventHandler(this.btnPintar_Click);
            // 
            // btnCor
            // 
            this.btnCor.Location = new System.Drawing.Point(115, 19);
            this.btnCor.Name = "btnCor";
            this.btnCor.Size = new System.Drawing.Size(35, 23);
            this.btnCor.TabIndex = 3;
            this.btnCor.Text = "Cor";
            this.btnCor.UseVisualStyleBackColor = true;
            this.btnCor.Click += new System.EventHandler(this.btnCor_Click);
            // 
            // LBPoligono
            // 
            this.LBPoligono.FormattingEnabled = true;
            this.LBPoligono.Location = new System.Drawing.Point(9, 19);
            this.LBPoligono.Name = "LBPoligono";
            this.LBPoligono.Size = new System.Drawing.Size(100, 160);
            this.LBPoligono.TabIndex = 6;
            this.LBPoligono.SelectedIndexChanged += new System.EventHandler(this.LBPoligono_SelectedIndexChanged);
            // 
            // DGVPontos
            // 
            this.DGVPontos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPontos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.DGVPontos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DGVPontos.Location = new System.Drawing.Point(6, 241);
            this.DGVPontos.MultiSelect = false;
            this.DGVPontos.Name = "DGVPontos";
            this.DGVPontos.RowHeadersVisible = false;
            this.DGVPontos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DGVPontos.Size = new System.Drawing.Size(103, 319);
            this.DGVPontos.TabIndex = 4;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            this.Y.Width = 50;
            // 
            // lblPontos
            // 
            this.lblPontos.AutoSize = true;
            this.lblPontos.Location = new System.Drawing.Point(6, 225);
            this.lblPontos.Name = "lblPontos";
            this.lblPontos.Size = new System.Drawing.Size(40, 13);
            this.lblPontos.TabIndex = 1;
            this.lblPontos.Text = "Pontos";
            // 
            // lblPolig
            // 
            this.lblPolig.AutoSize = true;
            this.lblPolig.Location = new System.Drawing.Point(6, 3);
            this.lblPolig.Name = "lblPolig";
            this.lblPolig.Size = new System.Drawing.Size(55, 13);
            this.lblPolig.TabIndex = 0;
            this.lblPolig.Text = "Polígonos";
            // 
            // tabTrans2D
            // 
            this.tabTrans2D.Controls.Add(this.groupBox2);
            this.tabTrans2D.Controls.Add(this.groupBox1);
            this.tabTrans2D.Location = new System.Drawing.Point(4, 22);
            this.tabTrans2D.Name = "tabTrans2D";
            this.tabTrans2D.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrans2D.Size = new System.Drawing.Size(191, 566);
            this.tabTrans2D.TabIndex = 1;
            this.tabTrans2D.Text = "Trans. 2D";
            this.tabTrans2D.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFlipVH);
            this.groupBox2.Controls.Add(this.btnFlipH);
            this.groupBox2.Controls.Add(this.btnFlipV);
            this.groupBox2.Controls.Add(this.btnCisalhamento);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtAngulo);
            this.groupBox2.Controls.Add(this.btnRotacionar);
            this.groupBox2.Controls.Add(this.btnEscalar);
            this.groupBox2.Controls.Add(this.btnTransladar);
            this.groupBox2.Controls.Add(this.txtY);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtX);
            this.groupBox2.Location = new System.Drawing.Point(7, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 193);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transformações";
            // 
            // btnFlipVH
            // 
            this.btnFlipVH.Location = new System.Drawing.Point(51, 158);
            this.btnFlipVH.Name = "btnFlipVH";
            this.btnFlipVH.Size = new System.Drawing.Size(67, 23);
            this.btnFlipVH.TabIndex = 13;
            this.btnFlipVH.Text = "Flip V + H";
            this.btnFlipVH.UseVisualStyleBackColor = true;
            this.btnFlipVH.Click += new System.EventHandler(this.btnFlipVH_Click);
            // 
            // btnFlipH
            // 
            this.btnFlipH.Location = new System.Drawing.Point(86, 129);
            this.btnFlipH.Name = "btnFlipH";
            this.btnFlipH.Size = new System.Drawing.Size(67, 23);
            this.btnFlipH.TabIndex = 12;
            this.btnFlipH.Text = "Flip H";
            this.btnFlipH.UseVisualStyleBackColor = true;
            this.btnFlipH.Click += new System.EventHandler(this.btnFlipH_Click);
            // 
            // btnFlipV
            // 
            this.btnFlipV.Location = new System.Drawing.Point(10, 129);
            this.btnFlipV.Name = "btnFlipV";
            this.btnFlipV.Size = new System.Drawing.Size(67, 23);
            this.btnFlipV.TabIndex = 11;
            this.btnFlipV.Text = "Flip V";
            this.btnFlipV.UseVisualStyleBackColor = true;
            this.btnFlipV.Click += new System.EventHandler(this.btnFlipV_Click);
            // 
            // btnCisalhamento
            // 
            this.btnCisalhamento.Location = new System.Drawing.Point(47, 71);
            this.btnCisalhamento.Name = "btnCisalhamento";
            this.btnCisalhamento.Size = new System.Drawing.Size(84, 23);
            this.btnCisalhamento.TabIndex = 10;
            this.btnCisalhamento.Text = "Cisalhamento";
            this.btnCisalhamento.UseVisualStyleBackColor = true;
            this.btnCisalhamento.Click += new System.EventHandler(this.btnCisalhamento_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ângulo";
            // 
            // txtAngulo
            // 
            this.txtAngulo.Location = new System.Drawing.Point(51, 100);
            this.txtAngulo.Name = "txtAngulo";
            this.txtAngulo.Size = new System.Drawing.Size(32, 20);
            this.txtAngulo.TabIndex = 8;
            // 
            // btnRotacionar
            // 
            this.btnRotacionar.Location = new System.Drawing.Point(89, 100);
            this.btnRotacionar.Name = "btnRotacionar";
            this.btnRotacionar.Size = new System.Drawing.Size(75, 23);
            this.btnRotacionar.TabIndex = 7;
            this.btnRotacionar.Text = "Rotacionar";
            this.btnRotacionar.UseVisualStyleBackColor = true;
            this.btnRotacionar.Click += new System.EventHandler(this.btnRotacionar_Click);
            // 
            // btnEscalar
            // 
            this.btnEscalar.Location = new System.Drawing.Point(95, 42);
            this.btnEscalar.Name = "btnEscalar";
            this.btnEscalar.Size = new System.Drawing.Size(75, 23);
            this.btnEscalar.TabIndex = 6;
            this.btnEscalar.Text = "Escalar";
            this.btnEscalar.UseVisualStyleBackColor = true;
            this.btnEscalar.Click += new System.EventHandler(this.btnEscalar_Click);
            // 
            // btnTransladar
            // 
            this.btnTransladar.Location = new System.Drawing.Point(8, 42);
            this.btnTransladar.Name = "btnTransladar";
            this.btnTransladar.Size = new System.Drawing.Size(75, 23);
            this.btnTransladar.TabIndex = 5;
            this.btnTransladar.Text = "Transladar";
            this.btnTransladar.UseVisualStyleBackColor = true;
            this.btnTransladar.Click += new System.EventHandler(this.btnTransladar_Click);
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(112, 16);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(50, 20);
            this.txtY.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(25, 16);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(50, 20);
            this.txtX.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtYP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtXP);
            this.groupBox1.Controls.Add(this.rbP);
            this.groupBox1.Controls.Add(this.rbC);
            this.groupBox1.Controls.Add(this.rbO);
            this.groupBox1.Location = new System.Drawing.Point(7, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 92);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transformação em relação a:";
            // 
            // txtYP
            // 
            this.txtYP.Location = new System.Drawing.Point(141, 60);
            this.txtYP.Name = "txtYP";
            this.txtYP.Size = new System.Drawing.Size(23, 20);
            this.txtYP.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "X";
            // 
            // txtXP
            // 
            this.txtXP.Location = new System.Drawing.Point(86, 60);
            this.txtXP.Name = "txtXP";
            this.txtXP.Size = new System.Drawing.Size(23, 20);
            this.txtXP.TabIndex = 13;
            // 
            // rbP
            // 
            this.rbP.AutoSize = true;
            this.rbP.Location = new System.Drawing.Point(10, 61);
            this.rbP.Name = "rbP";
            this.rbP.Size = new System.Drawing.Size(53, 17);
            this.rbP.TabIndex = 12;
            this.rbP.Text = "Ponto";
            this.rbP.UseVisualStyleBackColor = true;
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Checked = true;
            this.rbC.Location = new System.Drawing.Point(10, 38);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(56, 17);
            this.rbC.TabIndex = 11;
            this.rbC.TabStop = true;
            this.rbC.Text = "Centro";
            this.rbC.UseVisualStyleBackColor = true;
            // 
            // rbO
            // 
            this.rbO.AutoSize = true;
            this.rbO.Location = new System.Drawing.Point(10, 15);
            this.rbO.Name = "rbO";
            this.rbO.Size = new System.Drawing.Size(58, 17);
            this.rbO.TabIndex = 10;
            this.rbO.Text = "Origem";
            this.rbO.UseVisualStyleBackColor = true;
            // 
            // btnResetar
            // 
            this.btnResetar.Location = new System.Drawing.Point(12, 610);
            this.btnResetar.Name = "btnResetar";
            this.btnResetar.Size = new System.Drawing.Size(75, 23);
            this.btnResetar.TabIndex = 2;
            this.btnResetar.Text = "Limpar";
            this.btnResetar.UseVisualStyleBackColor = true;
            this.btnResetar.Click += new System.EventHandler(this.btnResetar_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.ShowHelp = true;
            this.colorDialog1.SolidColorOnly = true;
            // 
            // btnPintarScan
            // 
            this.btnPintarScan.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPintarScan.Location = new System.Drawing.Point(116, 78);
            this.btnPintarScan.Name = "btnPintarScan";
            this.btnPintarScan.Size = new System.Drawing.Size(69, 23);
            this.btnPintarScan.TabIndex = 9;
            this.btnPintarScan.Text = "Pintar SC";
            this.btnPintarScan.UseVisualStyleBackColor = true;
            this.btnPintarScan.Click += new System.EventHandler(this.btnPintarScan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 693);
            this.Controls.Add(this.btnResetar);
            this.Controls.Add(this.MenuTab);
            this.Controls.Add(this.pictureBoxSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            this.MenuTab.ResumeLayout(false);
            this.tabPoligonos.ResumeLayout(false);
            this.tabPoligonos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPontos)).EndInit();
            this.tabTrans2D.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.TabControl MenuTab;
        private System.Windows.Forms.TabPage tabTrans2D;
        private System.Windows.Forms.Button btnResetar;
        private System.Windows.Forms.TabPage tabPoligonos;
        private System.Windows.Forms.Label lblPontos;
        private System.Windows.Forms.Label lblPolig;
        private System.Windows.Forms.DataGridView DGVPontos;
        private System.Windows.Forms.ListBox LBPoligono;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.Button btnRotacionar;
        private System.Windows.Forms.Button btnEscalar;
        private System.Windows.Forms.Button btnTransladar;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAngulo;
        private System.Windows.Forms.TextBox txtYP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtXP;
        private System.Windows.Forms.RadioButton rbP;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbO;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCisalhamento;
        private System.Windows.Forms.Button btnFlipVH;
        private System.Windows.Forms.Button btnFlipH;
        private System.Windows.Forms.Button btnFlipV;
        private System.Windows.Forms.Button btnCor;
        public System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnPintar;
        private System.Windows.Forms.PictureBox pictureBoxCor;
        private System.Windows.Forms.Button btnPintarScan;
    }
}

