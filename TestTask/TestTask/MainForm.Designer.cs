namespace TestTask
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonTask5 = new System.Windows.Forms.RadioButton();
            this.radioButtonTask4 = new System.Windows.Forms.RadioButton();
            this.radioButtonTask3 = new System.Windows.Forms.RadioButton();
            this.radioButtonTask2 = new System.Windows.Forms.RadioButton();
            this.radioButtonTask1 = new System.Windows.Forms.RadioButton();
            this.dataGridViewCompany = new System.Windows.Forms.DataGridView();
            this.bsCompany = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioButtonTask5);
            this.groupBox1.Controls.Add(this.radioButtonTask4);
            this.groupBox1.Controls.Add(this.radioButtonTask3);
            this.groupBox1.Controls.Add(this.radioButtonTask2);
            this.groupBox1.Controls.Add(this.radioButtonTask1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Выбор задания ";
            // 
            // radioButtonTask5
            // 
            this.radioButtonTask5.AutoSize = true;
            this.radioButtonTask5.Location = new System.Drawing.Point(15, 111);
            this.radioButtonTask5.Name = "radioButtonTask5";
            this.radioButtonTask5.Size = new System.Drawing.Size(304, 17);
            this.radioButtonTask5.TabIndex = 4;
            this.radioButtonTask5.Text = "Зарплаты руководителей департаментов по убыванию";
            this.radioButtonTask5.UseVisualStyleBackColor = true;
            this.radioButtonTask5.CheckedChanged += new System.EventHandler(this.radioButtonTask5_CheckedChanged);
            // 
            // radioButtonTask4
            // 
            this.radioButtonTask4.AutoSize = true;
            this.radioButtonTask4.Location = new System.Drawing.Point(15, 88);
            this.radioButtonTask4.Name = "radioButtonTask4";
            this.radioButtonTask4.Size = new System.Drawing.Size(423, 17);
            this.radioButtonTask4.TabIndex = 3;
            this.radioButtonTask4.Text = "Отдел, в котором у сотрудника (где он не руководит) зарплата максимальная";
            this.radioButtonTask4.UseVisualStyleBackColor = true;
            this.radioButtonTask4.CheckedChanged += new System.EventHandler(this.radioButtonTask4_CheckedChanged);
            // 
            // radioButtonTask3
            // 
            this.radioButtonTask3.AutoSize = true;
            this.radioButtonTask3.Location = new System.Drawing.Point(15, 65);
            this.radioButtonTask3.Name = "radioButtonTask3";
            this.radioButtonTask3.Size = new System.Drawing.Size(294, 17);
            this.radioButtonTask3.TabIndex = 2;
            this.radioButtonTask3.Text = "Суммарная зарплата по отделам без руководителей";
            this.radioButtonTask3.UseVisualStyleBackColor = true;
            this.radioButtonTask3.CheckedChanged += new System.EventHandler(this.radioButtonTask3_CheckedChanged);
            // 
            // radioButtonTask2
            // 
            this.radioButtonTask2.AutoSize = true;
            this.radioButtonTask2.Location = new System.Drawing.Point(15, 42);
            this.radioButtonTask2.Name = "radioButtonTask2";
            this.radioButtonTask2.Size = new System.Drawing.Size(290, 17);
            this.radioButtonTask2.TabIndex = 1;
            this.radioButtonTask2.Text = "Суммарная зарплата по отделам с руководителями";
            this.radioButtonTask2.UseVisualStyleBackColor = true;
            this.radioButtonTask2.CheckedChanged += new System.EventHandler(this.radioButtonTask2_CheckedChanged);
            // 
            // radioButtonTask1
            // 
            this.radioButtonTask1.AutoSize = true;
            this.radioButtonTask1.Checked = true;
            this.radioButtonTask1.Location = new System.Drawing.Point(15, 19);
            this.radioButtonTask1.Name = "radioButtonTask1";
            this.radioButtonTask1.Size = new System.Drawing.Size(158, 17);
            this.radioButtonTask1.TabIndex = 0;
            this.radioButtonTask1.TabStop = true;
            this.radioButtonTask1.Text = "Все сотрудники компании";
            this.radioButtonTask1.UseVisualStyleBackColor = true;
            this.radioButtonTask1.CheckedChanged += new System.EventHandler(this.radioButtonTask1_CheckedChanged);
            // 
            // dataGridViewCompany
            // 
            this.dataGridViewCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompany.Location = new System.Drawing.Point(12, 159);
            this.dataGridViewCompany.Name = "dataGridViewCompany";
            this.dataGridViewCompany.Size = new System.Drawing.Size(876, 422);
            this.dataGridViewCompany.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 590);
            this.Controls.Add(this.dataGridViewCompany);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Сотрудники компании.";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCompany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonTask5;
        private System.Windows.Forms.RadioButton radioButtonTask4;
        private System.Windows.Forms.RadioButton radioButtonTask3;
        private System.Windows.Forms.RadioButton radioButtonTask2;
        private System.Windows.Forms.RadioButton radioButtonTask1;
        private System.Windows.Forms.DataGridView dataGridViewCompany;
        private System.Windows.Forms.BindingSource bsCompany;
    }
}

