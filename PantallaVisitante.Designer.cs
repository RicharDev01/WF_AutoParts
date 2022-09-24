
namespace autoparts
{
  partial class PantallaVisitante
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaVisitante));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
      this.ltvProductos = new System.Windows.Forms.ListView();
      this.btnRegresar = new System.Windows.Forms.Button();
      this.btnAddCart = new System.Windows.Forms.Button();
      this.dgvCart = new System.Windows.Forms.DataGridView();
      this.txtTituloTotal = new System.Windows.Forms.Label();
      this.txtTotal = new System.Windows.Forms.Label();
      this.colNombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colDescripcionProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colPrecioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
      this.SuspendLayout();
      // 
      // ltvProductos
      // 
      this.ltvProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.ltvProductos.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.ltvProductos.ForeColor = System.Drawing.Color.Black;
      this.ltvProductos.HideSelection = false;
      this.ltvProductos.Location = new System.Drawing.Point(0, 111);
      this.ltvProductos.Margin = new System.Windows.Forms.Padding(5);
      this.ltvProductos.Name = "ltvProductos";
      this.ltvProductos.Size = new System.Drawing.Size(688, 484);
      this.ltvProductos.TabIndex = 0;
      this.ltvProductos.UseCompatibleStateImageBehavior = false;
      this.ltvProductos.View = System.Windows.Forms.View.SmallIcon;
      // 
      // btnRegresar
      // 
      this.btnRegresar.BackColor = System.Drawing.Color.Silver;
      this.btnRegresar.FlatAppearance.BorderSize = 0;
      this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnRegresar.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.btnRegresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
      this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
      this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnRegresar.Location = new System.Drawing.Point(12, 45);
      this.btnRegresar.Name = "btnRegresar";
      this.btnRegresar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
      this.btnRegresar.Size = new System.Drawing.Size(146, 43);
      this.btnRegresar.TabIndex = 2;
      this.btnRegresar.Text = "Regresar";
      this.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnRegresar.UseVisualStyleBackColor = false;
      this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
      // 
      // btnAddCart
      // 
      this.btnAddCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(188)))), ((int)(((byte)(80)))));
      this.btnAddCart.FlatAppearance.BorderSize = 0;
      this.btnAddCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAddCart.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.btnAddCart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
      this.btnAddCart.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCart.Image")));
      this.btnAddCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnAddCart.Location = new System.Drawing.Point(546, 45);
      this.btnAddCart.Name = "btnAddCart";
      this.btnAddCart.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
      this.btnAddCart.Size = new System.Drawing.Size(142, 43);
      this.btnAddCart.TabIndex = 1;
      this.btnAddCart.Text = "Agregar";
      this.btnAddCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnAddCart.UseVisualStyleBackColor = false;
      this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
      // 
      // dgvCart
      // 
      this.dgvCart.AllowUserToAddRows = false;
      this.dgvCart.AllowUserToDeleteRows = false;
      this.dgvCart.AllowUserToResizeColumns = false;
      this.dgvCart.AllowUserToResizeRows = false;
      dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Gray;
      dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
      this.dgvCart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
      this.dgvCart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
      this.dgvCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle10.BackColor = System.Drawing.Color.Gray;
      dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
      dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle10.NullValue = null;
      dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
      this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombreProducto,
            this.colDescripcionProducto,
            this.colPrecioProducto});
      dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
      dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgvCart.DefaultCellStyle = dataGridViewCellStyle14;
      this.dgvCart.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(188)))), ((int)(((byte)(50)))));
      this.dgvCart.Location = new System.Drawing.Point(748, 207);
      this.dgvCart.MultiSelect = false;
      this.dgvCart.Name = "dgvCart";
      this.dgvCart.ReadOnly = true;
      dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      dataGridViewCellStyle15.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
      this.dgvCart.RowHeadersVisible = false;
      this.dgvCart.RowHeadersWidth = 60;
      dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.dgvCart.RowsDefaultCellStyle = dataGridViewCellStyle16;
      this.dgvCart.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.dgvCart.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.dgvCart.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.dgvCart.Size = new System.Drawing.Size(454, 376);
      this.dgvCart.TabIndex = 3;
      // 
      // txtTituloTotal
      // 
      this.txtTituloTotal.AutoSize = true;
      this.txtTituloTotal.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtTituloTotal.ForeColor = System.Drawing.Color.White;
      this.txtTituloTotal.Location = new System.Drawing.Point(871, 45);
      this.txtTituloTotal.Name = "txtTituloTotal";
      this.txtTituloTotal.Size = new System.Drawing.Size(182, 36);
      this.txtTituloTotal.TabIndex = 4;
      this.txtTituloTotal.Text = "Total de compra";
      // 
      // txtTotal
      // 
      this.txtTotal.AutoSize = true;
      this.txtTotal.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(188)))), ((int)(((byte)(50)))));
      this.txtTotal.Location = new System.Drawing.Point(912, 88);
      this.txtTotal.Name = "txtTotal";
      this.txtTotal.Size = new System.Drawing.Size(0, 36);
      this.txtTotal.TabIndex = 4;
      // 
      // colNombreProducto
      // 
      dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(188)))), ((int)(((byte)(80)))));
      dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
      dataGridViewCellStyle11.NullValue = "null";
      dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(3);
      this.colNombreProducto.DefaultCellStyle = dataGridViewCellStyle11;
      this.colNombreProducto.DividerWidth = 2;
      this.colNombreProducto.FillWeight = 150F;
      this.colNombreProducto.HeaderText = "Producto";
      this.colNombreProducto.Name = "colNombreProducto";
      this.colNombreProducto.ReadOnly = true;
      this.colNombreProducto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.colNombreProducto.Width = 150;
      // 
      // colDescripcionProducto
      // 
      dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(3);
      this.colDescripcionProducto.DefaultCellStyle = dataGridViewCellStyle12;
      this.colDescripcionProducto.DividerWidth = 2;
      this.colDescripcionProducto.FillWeight = 150F;
      this.colDescripcionProducto.HeaderText = "Descripcion";
      this.colDescripcionProducto.Name = "colDescripcionProducto";
      this.colDescripcionProducto.ReadOnly = true;
      this.colDescripcionProducto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.colDescripcionProducto.Width = 150;
      // 
      // colPrecioProducto
      // 
      dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      dataGridViewCellStyle13.Format = "C2";
      dataGridViewCellStyle13.NullValue = "0";
      dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(3);
      this.colPrecioProducto.DefaultCellStyle = dataGridViewCellStyle13;
      this.colPrecioProducto.DividerWidth = 2;
      this.colPrecioProducto.FillWeight = 150F;
      this.colPrecioProducto.HeaderText = "Precio";
      this.colPrecioProducto.Name = "colPrecioProducto";
      this.colPrecioProducto.ReadOnly = true;
      this.colPrecioProducto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.colPrecioProducto.Width = 150;
      // 
      // PantallaVisitante
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
      this.ClientSize = new System.Drawing.Size(1199, 595);
      this.Controls.Add(this.txtTotal);
      this.Controls.Add(this.txtTituloTotal);
      this.Controls.Add(this.dgvCart);
      this.Controls.Add(this.btnAddCart);
      this.Controls.Add(this.btnRegresar);
      this.Controls.Add(this.ltvProductos);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "PantallaVisitante";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "AutoParts";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PantallaVisitante_FormClosing);
      this.Load += new System.EventHandler(this.PantallaVisitante_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListView ltvProductos;
    private System.Windows.Forms.Button btnRegresar;
    private System.Windows.Forms.Button btnAddCart;
    private System.Windows.Forms.DataGridView dgvCart;
    private System.Windows.Forms.Label txtTituloTotal;
    private System.Windows.Forms.Label txtTotal;
    private System.Windows.Forms.DataGridViewTextBoxColumn colNombreProducto;
    private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcionProducto;
    private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioProducto;
  }
}