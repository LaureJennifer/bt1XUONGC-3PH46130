namespace bt1XUONGC_3
{
    partial class XeF
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
            label1 = new Label();
            tenText = new TextBox();
            motaText = new TextBox();
            label2 = new Label();
            giaNhapText = new TextBox();
            label3 = new Label();
            label4 = new Label();
            soLuongText = new ComboBox();
            label5 = new Label();
            timKiemText = new TextBox();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            xeGrid = new DataGridView();
            themBtn = new Button();
            xoaBtn = new Button();
            hienThiBtn = new Button();
            clearBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)xeGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 14);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên xe";
            // 
            // tenText
            // 
            tenText.Location = new Point(118, 11);
            tenText.Name = "tenText";
            tenText.Size = new Size(332, 27);
            tenText.TabIndex = 1;
            // 
            // motaText
            // 
            motaText.Location = new Point(118, 53);
            motaText.Name = "motaText";
            motaText.Size = new Size(332, 27);
            motaText.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 60);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 2;
            label2.Text = "Mô tả";
            // 
            // giaNhapText
            // 
            giaNhapText.Location = new Point(118, 104);
            giaNhapText.Name = "giaNhapText";
            giaNhapText.Size = new Size(332, 27);
            giaNhapText.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 107);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 4;
            label3.Text = "Giá nhập";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 155);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 6;
            label4.Text = "Số lượng";
            // 
            // soLuongText
            // 
            soLuongText.FormattingEnabled = true;
            soLuongText.Location = new Point(118, 155);
            soLuongText.Name = "soLuongText";
            soLuongText.Size = new Size(332, 28);
            soLuongText.TabIndex = 7;
            
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 209);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 8;
            label5.Text = "Tìm kiếm";
            // 
            // timKiemText
            // 
            timKiemText.Location = new Point(128, 206);
            timKiemText.Name = "timKiemText";
            timKiemText.PlaceholderText = "Nhập tên để tìm kiếm";
            timKiemText.Size = new Size(509, 27);
            timKiemText.TabIndex = 9;
            // 
            // xeGrid
            // 
            xeGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            xeGrid.Location = new Point(4, 242);
            xeGrid.Name = "xeGrid";
            xeGrid.RowHeadersWidth = 51;
            xeGrid.RowTemplate.Height = 29;
            xeGrid.Size = new Size(675, 210);
            xeGrid.TabIndex = 10;
            xeGrid.CellClick += xeGrid_CellClick;
            // 
            // themBtn
            // 
            themBtn.Location = new Point(475, 2);
            themBtn.Name = "themBtn";
            themBtn.Size = new Size(198, 45);
            themBtn.TabIndex = 11;
            themBtn.Text = "Thêm";
            themBtn.UseVisualStyleBackColor = true;
            themBtn.Click += themBtn_Click;
            // 
            // xoaBtn
            // 
            xoaBtn.Location = new Point(475, 53);
            xoaBtn.Name = "xoaBtn";
            xoaBtn.Size = new Size(198, 45);
            xoaBtn.TabIndex = 12;
            xoaBtn.Text = "Xóa";
            xoaBtn.UseVisualStyleBackColor = true;
            xoaBtn.Click += xoaBtn_Click;
            // 
            // hienThiBtn
            // 
            hienThiBtn.Location = new Point(475, 104);
            hienThiBtn.Name = "hienThiBtn";
            hienThiBtn.Size = new Size(198, 45);
            hienThiBtn.TabIndex = 13;
            hienThiBtn.Text = "Hiển thị";
            hienThiBtn.UseVisualStyleBackColor = true;
            hienThiBtn.Click += hienThiBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(475, 155);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(198, 45);
            clearBtn.TabIndex = 14;
            clearBtn.Text = "Xóa form";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // XeF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 454);
            Controls.Add(clearBtn);
            Controls.Add(hienThiBtn);
            Controls.Add(xoaBtn);
            Controls.Add(themBtn);
            Controls.Add(xeGrid);
            Controls.Add(timKiemText);
            Controls.Add(label5);
            Controls.Add(soLuongText);
            Controls.Add(label4);
            Controls.Add(giaNhapText);
            Controls.Add(label3);
            Controls.Add(motaText);
            Controls.Add(label2);
            Controls.Add(tenText);
            Controls.Add(label1);
            Name = "XeF";
            Text = "Form1";
            Load += XeF_Load;
            ((System.ComponentModel.ISupportInitialize)xeGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tenText;
        private TextBox motaText;
        private Label label2;
        private TextBox giaNhapText;
        private Label label3;
        private Label label4;
        private ComboBox soLuongText;
        private Label label5;
        private TextBox timKiemText;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private DataGridView xeGrid;
        private Button themBtn;
        private Button xoaBtn;
        private Button hienThiBtn;
        private Button clearBtn;
    }
}