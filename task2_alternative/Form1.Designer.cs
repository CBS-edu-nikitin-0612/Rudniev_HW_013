
namespace task2_alternative
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.valute1 = new System.Windows.Forms.ComboBox();
            this.valuteTo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.NumericUpDown();
            this.resLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Расчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Из:";
            // 
            // valute1
            // 
            this.valute1.FormattingEnabled = true;
            this.valute1.Items.AddRange(new object[] {
            "usd",
            "eur",
            "rub",
            "grn"});
            this.valute1.Location = new System.Drawing.Point(43, 10);
            this.valute1.Name = "valute1";
            this.valute1.Size = new System.Drawing.Size(47, 23);
            this.valute1.TabIndex = 2;
            this.valute1.Text = "usd";
            // 
            // valuteTo
            // 
            this.valuteTo.FormattingEnabled = true;
            this.valuteTo.Items.AddRange(new object[] {
            "usd",
            "eur",
            "rub",
            "grn"});
            this.valuteTo.Location = new System.Drawing.Point(119, 10);
            this.valuteTo.Name = "valuteTo";
            this.valuteTo.Size = new System.Drawing.Size(47, 23);
            this.valuteTo.TabIndex = 4;
            this.valuteTo.Text = "usd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "В:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Сумма:";
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(67, 38);
            this.amount.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(99, 23);
            this.amount.TabIndex = 7;
            // 
            // resLable
            // 
            this.resLable.AutoSize = true;
            this.resLable.Location = new System.Drawing.Point(14, 108);
            this.resLable.Name = "resLable";
            this.resLable.Size = new System.Drawing.Size(82, 15);
            this.resLable.TabIndex = 8;
            this.resLable.Text = "Получилось: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(193, 138);
            this.Controls.Add(this.resLable);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.valuteTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valute1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(209, 177);
            this.MinimumSize = new System.Drawing.Size(209, 177);
            this.Name = "Form1";
            this.Text = "Конвертор";
            ((System.ComponentModel.ISupportInitialize)(this.amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox valute1;
        private System.Windows.Forms.ComboBox valuteTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown amount;
        private System.Windows.Forms.Label resLable;
    }
}

