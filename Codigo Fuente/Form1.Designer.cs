namespace CompiladorUtesa
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
            this.components = new System.ComponentModel.Container();
            this.Colorearletras = new System.Windows.Forms.Timer(this.components);
            this.fontSelectDialog = new System.Windows.Forms.FontDialog();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.erroresSemanticos = new System.Windows.Forms.RichTextBox();
            this.CCCode = new System.Windows.Forms.RichTextBox();
            this.Ccode = new System.Windows.Forms.RichTextBox();
            this.richErroresSintac = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CodigoMeedCompyTxt = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.varnumasig = new System.Windows.Forms.RichTextBox();
            this.richcadenas = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.varcadasig = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.richenteras = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.documentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.analisisSin = new System.Windows.Forms.RichTextBox();
            this.richsemantica = new System.Windows.Forms.RichTextBox();
            this.RIchTxLexico = new System.Windows.Forms.RichTextBox();
            this.richSi = new System.Windows.Forms.RichTextBox();
            this.richRepetir = new System.Windows.Forms.RichTextBox();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Colorearletras
            // 
            this.Colorearletras.Interval = 2000;
            this.Colorearletras.Tick += new System.EventHandler(this.ActualizarAnalisis_Tick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.analisisSin);
            this.panel4.Controls.Add(this.richsemantica);
            this.panel4.Controls.Add(this.RIchTxLexico);
            this.panel4.Controls.Add(this.richSi);
            this.panel4.Controls.Add(this.richRepetir);
            this.panel4.Controls.Add(this.btnEjecutar);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.erroresSemanticos);
            this.panel4.Controls.Add(this.CCCode);
            this.panel4.Controls.Add(this.Ccode);
            this.panel4.Controls.Add(this.richErroresSintac);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Location = new System.Drawing.Point(0, 87);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1798, 903);
            this.panel4.TabIndex = 49;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnEjecutar.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjecutar.Location = new System.Drawing.Point(1, 616);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(23, 42);
            this.btnEjecutar.TabIndex = 73;
            this.btnEjecutar.Text = ".";
            this.btnEjecutar.UseVisualStyleBackColor = false;
            this.btnEjecutar.Visible = false;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(598, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 42);
            this.button1.TabIndex = 72;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(1073, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 21);
            this.label3.TabIndex = 71;
            this.label3.Text = "Tabla de símbolos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(662, 482);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 21);
            this.label7.TabIndex = 70;
            this.label7.Text = "Errores Sintácticos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(366, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 21);
            this.label2.TabIndex = 69;
            this.label2.Text = "Errores Semánticos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(1488, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 21);
            this.label4.TabIndex = 68;
            this.label4.Text = "Analisis Sintáctico";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(937, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(158, 21);
            this.label14.TabIndex = 65;
            this.label14.Text = "Código intermedio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(246, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 21);
            this.label6.TabIndex = 64;
            this.label6.Text = "Escribe el código Aquí:";
            // 
            // erroresSemanticos
            // 
            this.erroresSemanticos.BackColor = System.Drawing.Color.Silver;
            this.erroresSemanticos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.erroresSemanticos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erroresSemanticos.ForeColor = System.Drawing.SystemColors.Desktop;
            this.erroresSemanticos.Location = new System.Drawing.Point(322, 506);
            this.erroresSemanticos.Name = "erroresSemanticos";
            this.erroresSemanticos.Size = new System.Drawing.Size(249, 67);
            this.erroresSemanticos.TabIndex = 49;
            this.erroresSemanticos.Text = "";
            // 
            // CCCode
            // 
            this.CCCode.BackColor = System.Drawing.Color.Black;
            this.CCCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CCCode.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCCode.ForeColor = System.Drawing.SystemColors.Info;
            this.CCCode.Location = new System.Drawing.Point(813, 50);
            this.CCCode.Name = "CCCode";
            this.CCCode.Size = new System.Drawing.Size(455, 129);
            this.CCCode.TabIndex = 43;
            this.CCCode.Text = "";
            this.CCCode.TextChanged += new System.EventHandler(this.CCCode_TextChanged);
            // 
            // Ccode
            // 
            this.Ccode.BackColor = System.Drawing.Color.Black;
            this.Ccode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Ccode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(74)))), ((int)(((byte)(64)))));
            this.Ccode.Location = new System.Drawing.Point(805, 43);
            this.Ccode.Name = "Ccode";
            this.Ccode.ReadOnly = true;
            this.Ccode.Size = new System.Drawing.Size(479, 144);
            this.Ccode.TabIndex = 39;
            this.Ccode.Text = "";
            this.Ccode.TextChanged += new System.EventHandler(this.Ccode_TextChanged);
            // 
            // richErroresSintac
            // 
            this.richErroresSintac.BackColor = System.Drawing.Color.Silver;
            this.richErroresSintac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richErroresSintac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richErroresSintac.ForeColor = System.Drawing.SystemColors.Desktop;
            this.richErroresSintac.Location = new System.Drawing.Point(598, 506);
            this.richErroresSintac.Name = "richErroresSintac";
            this.richErroresSintac.Size = new System.Drawing.Size(277, 67);
            this.richErroresSintac.TabIndex = 20;
            this.richErroresSintac.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.CodigoMeedCompyTxt);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(122, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(437, 143);
            this.panel2.TabIndex = 33;
            // 
            // CodigoMeedCompyTxt
            // 
            this.CodigoMeedCompyTxt.AutoWordSelection = true;
            this.CodigoMeedCompyTxt.BackColor = System.Drawing.Color.Silver;
            this.CodigoMeedCompyTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CodigoMeedCompyTxt.EnableAutoDragDrop = true;
            this.CodigoMeedCompyTxt.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoMeedCompyTxt.ForeColor = System.Drawing.SystemColors.Desktop;
            this.CodigoMeedCompyTxt.ImeMode = System.Windows.Forms.ImeMode.On;
            this.CodigoMeedCompyTxt.Location = new System.Drawing.Point(3, 3);
            this.CodigoMeedCompyTxt.Name = "CodigoMeedCompyTxt";
            this.CodigoMeedCompyTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CodigoMeedCompyTxt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.CodigoMeedCompyTxt.ShowSelectionMargin = true;
            this.CodigoMeedCompyTxt.Size = new System.Drawing.Size(425, 139);
            this.CodigoMeedCompyTxt.TabIndex = 1;
            this.CodigoMeedCompyTxt.TabStop = false;
            this.CodigoMeedCompyTxt.Text = "";
            this.CodigoMeedCompyTxt.TextChanged += new System.EventHandler(this.CodigoMeedCompyTxt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(136, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Variables #";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.varnumasig);
            this.panel1.Controls.Add(this.richcadenas);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.varcadasig);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.richenteras);
            this.panel1.Location = new System.Drawing.Point(941, 270);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 162);
            this.panel1.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(10, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "Tokens #";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(211, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 55;
            this.label13.Text = "Valores";
            // 
            // varnumasig
            // 
            this.varnumasig.AutoWordSelection = true;
            this.varnumasig.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.varnumasig.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.varnumasig.EnableAutoDragDrop = true;
            this.varnumasig.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varnumasig.ForeColor = System.Drawing.SystemColors.ControlText;
            this.varnumasig.ImeMode = System.Windows.Forms.ImeMode.On;
            this.varnumasig.Location = new System.Drawing.Point(13, 99);
            this.varnumasig.Name = "varnumasig";
            this.varnumasig.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.varnumasig.ShortcutsEnabled = false;
            this.varnumasig.Size = new System.Drawing.Size(162, 48);
            this.varnumasig.TabIndex = 35;
            this.varnumasig.TabStop = false;
            this.varnumasig.Text = "";
            this.varnumasig.WordWrap = false;
            this.varnumasig.TextChanged += new System.EventHandler(this.varnumasig_TextChanged);
            // 
            // richcadenas
            // 
            this.richcadenas.AutoWordSelection = true;
            this.richcadenas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.richcadenas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richcadenas.EnableAutoDragDrop = true;
            this.richcadenas.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richcadenas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.richcadenas.ImeMode = System.Windows.Forms.ImeMode.On;
            this.richcadenas.Location = new System.Drawing.Point(214, 25);
            this.richcadenas.Name = "richcadenas";
            this.richcadenas.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richcadenas.ShortcutsEnabled = false;
            this.richcadenas.Size = new System.Drawing.Size(162, 48);
            this.richcadenas.TabIndex = 31;
            this.richcadenas.TabStop = false;
            this.richcadenas.Text = "";
            this.richcadenas.WordWrap = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(10, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "Valores";
            // 
            // varcadasig
            // 
            this.varcadasig.AutoWordSelection = true;
            this.varcadasig.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.varcadasig.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.varcadasig.EnableAutoDragDrop = true;
            this.varcadasig.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varcadasig.ForeColor = System.Drawing.SystemColors.ControlText;
            this.varcadasig.ImeMode = System.Windows.Forms.ImeMode.On;
            this.varcadasig.Location = new System.Drawing.Point(214, 99);
            this.varcadasig.Name = "varcadasig";
            this.varcadasig.ShortcutsEnabled = false;
            this.varcadasig.Size = new System.Drawing.Size(162, 48);
            this.varcadasig.TabIndex = 36;
            this.varcadasig.TabStop = false;
            this.varcadasig.Text = "";
            this.varcadasig.WordWrap = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(218, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "Tokens @";
            // 
            // richenteras
            // 
            this.richenteras.AutoWordSelection = true;
            this.richenteras.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.richenteras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richenteras.EnableAutoDragDrop = true;
            this.richenteras.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richenteras.ForeColor = System.Drawing.SystemColors.ControlText;
            this.richenteras.ImeMode = System.Windows.Forms.ImeMode.On;
            this.richenteras.Location = new System.Drawing.Point(13, 25);
            this.richenteras.Name = "richenteras";
            this.richenteras.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richenteras.ShortcutsEnabled = false;
            this.richenteras.Size = new System.Drawing.Size(162, 48);
            this.richenteras.TabIndex = 30;
            this.richenteras.TabStop = false;
            this.richenteras.Text = "";
            this.richenteras.WordWrap = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.CadetBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentoToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1366, 24);
            this.menuStrip1.TabIndex = 50;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // documentoToolStripMenuItem
            // 
            this.documentoToolStripMenuItem.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.documentoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.documentoToolStripMenuItem.Name = "documentoToolStripMenuItem";
            this.documentoToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.documentoToolStripMenuItem.Text = "Limpiar";
            this.documentoToolStripMenuItem.Click += new System.EventHandler(this.documentoToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.ayudaToolStripMenuItem.Text = "Estudiante";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.salirToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Ebrima", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(14, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 21);
            this.label11.TabIndex = 51;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(498, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(443, 27);
            this.label12.TabIndex = 75;
            this.label12.Text = "Pequeño Compilador - kelvin R. Torres Almonte ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(642, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 21);
            this.label1.TabIndex = 82;
            this.label1.Text = "Analizador Sintácticos:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(354, 246);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(182, 21);
            this.label16.TabIndex = 81;
            this.label16.Text = "Analizador Semántico:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(79, 246);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(150, 21);
            this.label15.TabIndex = 80;
            this.label15.Text = "Analizador Léxico:";
            // 
            // analisisSin
            // 
            this.analisisSin.BackColor = System.Drawing.Color.Silver;
            this.analisisSin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.analisisSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analisisSin.ForeColor = System.Drawing.SystemColors.Desktop;
            this.analisisSin.Location = new System.Drawing.Point(598, 270);
            this.analisisSin.Name = "analisisSin";
            this.analisisSin.Size = new System.Drawing.Size(277, 189);
            this.analisisSin.TabIndex = 75;
            this.analisisSin.Text = "";
            // 
            // richsemantica
            // 
            this.richsemantica.BackColor = System.Drawing.Color.Silver;
            this.richsemantica.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richsemantica.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richsemantica.ForeColor = System.Drawing.SystemColors.Desktop;
            this.richsemantica.Location = new System.Drawing.Point(322, 270);
            this.richsemantica.Name = "richsemantica";
            this.richsemantica.Size = new System.Drawing.Size(249, 189);
            this.richsemantica.TabIndex = 77;
            this.richsemantica.Text = "";
            // 
            // RIchTxLexico
            // 
            this.RIchTxLexico.BackColor = System.Drawing.Color.Silver;
            this.RIchTxLexico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RIchTxLexico.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RIchTxLexico.ForeColor = System.Drawing.SystemColors.Desktop;
            this.RIchTxLexico.Location = new System.Drawing.Point(18, 270);
            this.RIchTxLexico.Name = "RIchTxLexico";
            this.RIchTxLexico.Size = new System.Drawing.Size(275, 189);
            this.RIchTxLexico.TabIndex = 76;
            this.RIchTxLexico.Text = "";
            // 
            // richSi
            // 
            this.richSi.Location = new System.Drawing.Point(156, 301);
            this.richSi.Name = "richSi";
            this.richSi.Size = new System.Drawing.Size(94, 61);
            this.richSi.TabIndex = 78;
            this.richSi.Text = "";
            this.richSi.Visible = false;
            // 
            // richRepetir
            // 
            this.richRepetir.Location = new System.Drawing.Point(51, 301);
            this.richRepetir.Name = "richRepetir";
            this.richRepetir.Size = new System.Drawing.Size(89, 61);
            this.richRepetir.TabIndex = 79;
            this.richRepetir.Text = "";
            this.richRepetir.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1366, 745);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel4);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pequeño Compilador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Colorearletras;
        private System.Windows.Forms.FontDialog fontSelectDialog;
        private System.Windows.Forms.RichTextBox CodigoMeedCompyTxt;
        private System.Windows.Forms.RichTextBox richenteras;
        private System.Windows.Forms.RichTextBox varnumasig;
        private System.Windows.Forms.RichTextBox varcadasig;
        private System.Windows.Forms.RichTextBox richErroresSintac;
        private System.Windows.Forms.RichTextBox richcadenas;
        private System.Windows.Forms.RichTextBox Ccode;
        private System.Windows.Forms.RichTextBox CCCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem documentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox erroresSemanticos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox analisisSin;
        private System.Windows.Forms.RichTextBox richsemantica;
        private System.Windows.Forms.RichTextBox RIchTxLexico;
        private System.Windows.Forms.RichTextBox richSi;
        private System.Windows.Forms.RichTextBox richRepetir;
    }
 

}

