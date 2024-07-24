namespace Mindy服飾購物車
{
    partial class FormOrderList
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl訂購人性名 = new System.Windows.Forms.Label();
            this.listBox訂購品項列表 = new System.Windows.Forms.ListBox();
            this.lbl訂單總價 = new System.Windows.Forms.Label();
            this.btn移除所選品項 = new System.Windows.Forms.Button();
            this.btn清除所有品項 = new System.Windows.Forms.Button();
            this.btn輸出訂購單資料 = new System.Windows.Forms.Button();
            this.btn繼續選購 = new System.Windows.Forms.Button();
            this.lbl訂購人電話 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(291, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "訂購品項列表(購物車結帳)";
            // 
            // lbl訂購人性名
            // 
            this.lbl訂購人性名.AutoSize = true;
            this.lbl訂購人性名.BackColor = System.Drawing.Color.White;
            this.lbl訂購人性名.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂購人性名.Location = new System.Drawing.Point(19, 58);
            this.lbl訂購人性名.Name = "lbl訂購人性名";
            this.lbl訂購人性名.Size = new System.Drawing.Size(134, 31);
            this.lbl訂購人性名.TabIndex = 1;
            this.lbl訂購人性名.Text = "訂購人姓名";
            // 
            // listBox訂購品項列表
            // 
            this.listBox訂購品項列表.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox訂購品項列表.FormattingEnabled = true;
            this.listBox訂購品項列表.ItemHeight = 29;
            this.listBox訂購品項列表.Location = new System.Drawing.Point(24, 99);
            this.listBox訂購品項列表.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox訂購品項列表.Name = "listBox訂購品項列表";
            this.listBox訂購品項列表.Size = new System.Drawing.Size(877, 381);
            this.listBox訂購品項列表.TabIndex = 2;
            // 
            // lbl訂單總價
            // 
            this.lbl訂單總價.AutoSize = true;
            this.lbl訂單總價.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl訂單總價.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂單總價.Location = new System.Drawing.Point(660, 520);
            this.lbl訂單總價.Name = "lbl訂單總價";
            this.lbl訂單總價.Size = new System.Drawing.Size(237, 35);
            this.lbl訂單總價.TabIndex = 5;
            this.lbl訂單總價.Text = "訂單總價 00000元";
            // 
            // btn移除所選品項
            // 
            this.btn移除所選品項.BackColor = System.Drawing.Color.White;
            this.btn移除所選品項.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn移除所選品項.Location = new System.Drawing.Point(400, 564);
            this.btn移除所選品項.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn移除所選品項.Name = "btn移除所選品項";
            this.btn移除所選品項.Size = new System.Drawing.Size(217, 45);
            this.btn移除所選品項.TabIndex = 6;
            this.btn移除所選品項.Text = "移除所選品項";
            this.btn移除所選品項.UseVisualStyleBackColor = false;
            this.btn移除所選品項.Click += new System.EventHandler(this.btn移除所選品項_Click);
            // 
            // btn清除所有品項
            // 
            this.btn清除所有品項.BackColor = System.Drawing.Color.White;
            this.btn清除所有品項.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清除所有品項.ForeColor = System.Drawing.Color.Red;
            this.btn清除所有品項.Location = new System.Drawing.Point(400, 621);
            this.btn清除所有品項.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn清除所有品項.Name = "btn清除所有品項";
            this.btn清除所有品項.Size = new System.Drawing.Size(217, 45);
            this.btn清除所有品項.TabIndex = 7;
            this.btn清除所有品項.Text = "清除所有品項";
            this.btn清除所有品項.UseVisualStyleBackColor = false;
            this.btn清除所有品項.Click += new System.EventHandler(this.btn清除所有品項_Click);
            // 
            // btn輸出訂購單資料
            // 
            this.btn輸出訂購單資料.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn輸出訂購單資料.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn輸出訂購單資料.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn輸出訂購單資料.Location = new System.Drawing.Point(665, 564);
            this.btn輸出訂購單資料.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn輸出訂購單資料.Name = "btn輸出訂購單資料";
            this.btn輸出訂購單資料.Size = new System.Drawing.Size(243, 45);
            this.btn輸出訂購單資料.TabIndex = 8;
            this.btn輸出訂購單資料.Text = "輸出訂購單資料";
            this.btn輸出訂購單資料.UseVisualStyleBackColor = false;
            this.btn輸出訂購單資料.Click += new System.EventHandler(this.btn輸出訂購單資料_Click);
            // 
            // btn繼續選購
            // 
            this.btn繼續選購.BackColor = System.Drawing.Color.White;
            this.btn繼續選購.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn繼續選購.Location = new System.Drawing.Point(665, 621);
            this.btn繼續選購.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn繼續選購.Name = "btn繼續選購";
            this.btn繼續選購.Size = new System.Drawing.Size(247, 45);
            this.btn繼續選購.TabIndex = 9;
            this.btn繼續選購.Text = "繼續選購(關閉表單)";
            this.btn繼續選購.UseVisualStyleBackColor = false;
            this.btn繼續選購.Click += new System.EventHandler(this.btn繼續選購_Click);
            // 
            // lbl訂購人電話
            // 
            this.lbl訂購人電話.AutoSize = true;
            this.lbl訂購人電話.BackColor = System.Drawing.Color.White;
            this.lbl訂購人電話.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂購人電話.Location = new System.Drawing.Point(159, 58);
            this.lbl訂購人電話.Name = "lbl訂購人電話";
            this.lbl訂購人電話.Size = new System.Drawing.Size(134, 31);
            this.lbl訂購人電話.TabIndex = 10;
            this.lbl訂購人電話.Text = "訂購人電話";
            // 
            // FormOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(923, 676);
            this.Controls.Add(this.lbl訂購人電話);
            this.Controls.Add(this.btn繼續選購);
            this.Controls.Add(this.btn輸出訂購單資料);
            this.Controls.Add(this.btn清除所有品項);
            this.Controls.Add(this.btn移除所選品項);
            this.Controls.Add(this.lbl訂單總價);
            this.Controls.Add(this.listBox訂購品項列表);
            this.Controls.Add(this.lbl訂購人性名);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormOrderList";
            this.Text = "訂購品項列表";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOrderList_FormClosing);
            this.Load += new System.EventHandler(this.FormOrderList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl訂購人性名;
        private System.Windows.Forms.ListBox listBox訂購品項列表;
        private System.Windows.Forms.Label lbl訂單總價;
        private System.Windows.Forms.Button btn移除所選品項;
        private System.Windows.Forms.Button btn清除所有品項;
        private System.Windows.Forms.Button btn輸出訂購單資料;
        private System.Windows.Forms.Button btn繼續選購;
        private System.Windows.Forms.Label lbl訂購人電話;
    }
}