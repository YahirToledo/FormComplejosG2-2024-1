using System;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace FormComplejosG2_2024_1
{
    public partial class Form1 : Form
    {
        Complejo c1;
        Complejo c2;
        Complejo c3;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            try
            {   
                if (txtbReal1.Text == "")
                {
                    throw new ApplicationException("La parte real del complejo 1 no debe estar vacia");
                }
                if (txtbImagnario1.Text == "")
                {
                    throw new ApplicationException("La parte imaginaria del complejo 1 no debe estar vacia");
                }
                if (txtbReal2.Text == "")
                {
                    throw new ApplicationException("La parte real del complejo 2 no debe estar vacia");
                }
                if (txtbImagnario2.Text == "")
                {
                    throw new ApplicationException("La parte imaginaria del complejo 2 no debe estar vacia");
                }
                c1 = new Complejo(float.Parse(txtbReal1.Text), float.Parse(txtbImagnario1.Text));
                c2 = new Complejo(float.Parse(txtbReal2.Text), float.Parse(txtbImagnario2.Text));
                c3 = c1 + c2;
                lbSuma.Text = c3.ToString();
                lbOperacion.Text = "+";
                errorProvider1.Clear();
                errorProvider2.Clear();
                errorProvider3.Clear();
                errorProvider4.Clear();
            }
            catch(ApplicationException error)
            {
                errorProvider1.SetError(txtbReal1, error.Message);
                errorProvider2.SetError(txtbImagnario1, error.Message);
                errorProvider3.SetError(txtbReal2, error.Message);
                errorProvider4.SetError(txtbImagnario2, error.Message);
            }
            catch(FormatException error)
            {
                MessageBox.Show("Error: Debes ingresar un numero");
            }
            catch(Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }
        private void btnConjugado_Click(object sender, EventArgs e)
        {
            lbSuma.Text = (~c3).ToString();
        }
        private void btnResta_Click(object sender, EventArgs e)
        {
            c1 = new Complejo(float.Parse(txtbReal1.Text), float.Parse(txtbImagnario1.Text));
            c2 = new Complejo(float.Parse(txtbReal2.Text), float.Parse(txtbImagnario2.Text));
            c3 = c1 - c2;
            lbSuma.Text = c3.ToString();
            lbOperacion.Text = "-";
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbReal1.Text == "")
                {
                    throw new ApplicationException("La parte real del complejo 1 no debe estar vacia");
                }
                if (txtbImagnario1.Text == "")
                {
                    throw new ApplicationException("La parte imaginaria del complejo 1 no debe estar vacia");
                }
                if (txtbReal2.Text == "")
                {
                    throw new ApplicationException("La parte real del complejo 2 no debe estar vacia");
                }
                if (txtbImagnario2.Text == "")
                {
                    throw new ApplicationException("La parte imaginaria del complejo 2 no debe estar vacia");
                }
                c1 = new Complejo(float.Parse(txtbReal1.Text), float.Parse(txtbImagnario1.Text));
                c2 = new Complejo(float.Parse(txtbReal2.Text), float.Parse(txtbImagnario2.Text));
                c3 = c1 * c2;
                lbSuma.Text = c3.ToString();
                lbOperacion.Text = "*";
                errorProvider1.Clear();
                errorProvider2.Clear();
                errorProvider3.Clear();
                errorProvider4.Clear();
            }
            catch (ApplicationException error)
            {
                errorProvider1.SetError(txtbReal1, error.Message);
                errorProvider2.SetError(txtbImagnario1, error.Message);
                errorProvider3.SetError(txtbReal2, error.Message);
                errorProvider4.SetError(txtbImagnario2, error.Message);
            }
            catch (FormatException error)
            {
                MessageBox.Show("Error: Debes ingresar un numero");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }
    }
}
