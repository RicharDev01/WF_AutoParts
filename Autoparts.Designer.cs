
namespace autoparts
{
  partial class Autoparts
  {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autoparts));
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.btnSignin = new System.Windows.Forms.Button();
      this.inPassword = new autoparts.customTextBox.customBox();
      this.linkVisitante = new System.Windows.Forms.LinkLabel();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(125, 23);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(223, 155);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 1;
      this.pictureBox1.TabStop = false;
      // 
      // btnSignin
      // 
      this.btnSignin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(188)))), ((int)(((byte)(80)))));
      this.btnSignin.FlatAppearance.BorderSize = 0;
      this.btnSignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSignin.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.btnSignin.ForeColor = System.Drawing.Color.White;
      this.btnSignin.Location = new System.Drawing.Point(113, 312);
      this.btnSignin.Name = "btnSignin";
      this.btnSignin.Size = new System.Drawing.Size(250, 43);
      this.btnSignin.TabIndex = 2;
      this.btnSignin.Text = "INGRESAR";
      this.btnSignin.UseVisualStyleBackColor = false;
      this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
      // 
      // inPassword
      // 
      this.inPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
      this.inPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(188)))), ((int)(((byte)(80)))));
      this.inPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
      this.inPassword.BorderSize = 2;
      this.inPassword.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.inPassword.ForeColor = System.Drawing.Color.White;
      this.inPassword.Location = new System.Drawing.Point(113, 236);
      this.inPassword.Multiline = false;
      this.inPassword.Name = "inPassword";
      this.inPassword.Padding = new System.Windows.Forms.Padding(7);
      this.inPassword.PasswordChar = true;
      this.inPassword.Size = new System.Drawing.Size(250, 43);
      this.inPassword.TabIndex = 3;
      this.inPassword.Texts = "";
      this.inPassword.UnderlinedStyle = true;
      // 
      // linkVisitante
      // 
      this.linkVisitante.AutoSize = true;
      this.linkVisitante.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.linkVisitante.LinkColor = System.Drawing.Color.Aqua;
      this.linkVisitante.Location = new System.Drawing.Point(145, 376);
      this.linkVisitante.Name = "linkVisitante";
      this.linkVisitante.Size = new System.Drawing.Size(186, 28);
      this.linkVisitante.TabIndex = 4;
      this.linkVisitante.TabStop = true;
      this.linkVisitante.Text = "Ingresar como cliente";
      this.linkVisitante.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkVisitante_LinkClicked);
      // 
      // Autoparts
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
      this.ClientSize = new System.Drawing.Size(484, 461);
      this.Controls.Add(this.linkVisitante);
      this.Controls.Add(this.inPassword);
      this.Controls.Add(this.btnSignin);
      this.Controls.Add(this.pictureBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "Autoparts";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "AutoParts";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Autoparts_FormClosing);
      this.Load += new System.EventHandler(this.Autoparts_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Button btnSignin;
    private customTextBox.customBox inPassword;
    private System.Windows.Forms.LinkLabel linkVisitante;
  }
}

