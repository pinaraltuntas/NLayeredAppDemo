namespace Northwind.WebFormUI
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
			this.gbxCategory = new System.Windows.Forms.GroupBox();
			this.cbxCategory = new System.Windows.Forms.ComboBox();
			this.lblCategory = new System.Windows.Forms.Label();
			this.gbxProductName = new System.Windows.Forms.GroupBox();
			this.tbxProductName = new System.Windows.Forms.TextBox();
			this.lblProductName = new System.Windows.Forms.Label();
			this.dgwProduct = new System.Windows.Forms.DataGridView();
			this.gbxProductAdd = new System.Windows.Forms.GroupBox();
			this.tbxProductName2 = new System.Windows.Forms.TextBox();
			this.tbxStock = new System.Windows.Forms.TextBox();
			this.tbxUnitPrice = new System.Windows.Forms.TextBox();
			this.lblProductName2 = new System.Windows.Forms.Label();
			this.lblCategoryID = new System.Windows.Forms.Label();
			this.lblUnitPrice = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblQuantityPerUnit = new System.Windows.Forms.Label();
			this.tbxQuantityPerUnit = new System.Windows.Forms.TextBox();
			this.cbxCategoryId = new System.Windows.Forms.ComboBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.tbxQuantityPerUnitUpdate = new System.Windows.Forms.TextBox();
			this.tbxUnitsInStockUpdate = new System.Windows.Forms.TextBox();
			this.tbxUnitPriceUpdate = new System.Windows.Forms.TextBox();
			this.cbxCategoryIdUpdate = new System.Windows.Forms.ComboBox();
			this.tbxProductNameUpdate = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnDelete = new System.Windows.Forms.Button();
			this.gbxCategory.SuspendLayout();
			this.gbxProductName.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
			this.gbxProductAdd.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbxCategory
			// 
			this.gbxCategory.Controls.Add(this.cbxCategory);
			this.gbxCategory.Controls.Add(this.lblCategory);
			this.gbxCategory.Location = new System.Drawing.Point(61, 36);
			this.gbxCategory.Margin = new System.Windows.Forms.Padding(1);
			this.gbxCategory.Name = "gbxCategory";
			this.gbxCategory.Padding = new System.Windows.Forms.Padding(1);
			this.gbxCategory.Size = new System.Drawing.Size(669, 57);
			this.gbxCategory.TabIndex = 4;
			this.gbxCategory.TabStop = false;
			this.gbxCategory.Text = "Kategoriye göre ara";
			// 
			// cbxCategory
			// 
			this.cbxCategory.FormattingEnabled = true;
			this.cbxCategory.Location = new System.Drawing.Point(63, 24);
			this.cbxCategory.Margin = new System.Windows.Forms.Padding(1);
			this.cbxCategory.Name = "cbxCategory";
			this.cbxCategory.Size = new System.Drawing.Size(204, 21);
			this.cbxCategory.TabIndex = 1;
			this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
			// 
			// lblCategory
			// 
			this.lblCategory.AutoSize = true;
			this.lblCategory.Location = new System.Drawing.Point(12, 27);
			this.lblCategory.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.lblCategory.Name = "lblCategory";
			this.lblCategory.Size = new System.Drawing.Size(46, 13);
			this.lblCategory.TabIndex = 0;
			this.lblCategory.Text = "Kategori";
			// 
			// gbxProductName
			// 
			this.gbxProductName.Controls.Add(this.tbxProductName);
			this.gbxProductName.Controls.Add(this.lblProductName);
			this.gbxProductName.Location = new System.Drawing.Point(61, 101);
			this.gbxProductName.Margin = new System.Windows.Forms.Padding(1);
			this.gbxProductName.Name = "gbxProductName";
			this.gbxProductName.Padding = new System.Windows.Forms.Padding(1);
			this.gbxProductName.Size = new System.Drawing.Size(669, 57);
			this.gbxProductName.TabIndex = 5;
			this.gbxProductName.TabStop = false;
			this.gbxProductName.Text = "Ürün adına göre ara";
			// 
			// tbxProductName
			// 
			this.tbxProductName.Location = new System.Drawing.Point(63, 23);
			this.tbxProductName.Margin = new System.Windows.Forms.Padding(1);
			this.tbxProductName.Name = "tbxProductName";
			this.tbxProductName.Size = new System.Drawing.Size(204, 20);
			this.tbxProductName.TabIndex = 1;
			this.tbxProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
			// 
			// lblProductName
			// 
			this.lblProductName.AutoSize = true;
			this.lblProductName.Location = new System.Drawing.Point(12, 26);
			this.lblProductName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.lblProductName.Name = "lblProductName";
			this.lblProductName.Size = new System.Drawing.Size(48, 13);
			this.lblProductName.TabIndex = 0;
			this.lblProductName.Text = "Ürün Adı";
			// 
			// dgwProduct
			// 
			this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwProduct.Location = new System.Drawing.Point(61, 169);
			this.dgwProduct.Margin = new System.Windows.Forms.Padding(1);
			this.dgwProduct.Name = "dgwProduct";
			this.dgwProduct.RowTemplate.Height = 40;
			this.dgwProduct.Size = new System.Drawing.Size(669, 142);
			this.dgwProduct.TabIndex = 3;
			this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
			// 
			// gbxProductAdd
			// 
			this.gbxProductAdd.Controls.Add(this.btnAdd);
			this.gbxProductAdd.Controls.Add(this.cbxCategoryId);
			this.gbxProductAdd.Controls.Add(this.tbxQuantityPerUnit);
			this.gbxProductAdd.Controls.Add(this.lblQuantityPerUnit);
			this.gbxProductAdd.Controls.Add(this.label4);
			this.gbxProductAdd.Controls.Add(this.lblUnitPrice);
			this.gbxProductAdd.Controls.Add(this.lblCategoryID);
			this.gbxProductAdd.Controls.Add(this.lblProductName2);
			this.gbxProductAdd.Controls.Add(this.tbxUnitPrice);
			this.gbxProductAdd.Controls.Add(this.tbxStock);
			this.gbxProductAdd.Controls.Add(this.tbxProductName2);
			this.gbxProductAdd.Location = new System.Drawing.Point(61, 356);
			this.gbxProductAdd.Name = "gbxProductAdd";
			this.gbxProductAdd.Size = new System.Drawing.Size(669, 175);
			this.gbxProductAdd.TabIndex = 6;
			this.gbxProductAdd.TabStop = false;
			this.gbxProductAdd.Text = "Yeni Ürün Ekle";
			// 
			// tbxProductName2
			// 
			this.tbxProductName2.Location = new System.Drawing.Point(74, 29);
			this.tbxProductName2.Name = "tbxProductName2";
			this.tbxProductName2.Size = new System.Drawing.Size(121, 20);
			this.tbxProductName2.TabIndex = 0;
			// 
			// tbxStock
			// 
			this.tbxStock.Location = new System.Drawing.Point(376, 26);
			this.tbxStock.Name = "tbxStock";
			this.tbxStock.Size = new System.Drawing.Size(121, 20);
			this.tbxStock.TabIndex = 1;
			// 
			// tbxUnitPrice
			// 
			this.tbxUnitPrice.Location = new System.Drawing.Point(74, 92);
			this.tbxUnitPrice.Name = "tbxUnitPrice";
			this.tbxUnitPrice.Size = new System.Drawing.Size(121, 20);
			this.tbxUnitPrice.TabIndex = 3;
			// 
			// lblProductName2
			// 
			this.lblProductName2.AutoSize = true;
			this.lblProductName2.Location = new System.Drawing.Point(15, 29);
			this.lblProductName2.Name = "lblProductName2";
			this.lblProductName2.Size = new System.Drawing.Size(48, 13);
			this.lblProductName2.TabIndex = 4;
			this.lblProductName2.Text = "Ürün Adı";
			// 
			// lblCategoryID
			// 
			this.lblCategoryID.AutoSize = true;
			this.lblCategoryID.Location = new System.Drawing.Point(15, 62);
			this.lblCategoryID.Name = "lblCategoryID";
			this.lblCategoryID.Size = new System.Drawing.Size(46, 13);
			this.lblCategoryID.TabIndex = 5;
			this.lblCategoryID.Text = "Kategori";
			// 
			// lblUnitPrice
			// 
			this.lblUnitPrice.AutoSize = true;
			this.lblUnitPrice.Location = new System.Drawing.Point(15, 92);
			this.lblUnitPrice.Name = "lblUnitPrice";
			this.lblUnitPrice.Size = new System.Drawing.Size(29, 13);
			this.lblUnitPrice.TabIndex = 6;
			this.lblUnitPrice.Text = "Fiyat";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(306, 29);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Stok Adedi";
			// 
			// lblQuantityPerUnit
			// 
			this.lblQuantityPerUnit.AutoSize = true;
			this.lblQuantityPerUnit.Location = new System.Drawing.Point(311, 62);
			this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
			this.lblQuantityPerUnit.Size = new System.Drawing.Size(59, 13);
			this.lblQuantityPerUnit.TabIndex = 8;
			this.lblQuantityPerUnit.Text = "Birim Adedi";
			// 
			// tbxQuantityPerUnit
			// 
			this.tbxQuantityPerUnit.Location = new System.Drawing.Point(376, 59);
			this.tbxQuantityPerUnit.Name = "tbxQuantityPerUnit";
			this.tbxQuantityPerUnit.Size = new System.Drawing.Size(121, 20);
			this.tbxQuantityPerUnit.TabIndex = 9;
			// 
			// cbxCategoryId
			// 
			this.cbxCategoryId.FormattingEnabled = true;
			this.cbxCategoryId.Location = new System.Drawing.Point(74, 62);
			this.cbxCategoryId.Name = "cbxCategoryId";
			this.cbxCategoryId.Size = new System.Drawing.Size(121, 21);
			this.cbxCategoryId.TabIndex = 10;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(376, 90);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(121, 24);
			this.btnAdd.TabIndex = 11;
			this.btnAdd.Text = "Ekle";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnUpdate);
			this.groupBox1.Controls.Add(this.tbxQuantityPerUnitUpdate);
			this.groupBox1.Controls.Add(this.tbxUnitsInStockUpdate);
			this.groupBox1.Controls.Add(this.tbxUnitPriceUpdate);
			this.groupBox1.Controls.Add(this.cbxCategoryIdUpdate);
			this.groupBox1.Controls.Add(this.tbxProductNameUpdate);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Location = new System.Drawing.Point(61, 549);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
			this.groupBox1.Size = new System.Drawing.Size(669, 141);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ürün güncelle";
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(359, 93);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(1);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(135, 25);
			this.btnUpdate.TabIndex = 10;
			this.btnUpdate.Text = "Güncelle";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// tbxQuantityPerUnitUpdate
			// 
			this.tbxQuantityPerUnitUpdate.Location = new System.Drawing.Point(359, 60);
			this.tbxQuantityPerUnitUpdate.Margin = new System.Windows.Forms.Padding(1);
			this.tbxQuantityPerUnitUpdate.Name = "tbxQuantityPerUnitUpdate";
			this.tbxQuantityPerUnitUpdate.Size = new System.Drawing.Size(138, 20);
			this.tbxQuantityPerUnitUpdate.TabIndex = 9;
			// 
			// tbxUnitsInStockUpdate
			// 
			this.tbxUnitsInStockUpdate.Location = new System.Drawing.Point(359, 21);
			this.tbxUnitsInStockUpdate.Margin = new System.Windows.Forms.Padding(1);
			this.tbxUnitsInStockUpdate.Name = "tbxUnitsInStockUpdate";
			this.tbxUnitsInStockUpdate.Size = new System.Drawing.Size(138, 20);
			this.tbxUnitsInStockUpdate.TabIndex = 8;
			// 
			// tbxUnitPriceUpdate
			// 
			this.tbxUnitPriceUpdate.Location = new System.Drawing.Point(68, 95);
			this.tbxUnitPriceUpdate.Margin = new System.Windows.Forms.Padding(1);
			this.tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
			this.tbxUnitPriceUpdate.Size = new System.Drawing.Size(164, 20);
			this.tbxUnitPriceUpdate.TabIndex = 7;
			// 
			// cbxCategoryIdUpdate
			// 
			this.cbxCategoryIdUpdate.FormattingEnabled = true;
			this.cbxCategoryIdUpdate.Location = new System.Drawing.Point(68, 60);
			this.cbxCategoryIdUpdate.Margin = new System.Windows.Forms.Padding(1);
			this.cbxCategoryIdUpdate.Name = "cbxCategoryIdUpdate";
			this.cbxCategoryIdUpdate.Size = new System.Drawing.Size(164, 21);
			this.cbxCategoryIdUpdate.TabIndex = 6;
			// 
			// tbxProductNameUpdate
			// 
			this.tbxProductNameUpdate.Location = new System.Drawing.Point(68, 21);
			this.tbxProductNameUpdate.Margin = new System.Windows.Forms.Padding(1);
			this.tbxProductNameUpdate.Name = "tbxProductNameUpdate";
			this.tbxProductNameUpdate.Size = new System.Drawing.Size(164, 20);
			this.tbxProductNameUpdate.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(289, 63);
			this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Birim Adedi";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(289, 23);
			this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Stok Adedi";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 98);
			this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Fiyat";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(7, 63);
			this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "Kategori";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(7, 23);
			this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Ürün Adı";
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(636, 317);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(94, 36);
			this.btnDelete.TabIndex = 13;
			this.btnDelete.Text = "Sil";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.UseWaitCursor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(765, 730);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.gbxProductAdd);
			this.Controls.Add(this.gbxCategory);
			this.Controls.Add(this.gbxProductName);
			this.Controls.Add(this.dgwProduct);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.gbxCategory.ResumeLayout(false);
			this.gbxCategory.PerformLayout();
			this.gbxProductName.ResumeLayout(false);
			this.gbxProductName.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
			this.gbxProductAdd.ResumeLayout(false);
			this.gbxProductAdd.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbxCategory;
		private System.Windows.Forms.ComboBox cbxCategory;
		private System.Windows.Forms.Label lblCategory;
		private System.Windows.Forms.GroupBox gbxProductName;
		private System.Windows.Forms.TextBox tbxProductName;
		private System.Windows.Forms.Label lblProductName;
		private System.Windows.Forms.DataGridView dgwProduct;
		private System.Windows.Forms.GroupBox gbxProductAdd;
		private System.Windows.Forms.ComboBox cbxCategoryId;
		private System.Windows.Forms.TextBox tbxQuantityPerUnit;
		private System.Windows.Forms.Label lblQuantityPerUnit;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblUnitPrice;
		private System.Windows.Forms.Label lblCategoryID;
		private System.Windows.Forms.Label lblProductName2;
		private System.Windows.Forms.TextBox tbxUnitPrice;
		private System.Windows.Forms.TextBox tbxStock;
		private System.Windows.Forms.TextBox tbxProductName2;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.TextBox tbxQuantityPerUnitUpdate;
		private System.Windows.Forms.TextBox tbxUnitsInStockUpdate;
		private System.Windows.Forms.TextBox tbxUnitPriceUpdate;
		private System.Windows.Forms.ComboBox cbxCategoryIdUpdate;
		private System.Windows.Forms.TextBox tbxProductNameUpdate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnDelete;
	}
}

