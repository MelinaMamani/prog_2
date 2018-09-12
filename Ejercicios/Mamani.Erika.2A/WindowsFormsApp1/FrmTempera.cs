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
  public partial class FrmTempera : Form
  {
    private Tempera _miTempera;

    public Tempera MiTempera
    {
      get { return this._miTempera; }
      }


    public FrmTempera()
    {
      InitializeComponent();

      foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
      {
        this.comboBox1.Items.Add(color);
      }

      this.comboBox1.SelectedItem = ConsoleColor.Blue;
      this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      this._miTempera = new Tempera(sbyte.Parse(this.textBox2.Text),(ConsoleColor)this.comboBox1.SelectedItem,this.textBox1.Text);
      this.DialogResult = DialogResult.OK;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
    }
  }
}
