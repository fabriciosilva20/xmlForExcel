using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;

namespace XmlForExcel
{
  public partial class frmMigrarXmlExcel : Form
  {
    public frmMigrarXmlExcel()
    {
      InitializeComponent();
    }

    private void btnBrowseFolder_Click(object sender, EventArgs e)
    {


      DialogResult drResult = OFD.ShowDialog();
      if (drResult == DialogResult.OK)
        txtXmlFilePath.Text = OFD.FileName;
    }

    private void btnConvert_Click(object sender, EventArgs e)
    {
      try
      {


        if (txtXmlFilePath.Text != "") // sem usar nome padrao
        {
          // start progressbar

          var Total = OFD.FileNames.Count();
          int i = 0;
          foreach (String file in OFD.FileNames)
          {
            
            progressBar1.Value = 0;

            //if (chkCustomeName.Checked && txtCustomeFileName.Text != "" && txtXmlFilePath.Text != "") // Verifica se usa o nome selecionado
            //{
            //  if (File.Exists(txtXmlFilePath.Text)) // verifica se existe o arquivo xml
            //  {
            //    string CustXmlFilePath = Path.Combine(new FileInfo(txtXmlFilePath.Text).DirectoryName, txtCustomeFileName.Text); // verifica pasta para o xml
            //    System.Data.DataTable dt = CreateDataTableFromXml(txtXmlFilePath.Text);
            //    ExportDataTableToExcel(dt, CustXmlFilePath);

            //  }

            //} 
            //else

            if (File.Exists(file)) // verifica se existe o arquivo xml
            {
              FileInfo fi = new FileInfo(file);
              string XlFile = fi.DirectoryName + "\\" + fi.Name.Replace(fi.Extension, ".xlsx");
              System.Data.DataTable dt = CreateDataTableFromXml(file);
              ExportDataTableToExcel(dt, XlFile);


            }

            i += 1;
            lblQtdArquivos.Text = i+"/" + Total + " arquivo(s) convertido(s).";

          }
        }
        else
        {
          MessageBox.Show("Preencha os campos obrigatórios!!");
          return;
        }

        MessageBox.Show("Conversão completa!");
      }
      catch (Exception ex)
      {
        MessageBox.Show("ocorreu um erro!" + ex.Message);
        throw;
      }
    }


    // Criando DataTable Com dados do xml
    public System.Data.DataTable CreateDataTableFromXml(string XmlFile)
    {

      System.Data.DataTable Dt = new System.Data.DataTable();
      try
      {
        DataSet ds = new DataSet();
        ds.ReadXml(XmlFile);
        Dt.Load(ds.CreateDataReader());

      }
      catch (Exception ex)
      {

      }
      return Dt;
    }

    private void ExportDataTableToExcel(System.Data.DataTable table, string Xlfile)
    {

      Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
      Workbook book = excel.Application.Workbooks.Add(Type.Missing);
      excel.Visible = false;
      excel.DisplayAlerts = false;
      Worksheet excelWorkSheet = (Worksheet)book.ActiveSheet;
      excelWorkSheet.Name = table.TableName;

      progressBar1.Maximum = table.Columns.Count;
      for (int i = 1; i < table.Columns.Count + 1; i++) // Criando as colunas no excel
      {
        excelWorkSheet.Cells[1, i] = table.Columns[i - 1].ColumnName;
        if (progressBar1.Value < progressBar1.Maximum)
        {
          progressBar1.Value++;
          int percent = (int)(((double)progressBar1.Value / (double)progressBar1.Maximum) * 100);
          progressBar1.CreateGraphics().DrawString(percent.ToString() + "%", new System.Drawing.Font("Arial", (float)8.25, FontStyle.Regular), Brushes.Black, new PointF(progressBar1.Width / 2 - 10, progressBar1.Height / 2 - 7));
          System.Windows.Forms.Application.DoEvents();
        }
      }


      progressBar1.Maximum = table.Rows.Count;
      for (int j = 0; j < table.Rows.Count; j++) // Exportando as linhas para o excel
      {
        for (int k = 0; k < table.Columns.Count; k++)
        {
          excelWorkSheet.Cells[j + 2, k + 1] = table.Rows[j].ItemArray[k].ToString();
        }

        if (progressBar1.Value < progressBar1.Maximum)
        {
          progressBar1.Value++;
          int percent = (int)(((double)progressBar1.Value / (double)progressBar1.Maximum) * 100);
          progressBar1.CreateGraphics().DrawString(percent.ToString() + "%", new System.Drawing.Font("Arial", (float)8.25, FontStyle.Regular), Brushes.Black, new PointF(progressBar1.Width / 2 - 10, progressBar1.Height / 2 - 7));
          System.Windows.Forms.Application.DoEvents();
        }
      }


      book.SaveAs(Xlfile);
      book.Close(true);
      excel.Quit();

      Marshal.ReleaseComObject(book);
      Marshal.ReleaseComObject(book);
      Marshal.ReleaseComObject(excel);

    }

    private void OFD_FileOk(object sender, CancelEventArgs e)
    {
      lblQtdArquivos.Text = OFD.FileNames.Count() + " arquivo(s) selecionado(s).";
    }
  }
}
