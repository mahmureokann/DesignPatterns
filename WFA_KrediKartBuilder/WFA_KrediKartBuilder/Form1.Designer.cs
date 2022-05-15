namespace WFA_KrediKartBuilder
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.rbHayir = new System.Windows.Forms.RadioButton();
            this.rbEvet = new System.Windows.Forms.RadioButton();
            this.nudKartLimit = new System.Windows.Forms.NumericUpDown();
            this.cmbKartTip = new System.Windows.Forms.ComboBox();
            this.cmbBanka = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKartLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.rbHayir);
            this.groupBox1.Controls.Add(this.rbEvet);
            this.groupBox1.Controls.Add(this.nudKartLimit);
            this.groupBox1.Controls.Add(this.cmbKartTip);
            this.groupBox1.Controls.Add(this.cmbBanka);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 545);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kredi Kart Bilgiler";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(130, 338);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(211, 56);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // rbHayir
            // 
            this.rbHayir.AutoSize = true;
            this.rbHayir.Location = new System.Drawing.Point(228, 212);
            this.rbHayir.Name = "rbHayir";
            this.rbHayir.Size = new System.Drawing.Size(74, 28);
            this.rbHayir.TabIndex = 3;
            this.rbHayir.TabStop = true;
            this.rbHayir.Text = "Hayır";
            this.rbHayir.UseVisualStyleBackColor = true;
            // 
            // rbEvet
            // 
            this.rbEvet.AutoSize = true;
            this.rbEvet.Location = new System.Drawing.Point(135, 211);
            this.rbEvet.Name = "rbEvet";
            this.rbEvet.Size = new System.Drawing.Size(68, 28);
            this.rbEvet.TabIndex = 3;
            this.rbEvet.TabStop = true;
            this.rbEvet.Text = "Evet";
            this.rbEvet.UseVisualStyleBackColor = true;
            // 
            // nudKartLimit
            // 
            this.nudKartLimit.Location = new System.Drawing.Point(135, 139);
            this.nudKartLimit.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudKartLimit.Name = "nudKartLimit";
            this.nudKartLimit.Size = new System.Drawing.Size(206, 28);
            this.nudKartLimit.TabIndex = 2;
            // 
            // cmbKartTip
            // 
            this.cmbKartTip.FormattingEnabled = true;
            this.cmbKartTip.Location = new System.Drawing.Point(135, 279);
            this.cmbKartTip.Name = "cmbKartTip";
            this.cmbKartTip.Size = new System.Drawing.Size(206, 30);
            this.cmbKartTip.TabIndex = 1;
            // 
            // cmbBanka
            // 
            this.cmbBanka.FormattingEnabled = true;
            this.cmbBanka.Location = new System.Drawing.Point(135, 59);
            this.cmbBanka.Name = "cmbBanka";
            this.cmbBanka.Size = new System.Drawing.Size(206, 30);
            this.cmbBanka.TabIndex = 1;
            this.cmbBanka.SelectedIndexChanged += new System.EventHandler(this.cmbBanka_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Taksit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kart Tip:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kart Limit:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Banka Seç:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(418, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(684, 530);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Banka Adı";
            this.columnHeader1.Width = 131;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kart Limit";
            this.columnHeader2.Width = 146;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Taksit";
            this.columnHeader3.Width = 169;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kart Tip";
            this.columnHeader4.Width = 158;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 625);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKartLimit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbBanka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.RadioButton rbHayir;
        private System.Windows.Forms.RadioButton rbEvet;
        private System.Windows.Forms.NumericUpDown nudKartLimit;
        private System.Windows.Forms.ComboBox cmbKartTip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

