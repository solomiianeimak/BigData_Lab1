namespace lab1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textCategoryId = new TextBox();
            textCategoryName = new TextBox();
            textCategoryDescription = new TextBox();
            textProductId = new TextBox();
            textProductName = new TextBox();
            textProductPrice = new TextBox();
            textProductUnit = new TextBox();
            textProductCategoryId = new TextBox();
            btnInsertCategory = new Button();
            btnInsertProduct = new Button();
            btnUpdateCategoryId = new Button();
            textNewCategoryId = new TextBox();
            textOldCategoryId = new TextBox();
            btnDeleteCategory = new Button();
            textDeleteCategory = new TextBox();
            dgvCategory = new DataGridView();
            dgvProduct = new DataGridView();
            btnUpdatedgv = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // textCategoryId
            // 
            textCategoryId.Location = new Point(27, 71);
            textCategoryId.Name = "textCategoryId";
            textCategoryId.Size = new Size(305, 27);
            textCategoryId.TabIndex = 0;
            // 
            // textCategoryName
            // 
            textCategoryName.Location = new Point(27, 126);
            textCategoryName.Name = "textCategoryName";
            textCategoryName.Size = new Size(305, 27);
            textCategoryName.TabIndex = 1;
            // 
            // textCategoryDescription
            // 
            textCategoryDescription.Location = new Point(27, 188);
            textCategoryDescription.Multiline = true;
            textCategoryDescription.Name = "textCategoryDescription";
            textCategoryDescription.Size = new Size(305, 149);
            textCategoryDescription.TabIndex = 2;
            // 
            // textProductId
            // 
            textProductId.Location = new Point(408, 71);
            textProductId.Name = "textProductId";
            textProductId.Size = new Size(305, 27);
            textProductId.TabIndex = 3;
            // 
            // textProductName
            // 
            textProductName.Location = new Point(408, 126);
            textProductName.Name = "textProductName";
            textProductName.Size = new Size(305, 27);
            textProductName.TabIndex = 4;
            // 
            // textProductPrice
            // 
            textProductPrice.Location = new Point(408, 188);
            textProductPrice.Name = "textProductPrice";
            textProductPrice.Size = new Size(305, 27);
            textProductPrice.TabIndex = 5;
            // 
            // textProductUnit
            // 
            textProductUnit.Location = new Point(408, 247);
            textProductUnit.Name = "textProductUnit";
            textProductUnit.Size = new Size(305, 27);
            textProductUnit.TabIndex = 6;
            // 
            // textProductCategoryId
            // 
            textProductCategoryId.Location = new Point(408, 310);
            textProductCategoryId.Name = "textProductCategoryId";
            textProductCategoryId.Size = new Size(305, 27);
            textProductCategoryId.TabIndex = 7;
            // 
            // btnInsertCategory
            // 
            btnInsertCategory.Location = new Point(148, 358);
            btnInsertCategory.Name = "btnInsertCategory";
            btnInsertCategory.Size = new Size(184, 29);
            btnInsertCategory.TabIndex = 8;
            btnInsertCategory.Text = "Додати категорію";
            btnInsertCategory.UseVisualStyleBackColor = true;
            btnInsertCategory.Click += btnInsertCategory_click;
            // 
            // btnInsertProduct
            // 
            btnInsertProduct.Location = new Point(529, 358);
            btnInsertProduct.Name = "btnInsertProduct";
            btnInsertProduct.Size = new Size(184, 29);
            btnInsertProduct.TabIndex = 9;
            btnInsertProduct.Text = "Додати продукт";
            btnInsertProduct.UseVisualStyleBackColor = true;
            btnInsertProduct.Click += btnInsertProduct_click;
            // 
            // btnUpdateCategoryId
            // 
            btnUpdateCategoryId.Location = new Point(961, 165);
            btnUpdateCategoryId.Name = "btnUpdateCategoryId";
            btnUpdateCategoryId.Size = new Size(130, 29);
            btnUpdateCategoryId.TabIndex = 12;
            btnUpdateCategoryId.Text = "Оновити ID";
            btnUpdateCategoryId.UseVisualStyleBackColor = true;
            btnUpdateCategoryId.Click += btnUpdateCategoryId_click;
            // 
            // textNewCategoryId
            // 
            textNewCategoryId.Location = new Point(786, 126);
            textNewCategoryId.Name = "textNewCategoryId";
            textNewCategoryId.Size = new Size(305, 27);
            textNewCategoryId.TabIndex = 11;
            // 
            // textOldCategoryId
            // 
            textOldCategoryId.Location = new Point(786, 71);
            textOldCategoryId.Name = "textOldCategoryId";
            textOldCategoryId.Size = new Size(305, 27);
            textOldCategoryId.TabIndex = 10;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Location = new Point(961, 358);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(130, 29);
            btnDeleteCategory.TabIndex = 14;
            btnDeleteCategory.Text = "Видалити";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            btnDeleteCategory.Click += btnDeleteCategory_click;
            // 
            // textDeleteCategory
            // 
            textDeleteCategory.Location = new Point(786, 310);
            textDeleteCategory.Name = "textDeleteCategory";
            textDeleteCategory.Size = new Size(305, 27);
            textDeleteCategory.TabIndex = 13;
            // 
            // dgvCategory
            // 
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategory.Location = new Point(39, 441);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.RowHeadersWidth = 51;
            dgvCategory.Size = new Size(602, 188);
            dgvCategory.TabIndex = 15;
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(661, 441);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.Size = new Size(602, 188);
            dgvProduct.TabIndex = 16;
            // 
            // btnUpdatedgv
            // 
            btnUpdatedgv.Location = new Point(529, 638);
            btnUpdatedgv.Name = "btnUpdatedgv";
            btnUpdatedgv.Size = new Size(224, 29);
            btnUpdatedgv.TabIndex = 17;
            btnUpdatedgv.Text = "Оновити таблиці";
            btnUpdatedgv.UseVisualStyleBackColor = true;
            btnUpdatedgv.Click += btnUpdatedgv_click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 48);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 18;
            label1.Text = "ID категорії";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 103);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 19;
            label2.Text = "Назва";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(27, 15);
            label3.Name = "label3";
            label3.Size = new Size(178, 20);
            label3.TabIndex = 20;
            label3.Text = "Додати нову категорію";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 165);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 21;
            label4.Text = "Опис";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(408, 15);
            label5.Name = "label5";
            label5.Size = new Size(175, 20);
            label5.TabIndex = 22;
            label5.Text = "Додати новий продукт";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(408, 48);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 23;
            label6.Text = "ID продукту";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(408, 103);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 24;
            label7.Text = "Назва";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(408, 165);
            label8.Name = "label8";
            label8.Size = new Size(41, 20);
            label8.TabIndex = 25;
            label8.Text = "Ціна";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(408, 224);
            label9.Name = "label9";
            label9.Size = new Size(167, 20);
            label9.TabIndex = 26;
            label9.Text = "Одиниці вимірювання";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(408, 287);
            label10.Name = "label10";
            label10.Size = new Size(89, 20);
            label10.TabIndex = 27;
            label10.Text = "ID категорії";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.Location = new Point(786, 15);
            label11.Name = "label11";
            label11.Size = new Size(159, 20);
            label11.TabIndex = 28;
            label11.Text = "Оновити ID категорії";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(786, 48);
            label12.Name = "label12";
            label12.Size = new Size(133, 20);
            label12.TabIndex = 29;
            label12.Text = "Старе ID категорії";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(786, 101);
            label13.Name = "label13";
            label13.Size = new Size(129, 20);
            label13.TabIndex = 30;
            label13.Text = "Нове ID категорії";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label14.Location = new Point(786, 254);
            label14.Name = "label14";
            label14.Size = new Size(155, 20);
            label14.TabIndex = 31;
            label14.Text = "Видалити категорію";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(786, 287);
            label15.Name = "label15";
            label15.Size = new Size(89, 20);
            label15.TabIndex = 32;
            label15.Text = "ID категорії";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label16.Location = new Point(39, 418);
            label16.Name = "label16";
            label16.Size = new Size(143, 20);
            label16.TabIndex = 33;
            label16.Text = "Таблиця категорій";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label17.Location = new Point(661, 418);
            label17.Name = "label17";
            label17.Size = new Size(130, 20);
            label17.TabIndex = 34;
            label17.Text = "Таблиця товарів";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1295, 676);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnUpdatedgv);
            Controls.Add(dgvProduct);
            Controls.Add(dgvCategory);
            Controls.Add(btnDeleteCategory);
            Controls.Add(textDeleteCategory);
            Controls.Add(btnUpdateCategoryId);
            Controls.Add(textNewCategoryId);
            Controls.Add(textOldCategoryId);
            Controls.Add(btnInsertProduct);
            Controls.Add(btnInsertCategory);
            Controls.Add(textProductCategoryId);
            Controls.Add(textProductUnit);
            Controls.Add(textProductPrice);
            Controls.Add(textProductName);
            Controls.Add(textProductId);
            Controls.Add(textCategoryDescription);
            Controls.Add(textCategoryName);
            Controls.Add(textCategoryId);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private TextBox textCategoryId;
        private TextBox textCategoryName;
        private TextBox textCategoryDescription;
        private TextBox textProductId;
        private TextBox textProductName;
        private TextBox textProductPrice;
        private TextBox textProductUnit;
        private TextBox textProductCategoryId;
        private Button btnInsertCategory;
        private Button btnInsertProduct;
        private Button btnUpdateCategoryId;
        private TextBox textNewCategoryId;
        private TextBox textOldCategoryId;
        private Button btnDeleteCategory;
        private TextBox textDeleteCategory;
        private Button btnUpdatedgv;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
    }
}