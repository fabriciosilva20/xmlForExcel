namespace XmlForExcel
{
  partial class frmMigrarXmlExcel
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
      this.btnBrowseFolder = new System.Windows.Forms.Button();
      this.txtXmlFilePath = new System.Windows.Forms.TextBox();
      this.btnConvert = new System.Windows.Forms.Button();
      this.OFD = new System.Windows.Forms.OpenFileDialog();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.lblQtdArquivos = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(14, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(118, 13);
      this.label1.TabIndex = 27;
      this.label1.Text = "Selecione Arquivo XML";
      // 
      // btnBrowseFolder
      // 
      this.btnBrowseFolder.Location = new System.Drawing.Point(236, 27);
      this.btnBrowseFolder.Name = "btnBrowseFolder";
      this.btnBrowseFolder.Size = new System.Drawing.Size(29, 23);
      this.btnBrowseFolder.TabIndex = 26;
      this.btnBrowseFolder.Text = "...";
      this.btnBrowseFolder.UseVisualStyleBackColor = true;
      this.btnBrowseFolder.Click += new System.EventHandler(this.btnBrowseFolder_Click);
      // 
      // txtXmlFilePath
      // 
      this.txtXmlFilePath.Location = new System.Drawing.Point(14, 29);
      this.txtXmlFilePath.Name = "txtXmlFilePath";
      this.txtXmlFilePath.Size = new System.Drawing.Size(218, 20);
      this.txtXmlFilePath.TabIndex = 25;
      // 
      // btnConvert
      // 
      this.btnConvert.Location = new System.Drawing.Point(14, 55);
      this.btnConvert.Name = "btnConvert";
      this.btnConvert.Size = new System.Drawing.Size(63, 23);
      this.btnConvert.TabIndex = 24;
      this.btnConvert.Text = "Converter";
      this.btnConvert.UseVisualStyleBackColor = true;
      this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
      // 
      // OFD
      // 
      this.OFD.Filter = "XML File (*.xml)|*.xml|All files (*.*)|*.*";
      this.OFD.Multiselect = true;
      this.OFD.FileOk += new System.ComponentModel.CancelEventHandler(this.OFD_FileOk);
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(1, 117);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(315, 23);
      this.progressBar1.TabIndex = 30;
      // 
      // lblQtdArquivos
      // 
      this.lblQtdArquivos.AutoSize = true;
      this.lblQtdArquivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblQtdArquivos.ForeColor = System.Drawing.Color.Red;
      this.lblQtdArquivos.Location = new System.Drawing.Point(4, 97);
      this.lblQtdArquivos.Name = "lblQtdArquivos";
      this.lblQtdArquivos.Size = new System.Drawing.Size(52, 17);
      this.lblQtdArquivos.TabIndex = 31;
      this.lblQtdArquivos.Text = "           ";
      // 
      // frmMigrarXmlExcel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(315, 140);
      this.Controls.Add(this.lblQtdArquivos);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnBrowseFolder);
      this.Controls.Add(this.txtXmlFilePath);
      this.Controls.Add(this.btnConvert);
      this.Controls.Add(this.progressBar1);
      this.Name = "frmMigrarXmlExcel";
      this.Text = "XML --->> EXCEL";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowseFolder;
        private System.Windows.Forms.TextBox txtXmlFilePath;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblQtdArquivos;
    }
}