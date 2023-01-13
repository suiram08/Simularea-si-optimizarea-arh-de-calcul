namespace Simulator
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
            this.label2 = new System.Windows.Forms.Label();
            this.FR = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IRmaxim = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IBS = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Latenta = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.Memoria = new System.Windows.Forms.ComboBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.NrRegistri = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SizeDC = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.SizeBloc = new System.Windows.Forms.ComboBox();
            this.TipCacheB = new System.Windows.Forms.RadioButton();
            this.TipCacheU = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.NrInstructiuni = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.NrLoad = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Branch = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Ciclu = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label18 = new System.Windows.Forms.Label();
            this.NumeFisier = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Latenta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fetch Rate (FR):";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FR
            // 
            this.FR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FR.FormattingEnabled = true;
            this.FR.Items.AddRange(new object[] {
            "4",
            "8",
            "16"});
            this.FR.Location = new System.Drawing.Point(158, 20);
            this.FR.Name = "FR";
            this.FR.Size = new System.Drawing.Size(42, 21);
            this.FR.TabIndex = 2;
            this.FR.Text = "4";
            this.FR.SelectedIndexChanged += new System.EventHandler(this.FR_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Issue Rate Maxim (IRmax):";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // IRmaxim
            // 
            this.IRmaxim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IRmaxim.FormattingEnabled = true;
            this.IRmaxim.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "16"});
            this.IRmaxim.Location = new System.Drawing.Point(158, 46);
            this.IRmaxim.Name = "IRmaxim";
            this.IRmaxim.Size = new System.Drawing.Size(42, 21);
            this.IRmaxim.TabIndex = 4;
            this.IRmaxim.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Instruction Buffer Size (IBS):";
            // 
            // IBS
            // 
            this.IBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBS.FormattingEnabled = true;
            this.IBS.Items.AddRange(new object[] {
            "4",
            "8",
            "16",
            "32"});
            this.IBS.Location = new System.Drawing.Point(158, 74);
            this.IBS.Name = "IBS";
            this.IBS.Size = new System.Drawing.Size(42, 21);
            this.IBS.TabIndex = 6;
            this.IBS.Text = "4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Latenta (for hit in cache)";
            // 
            // Latenta
            // 
            this.Latenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Latenta.Location = new System.Drawing.Point(158, 101);
            this.Latenta.Name = "Latenta";
            this.Latenta.Size = new System.Drawing.Size(42, 20);
            this.Latenta.TabIndex = 8;
            this.Latenta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Memoria Principala";
            // 
            // Memoria
            // 
            this.Memoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Memoria.FormattingEnabled = true;
            this.Memoria.Items.AddRange(new object[] {
            "10",
            "15",
            "20"});
            this.Memoria.Location = new System.Drawing.Point(158, 131);
            this.Memoria.Name = "Memoria";
            this.Memoria.Size = new System.Drawing.Size(42, 21);
            this.Memoria.TabIndex = 10;
            this.Memoria.Text = "10";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(13, 167);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(78, 13);
            this.Label7.TabIndex = 11;
            this.Label7.Text = "Nr. Set Registri";
            this.Label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // NrRegistri
            // 
            this.NrRegistri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NrRegistri.FormattingEnabled = true;
            this.NrRegistri.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "16"});
            this.NrRegistri.Location = new System.Drawing.Point(158, 161);
            this.NrRegistri.Name = "NrRegistri";
            this.NrRegistri.Size = new System.Drawing.Size(42, 21);
            this.NrRegistri.TabIndex = 12;
            this.NrRegistri.Text = "2";
            this.NrRegistri.SelectedIndexChanged += new System.EventHandler(this.NrRegistri_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NrRegistri);
            this.groupBox1.Controls.Add(this.Label7);
            this.groupBox1.Controls.Add(this.Memoria);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Latenta);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.IBS);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.IRmaxim);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.FR);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 192);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.TipCacheB);
            this.groupBox2.Controls.Add(this.TipCacheU);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(239, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 192);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cache Parameters (Mapare directa)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBox2);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.SizeDC);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox4.Location = new System.Drawing.Point(208, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(190, 146);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data Cache";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "4",
            "8",
            "16"});
            this.comboBox2.Location = new System.Drawing.Point(79, 62);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(59, 21);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.Text = "4";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(14, 65);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 13);
            this.label20.TabIndex = 3;
            this.label20.Text = "Bloc_Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size_DC";
            // 
            // SizeDC
            // 
            this.SizeDC.FormattingEnabled = true;
            this.SizeDC.Items.AddRange(new object[] {
            "64",
            "128",
            "256",
            "512",
            "1024",
            "2048",
            "4096",
            "8192",
            ""});
            this.SizeDC.Location = new System.Drawing.Point(79, 25);
            this.SizeDC.Name = "SizeDC";
            this.SizeDC.Size = new System.Drawing.Size(59, 21);
            this.SizeDC.TabIndex = 1;
            this.SizeDC.Text = "64";
            this.SizeDC.SelectedIndexChanged += new System.EventHandler(this.SizeDC_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.SizeBloc);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox3.Location = new System.Drawing.Point(9, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(193, 146);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Instruction Cache";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(152, 64);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(30, 13);
            this.label21.TabIndex = 8;
            this.label21.Text = "= FR";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "64",
            "128",
            "256",
            "512",
            "1024",
            "2048",
            "4096",
            "8192"});
            this.comboBox1.Location = new System.Drawing.Point(87, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(59, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "64";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(22, 28);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 13);
            this.label19.TabIndex = 6;
            this.label19.Text = "Size_IC";
            // 
            // SizeBloc
            // 
            this.SizeBloc.Enabled = false;
            this.SizeBloc.FormattingEnabled = true;
            this.SizeBloc.Items.AddRange(new object[] {
            "4",
            "8",
            "16"});
            this.SizeBloc.Location = new System.Drawing.Point(87, 57);
            this.SizeBloc.Name = "SizeBloc";
            this.SizeBloc.Size = new System.Drawing.Size(59, 21);
            this.SizeBloc.TabIndex = 3;
            this.SizeBloc.Text = "4";
            this.SizeBloc.SelectedIndexChanged += new System.EventHandler(this.SizeBloc_SelectedIndexChanged);
            // 
            // TipCacheB
            // 
            this.TipCacheB.AutoSize = true;
            this.TipCacheB.Location = new System.Drawing.Point(198, 169);
            this.TipCacheB.Name = "TipCacheB";
            this.TipCacheB.Size = new System.Drawing.Size(66, 20);
            this.TipCacheB.TabIndex = 5;
            this.TipCacheB.TabStop = true;
            this.TipCacheB.Text = "Biport";
            this.TipCacheB.UseVisualStyleBackColor = true;
            // 
            // TipCacheU
            // 
            this.TipCacheU.AutoSize = true;
            this.TipCacheU.Checked = true;
            this.TipCacheU.Location = new System.Drawing.Point(15, 169);
            this.TipCacheU.Name = "TipCacheU";
            this.TipCacheU.Size = new System.Drawing.Size(75, 20);
            this.TipCacheU.TabIndex = 4;
            this.TipCacheU.TabStop = true;
            this.TipCacheU.Text = "Uniport";
            this.TipCacheU.UseVisualStyleBackColor = true;
            this.TipCacheU.CheckedChanged += new System.EventHandler(this.TipCacheU_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(552, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 411);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Start Simulare";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // NrInstructiuni
            // 
            this.NrInstructiuni.Location = new System.Drawing.Point(115, 342);
            this.NrInstructiuni.Name = "NrInstructiuni";
            this.NrInstructiuni.ReadOnly = true;
            this.NrInstructiuni.Size = new System.Drawing.Size(69, 20);
            this.NrInstructiuni.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Nr. Total Instructiuni";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(291, 311);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Issue Rate";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(377, 308);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(63, 248);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Load";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // NrLoad
            // 
            this.NrLoad.Location = new System.Drawing.Point(115, 248);
            this.NrLoad.Name = "NrLoad";
            this.NrLoad.ReadOnly = true;
            this.NrLoad.Size = new System.Drawing.Size(64, 20);
            this.NrLoad.TabIndex = 25;
            this.NrLoad.TextChanged += new System.EventHandler(this.NrLoad_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(63, 280);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Store";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(115, 280);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(64, 20);
            this.textBox5.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(63, 311);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Branch";
            // 
            // Branch
            // 
            this.Branch.Location = new System.Drawing.Point(115, 311);
            this.Branch.Name = "Branch";
            this.Branch.ReadOnly = true;
            this.Branch.Size = new System.Drawing.Size(64, 20);
            this.Branch.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(291, 248);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "OneCycle";
            // 
            // Ciclu
            // 
            this.Ciclu.Location = new System.Drawing.Point(377, 248);
            this.Ciclu.Name = "Ciclu";
            this.Ciclu.ReadOnly = true;
            this.Ciclu.Size = new System.Drawing.Size(64, 20);
            this.Ciclu.TabIndex = 31;
            this.Ciclu.TextChanged += new System.EventHandler(this.Ciclu_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(291, 414);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Fisier:";
            // 
            // NumeFisier
            // 
            this.NumeFisier.Location = new System.Drawing.Point(341, 414);
            this.NumeFisier.Name = "NumeFisier";
            this.NumeFisier.ReadOnly = true;
            this.NumeFisier.Size = new System.Drawing.Size(100, 20);
            this.NumeFisier.TabIndex = 36;
            this.NumeFisier.TextChanged += new System.EventHandler(this.NumeFisier_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(403, 358);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(64, 20);
            this.textBox1.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(338, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "ticks";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 447);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NumeFisier);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.Ciclu);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Branch);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.NrLoad);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NrInstructiuni);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Simulator Cache";
            ((System.ComponentModel.ISupportInitialize)(this.Latenta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox IRmaxim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox IBS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Latenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Memoria;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.ComboBox NrRegistri;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox SizeBloc;
        private System.Windows.Forms.ComboBox SizeDC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox NrInstructiuni;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox NrLoad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Branch;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Ciclu;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox NumeFisier;
        private System.Windows.Forms.RadioButton TipCacheB;
        private System.Windows.Forms.RadioButton TipCacheU;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
    }
}

