using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesTemPal;

namespace WindowsFormsApp1
{
  public partial class Form1 : Form
  {

    Paleta _miPaleta;

    public Form1()
    {
      InitializeComponent();
      this._miPaleta = 5;
      this.groupBox1.Text = "Paleta de Colores";
      this.textBox1.Multiline = true;
      this.btnAceptar.Text = "+";
      this.btnCancelar.Text = "-";
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      FrmTempera frm = new FrmTempera();
      DialogResult rta = frm.ShowDialog();

      if (rta == DialogResult.OK)
      {
        this._miPaleta += frm.MiTempera;
        this.textBox1.Text = (string)this._miPaleta;
      }
    }

    private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {

    }

    private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
    {

    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {
      
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void agregarPaletaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.groupBox1.Visible = true;
      this.agregarPaletaToolStripMenuItem.Enabled = false; 
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      int i = 0;
      string tempera = "";
      string seleccionado = "";
      string[] todoElTexto = textBox1.Lines;
      seleccionado = textBox1.SelectedText;

      for (i = 2; i < textBox1.Lines.Count(); i++)
      {
          if (todoElTexto[i] == seleccionado)
          {
              i -= 2;
              MessageBox.Show("\nTempera seleccionada: " + seleccionado + "\nIndice: " + i);
              break;
          }
      }
      FrmTempera frm = new FrmTempera(_miPaleta[i]);
      DialogResult resultado = frm.ShowDialog();

    }

    }
}
