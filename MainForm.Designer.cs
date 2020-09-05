namespace LabelApp
{
  partial class MainForm
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
      this.btnRefresh = new System.Windows.Forms.Button();
      this.btnSearch = new System.Windows.Forms.Button();
      this.txtSearch = new System.Windows.Forms.TextBox();
      this.dgItem = new System.Windows.Forms.DataGridView();
      this.btnNew = new System.Windows.Forms.Button();
      this.gbForm = new System.Windows.Forms.GroupBox();
      this.txtItemIdOld = new System.Windows.Forms.TextBox();
      this.btnDelete = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.txtItemChinese = new System.Windows.Forms.TextBox();
      this.lblItemChinese = new System.Windows.Forms.Label();
      this.txtItemName3 = new System.Windows.Forms.TextBox();
      this.lblItemName3 = new System.Windows.Forms.Label();
      this.txtItemName2 = new System.Windows.Forms.TextBox();
      this.lblItemName2 = new System.Windows.Forms.Label();
      this.txtItemName1 = new System.Windows.Forms.TextBox();
      this.lblItemName1 = new System.Windows.Forms.Label();
      this.txtItemId = new System.Windows.Forms.TextBox();
      this.lblItemId = new System.Windows.Forms.Label();
      this.gbPrint = new System.Windows.Forms.GroupBox();
      this.btnPrint = new System.Windows.Forms.Button();
      this.txtNumPrint = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgItem)).BeginInit();
      this.gbForm.SuspendLayout();
      this.gbPrint.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtNumPrint)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnRefresh);
      this.groupBox1.Controls.Add(this.btnSearch);
      this.groupBox1.Controls.Add(this.txtSearch);
      this.groupBox1.Controls.Add(this.dgItem);
      this.groupBox1.Controls.Add(this.btnNew);
      this.groupBox1.Location = new System.Drawing.Point(2, 1);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(596, 407);
      this.groupBox1.TabIndex = 5;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Data Barang";
      // 
      // btnRefresh
      // 
      this.btnRefresh.Location = new System.Drawing.Point(519, 19);
      this.btnRefresh.Name = "btnRefresh";
      this.btnRefresh.Size = new System.Drawing.Size(70, 23);
      this.btnRefresh.TabIndex = 9;
      this.btnRefresh.Text = "REFRESH";
      this.btnRefresh.UseVisualStyleBackColor = true;
      this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
      // 
      // btnSearch
      // 
      this.btnSearch.Location = new System.Drawing.Point(463, 19);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(50, 23);
      this.btnSearch.TabIndex = 8;
      this.btnSearch.Text = "CARI";
      this.btnSearch.UseVisualStyleBackColor = true;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // txtSearch
      // 
      this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtSearch.Location = new System.Drawing.Point(295, 20);
      this.txtSearch.Name = "txtSearch";
      this.txtSearch.Size = new System.Drawing.Size(162, 22);
      this.txtSearch.TabIndex = 7;
      // 
      // dgItem
      // 
      this.dgItem.AllowUserToAddRows = false;
      this.dgItem.AllowUserToDeleteRows = false;
      this.dgItem.AllowUserToResizeColumns = false;
      this.dgItem.AllowUserToResizeRows = false;
      this.dgItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgItem.Location = new System.Drawing.Point(7, 48);
      this.dgItem.MultiSelect = false;
      this.dgItem.Name = "dgItem";
      this.dgItem.ReadOnly = true;
      this.dgItem.RowHeadersVisible = false;
      this.dgItem.Size = new System.Drawing.Size(582, 351);
      this.dgItem.TabIndex = 6;
      this.dgItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgItem_CellClick);
      this.dgItem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgItem_CellDoubleClick);
      // 
      // btnNew
      // 
      this.btnNew.Location = new System.Drawing.Point(7, 19);
      this.btnNew.Name = "btnNew";
      this.btnNew.Size = new System.Drawing.Size(107, 23);
      this.btnNew.TabIndex = 5;
      this.btnNew.Text = "TAMBAH BARU";
      this.btnNew.UseVisualStyleBackColor = true;
      this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
      // 
      // gbForm
      // 
      this.gbForm.Controls.Add(this.txtItemIdOld);
      this.gbForm.Controls.Add(this.btnDelete);
      this.gbForm.Controls.Add(this.btnCancel);
      this.gbForm.Controls.Add(this.btnSave);
      this.gbForm.Controls.Add(this.txtItemChinese);
      this.gbForm.Controls.Add(this.lblItemChinese);
      this.gbForm.Controls.Add(this.txtItemName3);
      this.gbForm.Controls.Add(this.lblItemName3);
      this.gbForm.Controls.Add(this.txtItemName2);
      this.gbForm.Controls.Add(this.lblItemName2);
      this.gbForm.Controls.Add(this.txtItemName1);
      this.gbForm.Controls.Add(this.lblItemName1);
      this.gbForm.Controls.Add(this.txtItemId);
      this.gbForm.Controls.Add(this.lblItemId);
      this.gbForm.Location = new System.Drawing.Point(604, 1);
      this.gbForm.Name = "gbForm";
      this.gbForm.Size = new System.Drawing.Size(402, 184);
      this.gbForm.TabIndex = 6;
      this.gbForm.TabStop = false;
      this.gbForm.Text = "Form Barang";
      // 
      // txtItemIdOld
      // 
      this.txtItemIdOld.Enabled = false;
      this.txtItemIdOld.Location = new System.Drawing.Point(29, 152);
      this.txtItemIdOld.Name = "txtItemIdOld";
      this.txtItemIdOld.Size = new System.Drawing.Size(66, 20);
      this.txtItemIdOld.TabIndex = 13;
      this.txtItemIdOld.Visible = false;
      // 
      // btnDelete
      // 
      this.btnDelete.Enabled = false;
      this.btnDelete.Location = new System.Drawing.Point(318, 152);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(75, 23);
      this.btnDelete.TabIndex = 12;
      this.btnDelete.Text = "HAPUS";
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Enabled = false;
      this.btnCancel.Location = new System.Drawing.Point(182, 152);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 11;
      this.btnCancel.Text = "BATAL";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnSave
      // 
      this.btnSave.Enabled = false;
      this.btnSave.Location = new System.Drawing.Point(101, 152);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.TabIndex = 10;
      this.btnSave.Text = "SIMPAN";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // txtItemChinese
      // 
      this.txtItemChinese.Enabled = false;
      this.txtItemChinese.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
      this.txtItemChinese.Location = new System.Drawing.Point(101, 126);
      this.txtItemChinese.Name = "txtItemChinese";
      this.txtItemChinese.Size = new System.Drawing.Size(292, 20);
      this.txtItemChinese.TabIndex = 9;
      // 
      // lblItemChinese
      // 
      this.lblItemChinese.AutoSize = true;
      this.lblItemChinese.Location = new System.Drawing.Point(32, 129);
      this.lblItemChinese.Name = "lblItemChinese";
      this.lblItemChinese.Size = new System.Drawing.Size(63, 13);
      this.lblItemChinese.TabIndex = 8;
      this.lblItemChinese.Text = "Huruf China";
      // 
      // txtItemName3
      // 
      this.txtItemName3.Enabled = false;
      this.txtItemName3.Location = new System.Drawing.Point(101, 100);
      this.txtItemName3.Name = "txtItemName3";
      this.txtItemName3.Size = new System.Drawing.Size(292, 20);
      this.txtItemName3.TabIndex = 7;
      // 
      // lblItemName3
      // 
      this.lblItemName3.AutoSize = true;
      this.lblItemName3.Location = new System.Drawing.Point(14, 103);
      this.lblItemName3.Name = "lblItemName3";
      this.lblItemName3.Size = new System.Drawing.Size(81, 13);
      this.lblItemName3.TabIndex = 6;
      this.lblItemName3.Text = "Nama Barang 3";
      // 
      // txtItemName2
      // 
      this.txtItemName2.Enabled = false;
      this.txtItemName2.Location = new System.Drawing.Point(101, 74);
      this.txtItemName2.Name = "txtItemName2";
      this.txtItemName2.Size = new System.Drawing.Size(292, 20);
      this.txtItemName2.TabIndex = 5;
      // 
      // lblItemName2
      // 
      this.lblItemName2.AutoSize = true;
      this.lblItemName2.Location = new System.Drawing.Point(14, 77);
      this.lblItemName2.Name = "lblItemName2";
      this.lblItemName2.Size = new System.Drawing.Size(81, 13);
      this.lblItemName2.TabIndex = 4;
      this.lblItemName2.Text = "Nama Barang 2";
      // 
      // txtItemName1
      // 
      this.txtItemName1.Enabled = false;
      this.txtItemName1.Location = new System.Drawing.Point(101, 48);
      this.txtItemName1.Name = "txtItemName1";
      this.txtItemName1.Size = new System.Drawing.Size(292, 20);
      this.txtItemName1.TabIndex = 3;
      // 
      // lblItemName1
      // 
      this.lblItemName1.AutoSize = true;
      this.lblItemName1.Location = new System.Drawing.Point(14, 51);
      this.lblItemName1.Name = "lblItemName1";
      this.lblItemName1.Size = new System.Drawing.Size(81, 13);
      this.lblItemName1.TabIndex = 2;
      this.lblItemName1.Text = "Nama Barang 1";
      // 
      // txtItemId
      // 
      this.txtItemId.Enabled = false;
      this.txtItemId.Location = new System.Drawing.Point(101, 21);
      this.txtItemId.Name = "txtItemId";
      this.txtItemId.Size = new System.Drawing.Size(292, 20);
      this.txtItemId.TabIndex = 1;
      // 
      // lblItemId
      // 
      this.lblItemId.AutoSize = true;
      this.lblItemId.Location = new System.Drawing.Point(26, 25);
      this.lblItemId.Name = "lblItemId";
      this.lblItemId.Size = new System.Drawing.Size(69, 13);
      this.lblItemId.TabIndex = 0;
      this.lblItemId.Text = "Kode Barang";
      // 
      // gbPrint
      // 
      this.gbPrint.Controls.Add(this.btnPrint);
      this.gbPrint.Controls.Add(this.txtNumPrint);
      this.gbPrint.Controls.Add(this.label1);
      this.gbPrint.Location = new System.Drawing.Point(609, 195);
      this.gbPrint.Name = "gbPrint";
      this.gbPrint.Size = new System.Drawing.Size(388, 51);
      this.gbPrint.TabIndex = 7;
      this.gbPrint.TabStop = false;
      this.gbPrint.Text = "Form Cetak";
      this.gbPrint.Visible = false;
      // 
      // btnPrint
      // 
      this.btnPrint.Location = new System.Drawing.Point(177, 17);
      this.btnPrint.Name = "btnPrint";
      this.btnPrint.Size = new System.Drawing.Size(75, 23);
      this.btnPrint.TabIndex = 12;
      this.btnPrint.Text = "CETAK";
      this.btnPrint.UseVisualStyleBackColor = true;
      this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
      // 
      // txtNumPrint
      // 
      this.txtNumPrint.Location = new System.Drawing.Point(96, 19);
      this.txtNumPrint.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.txtNumPrint.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.txtNumPrint.Name = "txtNumPrint";
      this.txtNumPrint.ReadOnly = true;
      this.txtNumPrint.Size = new System.Drawing.Size(75, 20);
      this.txtNumPrint.TabIndex = 11;
      this.txtNumPrint.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(27, 22);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(66, 13);
      this.label1.TabIndex = 10;
      this.label1.Text = "Jumlah Baris";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1009, 412);
      this.Controls.Add(this.gbPrint);
      this.Controls.Add(this.gbForm);
      this.Controls.Add(this.groupBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "APLIKASI LABEL BARANG";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgItem)).EndInit();
      this.gbForm.ResumeLayout(false);
      this.gbForm.PerformLayout();
      this.gbPrint.ResumeLayout(false);
      this.gbPrint.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtNumPrint)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnRefresh;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.TextBox txtSearch;
    private System.Windows.Forms.DataGridView dgItem;
    private System.Windows.Forms.Button btnNew;
    private System.Windows.Forms.GroupBox gbForm;
    private System.Windows.Forms.TextBox txtItemChinese;
    private System.Windows.Forms.Label lblItemChinese;
    private System.Windows.Forms.TextBox txtItemName3;
    private System.Windows.Forms.Label lblItemName3;
    private System.Windows.Forms.TextBox txtItemName2;
    private System.Windows.Forms.Label lblItemName2;
    private System.Windows.Forms.TextBox txtItemName1;
    private System.Windows.Forms.Label lblItemName1;
    private System.Windows.Forms.TextBox txtItemId;
    private System.Windows.Forms.Label lblItemId;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.TextBox txtItemIdOld;
    private System.Windows.Forms.GroupBox gbPrint;
    private System.Windows.Forms.NumericUpDown txtNumPrint;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnPrint;
  }
}

