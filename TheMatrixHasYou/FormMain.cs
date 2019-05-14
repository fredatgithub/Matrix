using System;
using System.Drawing;
using System.Windows.Forms;

namespace TheMatrixHasYou
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private readonly string[] _texte = {"Wake up Neo ....", "The Matrix has you ....", "Follow the white rabbit ....", "Knock knock ...." };
    private int _numeroChaine;
    private int _nombreDeChaineTotal = 0;
    private int _curseurChaine;

    private void FormMain_Load(object sender, EventArgs e)
    {
      labelMatrix.ForeColor = Color.Green;
      labelMatrix.Size = new Size(new Point(14));
      labelMatrix.Text = string.Empty;
      _nombreDeChaineTotal = _texte.Length;
      timer1.Interval = 200;
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
      labelMatrix.Text += _texte[_numeroChaine].Substring(_curseurChaine, 1);

      if (_curseurChaine >= _texte[_numeroChaine].Length - 1)
      {
        labelMatrix.Text = string.Empty;
        if (_numeroChaine + 1 >= _texte.Length)
        {
          _numeroChaine = 0;
          _curseurChaine = 0;
        }
        else
        {
          _numeroChaine++;
          _curseurChaine = 0;
        }
      }
      else
      {
        _curseurChaine++;
      }
    }
  }
}
