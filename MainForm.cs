using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace LabelApp
{
  public partial class MainForm : Form
  {
    OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=labelbarang.accdb");

    public MainForm()
    {
      InitializeComponent();
      initialize_dg();
      show_data();
    }

    private void initialize_dg() {
      DataGridViewColumn itemId = new DataGridViewTextBoxColumn();
      itemId.DataPropertyName = "itemId";
      itemId.HeaderText = "Kode Barang";
      itemId.Name = "itemId";
      itemId.Width = 100;
      dgItem.Columns.Add(itemId);

      DataGridViewColumn itemName1 = new DataGridViewTextBoxColumn();
      itemName1.DataPropertyName = "itemName1";
      itemName1.HeaderText = "Nama Barang 1";
      itemName1.Name = "itemName1";
      itemName1.Width = 120;
      dgItem.Columns.Add(itemName1);

      DataGridViewColumn itemName2 = new DataGridViewTextBoxColumn();
      itemName2.DataPropertyName = "itemName2";
      itemName2.HeaderText = "Nama Barang 2";
      itemName2.Name = "itemName2";
      itemName2.Width = 120;
      dgItem.Columns.Add(itemName2);

      DataGridViewColumn itemName3 = new DataGridViewTextBoxColumn();
      itemName3.DataPropertyName = "itemName3";
      itemName3.HeaderText = "Nama Barang 3";
      itemName3.Name = "itemName3";
      itemName3.Width = 120;
      dgItem.Columns.Add(itemName3);

      DataGridViewColumn itemChinese = new DataGridViewTextBoxColumn();
      itemChinese.DataPropertyName = "itemChinese";
      itemChinese.HeaderText = "Huruf China";
      itemChinese.Name = "itemChinese";
      itemChinese.Width = 100;
      dgItem.Columns.Add(itemChinese);
    }

    private void show_data() {
      String search = txtSearch.Text;
      search = search.Replace("'", "''");
      dgItem.Rows.Clear();

      try
      {
        conn.Open();
        String query = "SELECT * FROM items WHERE item_name_1 LIKE '%"+search+ "%' OR item_name_2 LIKE '%" + search + "%' OR item_name_3 LIKE '%" + search + "%'";
        OleDbCommand cmd = new OleDbCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = query;
        cmd.Connection = conn;

        OleDbDataReader reader = cmd.ExecuteReader();
        if (reader.HasRows)
        {
          while (reader.Read())
          {
            int i = dgItem.Rows.Add();
            dgItem.Rows[i].Cells[0].Value = reader["item_id"].ToString();
            dgItem.Rows[i].Cells[1].Value = reader["item_name_1"].ToString();
            dgItem.Rows[i].Cells[2].Value = reader["item_name_2"].ToString();
            dgItem.Rows[i].Cells[3].Value = reader["item_name_3"].ToString();
            dgItem.Rows[i].Cells[4].Value = reader["item_chinese"].ToString();
          }
        }
        reader.Close();
        conn.Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString(), "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    private void save_item()
    {
      String itemId = txtItemId.Text.Replace("'", "''");
      String itemIdOld = txtItemIdOld.Text.Replace("'", "''");
      String itemName1 = txtItemName1.Text.Replace("'", "''");
      String itemName2 = txtItemName2.Text.Replace("'", "''");
      String itemName3 = txtItemName3.Text.Replace("'", "''");
      String itemChinese = txtItemChinese.Text.Replace("'", "''");

      //validasi form
      if (itemId == "" || itemName1 == "" || itemName2 == "" || itemName3 == "" || itemChinese == "") {
        MessageBox.Show("Semua kolom tidak boleh kosong", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
      else
      {
        if (itemIdOld == "")
        {
          //insert new item
          if (check_id(itemId))
          {
            MessageBox.Show("Kode Barang sudah ada di sistem!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          }
          else
          {
            try
            {
              conn.Open();
              String query = "INSERT INTO items (item_id, item_name_1, item_name_2, item_name_3, item_chinese) VALUES (@itemId, @itemName1, @itemName2, @itemName3, itemChinese)";
              OleDbCommand cmd = new OleDbCommand();
              cmd.CommandType = CommandType.Text;
              cmd.CommandText = query;
              cmd.Parameters.AddWithValue("@itemId", itemId);
              cmd.Parameters.AddWithValue("@itemName1", itemName1);
              cmd.Parameters.AddWithValue("@itemName2", itemName2);
              cmd.Parameters.AddWithValue("@itemName3", itemName3);
              cmd.Parameters.AddWithValue("@itemChinese", itemChinese);
              cmd.Connection = conn;

              cmd.ExecuteNonQuery();
              conn.Close();
              MessageBox.Show("Data berhasil disimpan", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
              reset_item();
              show_data();
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.ToString(), "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          }
        }
        else
        {
          //update item
          if (txtItemId.Text == txtItemIdOld.Text) {
            update_data();
          }
          else
          {
            if (check_id(itemId))
            {
              MessageBox.Show("Kode Barang sudah ada di sistem!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
              update_data();
            }
          }
        }
      }
    }

    private void update_data() {
      String itemId = txtItemId.Text.Replace("'", "''"); ;
      String itemIdOld = txtItemIdOld.Text.Replace("'", "''"); ;
      String itemName1 = txtItemName1.Text.Replace("'", "''"); ;
      String itemName2 = txtItemName2.Text.Replace("'", "''"); ;
      String itemName3 = txtItemName3.Text.Replace("'", "''"); ;
      String itemChinese = txtItemChinese.Text.Replace("'", "''"); ;

      try
      {
        conn.Open();
        String query = "UPDATE items SET item_id = @itemId, item_name_1 = @itemName1, item_name_2 = @itemName2, item_name_3 = @itemName3, item_chinese = @itemChinese WHERE item_id = @itemIdOld";
        OleDbCommand cmd = new OleDbCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = query;
        cmd.Parameters.AddWithValue("@itemId", itemId);
        cmd.Parameters.AddWithValue("@itemName1", itemName1);
        cmd.Parameters.AddWithValue("@itemName2", itemName2);
        cmd.Parameters.AddWithValue("@itemName3", itemName3);
        cmd.Parameters.AddWithValue("@itemChinese", itemChinese);
        cmd.Parameters.AddWithValue("@itemIdOld", itemIdOld);
        cmd.Connection = conn;

        cmd.ExecuteNonQuery();
        conn.Close();
        MessageBox.Show("Data berhasil diubah", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
        reset_item();
        show_data();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString(), "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    private Boolean check_id(String itemId) {
      try
      {
        conn.Open();
        String query = @"SELECT * FROM items WHERE item_id = @param1";
        OleDbCommand cmd = new OleDbCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = query;
        cmd.Parameters.AddWithValue("@param1", itemId);
        cmd.Connection = conn;

        OleDbDataReader reader = cmd.ExecuteReader();
        if (reader.HasRows)
        {
          reader.Close();
          conn.Close();
          return true;
        }
        else
        {
          reader.Close();
          conn.Close();
          return false;
        }
      }
      catch(Exception ex) {
        MessageBox.Show(ex.ToString(), "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return false;
      }
    }

    private void new_item()
    {
      txtItemIdOld.Enabled = true;
      txtItemIdOld.Text = "";
      txtItemId.Enabled = true;
      txtItemId.Text = "";
      txtItemName1.Enabled = true;
      txtItemName1.Text = "";
      txtItemName2.Enabled = true;
      txtItemName2.Text = "";
      txtItemName3.Enabled = true;
      txtItemName3.Text = "";
      txtItemChinese.Enabled = true;
      txtItemChinese.Text = "";

      btnSave.Enabled = true;
      btnCancel.Enabled = true;
      btnDelete.Enabled = false;
    }

    private void reset_item()
    {
      txtItemIdOld.Enabled = false;
      txtItemIdOld.Text = "";
      txtItemId.Enabled = false;
      txtItemId.Text = "";
      txtItemName1.Enabled = false;
      txtItemName1.Text = "";
      txtItemName2.Enabled = false;
      txtItemName2.Text = "";
      txtItemName3.Enabled = false;
      txtItemName3.Text = "";
      txtItemChinese.Enabled = false;
      txtItemChinese.Text = "";

      btnSave.Enabled = false;
      btnCancel.Enabled = false;
      btnDelete.Enabled = false;      
    }

    private void btnNew_Click(object sender, EventArgs e)
    {
      new_item();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      reset_item();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      save_item();
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
      show_data();
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
      txtSearch.Text = "";
      show_data();
    }

    private void dgItem_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      int i = e.RowIndex;
      dgItem.Rows[i].Selected = true;
    }

    private void dgItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      int i = e.RowIndex;
      dgItem.Rows[i].Selected = true;
      String itemId = dgItem.Rows[i].Cells[0].Value.ToString();
      edit_data(itemId);
    }

    private void edit_data(String itemId) {
      try
      {
        conn.Open();
        String query = @"SELECT * FROM items WHERE item_id = @param1";
        OleDbCommand cmd = new OleDbCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = query;
        cmd.Parameters.AddWithValue("@param1", itemId);
        cmd.Connection = conn;

        OleDbDataReader reader = cmd.ExecuteReader();
        if (reader.HasRows)
        {
          while (reader.Read()) {
            txtItemId.Enabled = true;
            txtItemId.Text = reader["item_id"].ToString();
            txtItemIdOld.Enabled = true;
            txtItemIdOld.Text = reader["item_id"].ToString();
            txtItemName1.Enabled = true;
            txtItemName1.Text = reader["item_name_1"].ToString();
            txtItemName2.Enabled = true;
            txtItemName2.Text = reader["item_name_2"].ToString();
            txtItemName3.Enabled = true;
            txtItemName3.Text = reader["item_name_3"].ToString();
            txtItemChinese.Enabled = true;
            txtItemChinese.Text = reader["item_chinese"].ToString();

            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnDelete.Enabled = true;
          }
        }
        reader.Close();
        conn.Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString(), "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      DialogResult result = MessageBox.Show("Apakah Anda yakin menghapus data ini?\nAksi ini tidak bisa dikembalikan!", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
      if(result == DialogResult.Yes)
      {
        delete_data();
      }
    }

    private void delete_data() {
      try
      {
        conn.Open();
        String query = "DELETE FROM items WHERE item_id = @itemOldId";
        OleDbCommand cmd = new OleDbCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = query;
        cmd.Parameters.AddWithValue("@itemId", txtItemIdOld.Text);
        cmd.Connection = conn;

        cmd.ExecuteNonQuery();
        conn.Close();
        MessageBox.Show("Data berhasil dihapus", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
        reset_item();
        show_data();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString(), "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }
  }
}
