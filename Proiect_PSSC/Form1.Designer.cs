namespace Proiect_PSSC
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
            this.components = new System.ComponentModel.Container();
            this.textBox_nr = new System.Windows.Forms.TextBox();
            this.textBox_nume = new System.Windows.Forms.TextBox();
            this.textBox_prenume = new System.Windows.Forms.TextBox();
            this.textBox_cnp = new System.Windows.Forms.TextBox();
            this.textBox_facultate = new System.Windows.Forms.TextBox();
            this.textBox_an = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.materieBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.store = new Proiect_PSSC.Store();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.materieBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.materieBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.materieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddData = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materieBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.store)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materieBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materieBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_nr
            // 
            this.textBox_nr.Location = new System.Drawing.Point(82, 21);
            this.textBox_nr.Name = "textBox_nr";
            this.textBox_nr.Size = new System.Drawing.Size(100, 20);
            this.textBox_nr.TabIndex = 0;
            // 
            // textBox_nume
            // 
            this.textBox_nume.Location = new System.Drawing.Point(82, 48);
            this.textBox_nume.Name = "textBox_nume";
            this.textBox_nume.Size = new System.Drawing.Size(100, 20);
            this.textBox_nume.TabIndex = 1;
            // 
            // textBox_prenume
            // 
            this.textBox_prenume.Location = new System.Drawing.Point(82, 75);
            this.textBox_prenume.Name = "textBox_prenume";
            this.textBox_prenume.Size = new System.Drawing.Size(100, 20);
            this.textBox_prenume.TabIndex = 2;
            // 
            // textBox_cnp
            // 
            this.textBox_cnp.Location = new System.Drawing.Point(82, 101);
            this.textBox_cnp.Name = "textBox_cnp";
            this.textBox_cnp.Size = new System.Drawing.Size(100, 20);
            this.textBox_cnp.TabIndex = 3;
            // 
            // textBox_facultate
            // 
            this.textBox_facultate.Location = new System.Drawing.Point(82, 127);
            this.textBox_facultate.Name = "textBox_facultate";
            this.textBox_facultate.Size = new System.Drawing.Size(100, 20);
            this.textBox_facultate.TabIndex = 4;
            // 
            // textBox_an
            // 
            this.textBox_an.Location = new System.Drawing.Point(82, 156);
            this.textBox_an.Name = "textBox_an";
            this.textBox_an.Size = new System.Drawing.Size(100, 20);
            this.textBox_an.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Prenume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "CNP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Facultate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "An";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_nr);
            this.groupBox1.Controls.Add(this.textBox_nume);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_prenume);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_cnp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_facultate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_an);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 295);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adauga Student";
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.materieBindingSource3;
            this.comboBox4.DisplayMember = "Denumire";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(82, 268);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 23;
            this.comboBox4.ValueMember = "IDmaterie";
            // 
            // materieBindingSource3
            // 
            this.materieBindingSource3.DataMember = "Materie";
            this.materieBindingSource3.DataSource = this.store;
            // 
            // store
            // 
            this.store.DataSetName = "Store";
            this.store.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.materieBindingSource2;
            this.comboBox3.DisplayMember = "Denumire";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(82, 242);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 22;
            this.comboBox3.ValueMember = "IDmaterie";
            // 
            // materieBindingSource2
            // 
            this.materieBindingSource2.DataMember = "Materie";
            this.materieBindingSource2.DataSource = this.store;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.materieBindingSource1;
            this.comboBox2.DisplayMember = "Denumire";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(82, 216);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 21;
            this.comboBox2.ValueMember = "IDmaterie";
            // 
            // materieBindingSource1
            // 
            this.materieBindingSource1.DataMember = "Materie";
            this.materieBindingSource1.DataSource = this.store;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.materieBindingSource;
            this.comboBox1.DisplayMember = "Denumire";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(82, 189);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.ValueMember = "IDmaterie";
            // 
            // materieBindingSource
            // 
            this.materieBindingSource.DataMember = "Materie";
            this.materieBindingSource.DataSource = this.store;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Materia";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Materia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Materia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Materia";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 37);
            this.button1.TabIndex = 16;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddData
            // 
            this.btnAddData.Location = new System.Drawing.Point(346, 33);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(142, 61);
            this.btnAddData.TabIndex = 17;
            this.btnAddData.Text = "Adauga date test";
            this.btnAddData.UseVisualStyleBackColor = true;
            this.btnAddData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 402);
            this.Controls.Add(this.btnAddData);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materieBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.store)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materieBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materieBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materieBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_nr;
        private System.Windows.Forms.TextBox textBox_nume;
        private System.Windows.Forms.TextBox textBox_prenume;
        private System.Windows.Forms.TextBox textBox_cnp;
        private System.Windows.Forms.TextBox textBox_facultate;
        private System.Windows.Forms.TextBox textBox_an;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource materieBindingSource;
        private Store store;
        private System.Windows.Forms.Button btnAddData;
        private System.Windows.Forms.BindingSource materieBindingSource3;
        private System.Windows.Forms.BindingSource materieBindingSource2;
        private System.Windows.Forms.BindingSource materieBindingSource1;
    }
}

