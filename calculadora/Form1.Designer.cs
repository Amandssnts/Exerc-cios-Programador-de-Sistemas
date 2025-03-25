
namespace WindowsFormsApp1
{
    partial class frmCalculadora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lblPonto = new System.Windows.Forms.Label();
            this.lbl0 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lblIgual = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.lblMais = new System.Windows.Forms.Label();
            this.lblMenos = new System.Windows.Forms.Label();
            this.lblMultiplicar = new System.Windows.Forms.Label();
            this.lblDividir = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblSinal = new System.Windows.Forms.Label();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.lblValor1 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lbl5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPonto, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl0, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl9, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblIgual, 2, 3);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-5, 162);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.28986F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.56522F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 310);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl5
            // 
            this.lbl5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl5.AutoSize = true;
            this.lbl5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.ForeColor = System.Drawing.Color.White;
            this.lbl5.Location = new System.Drawing.Point(125, 99);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(32, 33);
            this.lbl5.TabIndex = 7;
            this.lbl5.Text = "5";
            this.lbl5.Click += new System.EventHandler(this.lbl5_Click);
            // 
            // lblPonto
            // 
            this.lblPonto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPonto.AutoSize = true;
            this.lblPonto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPonto.ForeColor = System.Drawing.Color.White;
            this.lblPonto.Location = new System.Drawing.Point(129, 252);
            this.lblPonto.Name = "lblPonto";
            this.lblPonto.Size = new System.Drawing.Size(24, 33);
            this.lblPonto.TabIndex = 3;
            this.lblPonto.Text = ".";
            this.lblPonto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPonto.Click += new System.EventHandler(this.lblPonto_Click);
            // 
            // lbl0
            // 
            this.lbl0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl0.AutoSize = true;
            this.lbl0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl0.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0.ForeColor = System.Drawing.Color.White;
            this.lbl0.Location = new System.Drawing.Point(32, 252);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(32, 33);
            this.lbl0.TabIndex = 2;
            this.lbl0.Text = "0";
            this.lbl0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl0.Click += new System.EventHandler(this.lbl0_Click);
            // 
            // lbl1
            // 
            this.lbl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl1.AutoSize = true;
            this.lbl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl1.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(31, 174);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(34, 35);
            this.lbl1.TabIndex = 11;
            this.lbl1.Text = "1";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // lbl2
            // 
            this.lbl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl2.AutoSize = true;
            this.lbl2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.White;
            this.lbl2.Location = new System.Drawing.Point(125, 175);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(32, 33);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = "2";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl2.Click += new System.EventHandler(this.lbl2_Click);
            // 
            // lbl3
            // 
            this.lbl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl3.AutoSize = true;
            this.lbl3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.White;
            this.lbl3.Location = new System.Drawing.Point(219, 175);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(32, 33);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "3";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl3.Click += new System.EventHandler(this.lbl3_Click);
            // 
            // lbl4
            // 
            this.lbl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl4.AutoSize = true;
            this.lbl4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.ForeColor = System.Drawing.Color.White;
            this.lbl4.Location = new System.Drawing.Point(32, 99);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(32, 33);
            this.lbl4.TabIndex = 6;
            this.lbl4.Text = "4";
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl4.Click += new System.EventHandler(this.lbl4_Click);
            // 
            // lbl9
            // 
            this.lbl9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl9.AutoSize = true;
            this.lbl9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl9.ForeColor = System.Drawing.Color.White;
            this.lbl9.Location = new System.Drawing.Point(219, 23);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(32, 33);
            this.lbl9.TabIndex = 1;
            this.lbl9.Text = "9";
            this.lbl9.Click += new System.EventHandler(this.lbl9_Click);
            // 
            // lbl6
            // 
            this.lbl6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl6.AutoSize = true;
            this.lbl6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.ForeColor = System.Drawing.Color.White;
            this.lbl6.Location = new System.Drawing.Point(219, 99);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(32, 33);
            this.lbl6.TabIndex = 8;
            this.lbl6.Text = "6";
            this.lbl6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl6.Click += new System.EventHandler(this.lbl6_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(32, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 33);
            this.label7.TabIndex = 9;
            this.label7.Text = "7";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbl8
            // 
            this.lbl8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl8.AutoSize = true;
            this.lbl8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl8.ForeColor = System.Drawing.Color.White;
            this.lbl8.Location = new System.Drawing.Point(125, 23);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(32, 33);
            this.lbl8.TabIndex = 0;
            this.lbl8.Text = "8";
            this.lbl8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl8.Click += new System.EventHandler(this.lbl8_Click);
            // 
            // lblIgual
            // 
            this.lblIgual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIgual.AutoSize = true;
            this.lblIgual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIgual.ForeColor = System.Drawing.Color.White;
            this.lblIgual.Location = new System.Drawing.Point(218, 252);
            this.lblIgual.Name = "lblIgual";
            this.lblIgual.Size = new System.Drawing.Size(33, 33);
            this.lblIgual.TabIndex = 4;
            this.lblIgual.Text = "=";
            this.lblIgual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIgual.Click += new System.EventHandler(this.lblIgual_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Navy;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.lblCancelar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblMais, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblMenos, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblMultiplicar, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblDividir, 0, 3);
            this.tableLayoutPanel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel2.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(276, 162);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.19231F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.19231F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(102, 310);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblCancelar
            // 
            this.lblCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCancelar.AutoSize = true;
            this.lblCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelar.ForeColor = System.Drawing.Color.White;
            this.lblCancelar.Location = new System.Drawing.Point(32, 15);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(37, 33);
            this.lblCancelar.TabIndex = 4;
            this.lblCancelar.Text = "C";
            this.lblCancelar.Click += new System.EventHandler(this.lblCancelar_Click);
            // 
            // lblMais
            // 
            this.lblMais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMais.AutoSize = true;
            this.lblMais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMais.ForeColor = System.Drawing.Color.White;
            this.lblMais.Location = new System.Drawing.Point(34, 76);
            this.lblMais.Name = "lblMais";
            this.lblMais.Size = new System.Drawing.Size(33, 33);
            this.lblMais.TabIndex = 0;
            this.lblMais.Text = "+";
            this.lblMais.Click += new System.EventHandler(this.lblMais_Click);
            // 
            // lblMenos
            // 
            this.lblMenos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMenos.AutoSize = true;
            this.lblMenos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenos.ForeColor = System.Drawing.Color.White;
            this.lblMenos.Location = new System.Drawing.Point(38, 137);
            this.lblMenos.Name = "lblMenos";
            this.lblMenos.Size = new System.Drawing.Size(26, 33);
            this.lblMenos.TabIndex = 1;
            this.lblMenos.Text = "-";
            this.lblMenos.Click += new System.EventHandler(this.lblMenos_Click);
            // 
            // lblMultiplicar
            // 
            this.lblMultiplicar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMultiplicar.AutoSize = true;
            this.lblMultiplicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiplicar.ForeColor = System.Drawing.Color.White;
            this.lblMultiplicar.Location = new System.Drawing.Point(33, 260);
            this.lblMultiplicar.Name = "lblMultiplicar";
            this.lblMultiplicar.Size = new System.Drawing.Size(35, 33);
            this.lblMultiplicar.TabIndex = 3;
            this.lblMultiplicar.Text = "X";
            this.lblMultiplicar.Click += new System.EventHandler(this.lblMultiplicar_Click);
            // 
            // lblDividir
            // 
            this.lblDividir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDividir.AutoSize = true;
            this.lblDividir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDividir.ForeColor = System.Drawing.Color.White;
            this.lblDividir.Location = new System.Drawing.Point(39, 198);
            this.lblDividir.Name = "lblDividir";
            this.lblDividir.Size = new System.Drawing.Size(24, 33);
            this.lblDividir.TabIndex = 2;
            this.lblDividir.Text = "/";
            this.lblDividir.Click += new System.EventHandler(this.lblDividir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtResultado);
            this.panel1.Controls.Add(this.lblSinal);
            this.panel1.Controls.Add(this.lblValor2);
            this.panel1.Controls.Add(this.lblValor1);
            this.panel1.Controls.Add(this.lblResultado);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 162);
            this.panel1.TabIndex = 2;
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.Navy;
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.ForeColor = System.Drawing.Color.White;
            this.txtResultado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtResultado.Location = new System.Drawing.Point(12, 107);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtResultado.Size = new System.Drawing.Size(363, 42);
            this.txtResultado.TabIndex = 4;
            this.txtResultado.Text = "0";
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSinal
            // 
            this.lblSinal.AutoSize = true;
            this.lblSinal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinal.Location = new System.Drawing.Point(282, 58);
            this.lblSinal.Name = "lblSinal";
            this.lblSinal.Size = new System.Drawing.Size(22, 24);
            this.lblSinal.TabIndex = 3;
            this.lblSinal.Text = "+";
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblValor2.Location = new System.Drawing.Point(323, 58);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(21, 24);
            this.lblValor2.TabIndex = 2;
            this.lblValor2.Text = "0";
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblValor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblValor1.Location = new System.Drawing.Point(246, 58);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(21, 24);
            this.lblValor1.TabIndex = 1;
            this.lblValor1.Text = "0";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(314, 107);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 42);
            this.lblResultado.TabIndex = 0;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(378, 472);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmCalculadora";
            this.Text = "Calculadora";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.frmCalculadora_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lblIgual;
        private System.Windows.Forms.Label lblPonto;
        private System.Windows.Forms.Label lbl0;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lblCancelar;
        private System.Windows.Forms.Label lblMais;
        private System.Windows.Forms.Label lblMenos;
        private System.Windows.Forms.Label lblMultiplicar;
        private System.Windows.Forms.Label lblDividir;
        private System.Windows.Forms.Label lblSinal;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

