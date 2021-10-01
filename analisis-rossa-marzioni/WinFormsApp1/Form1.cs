using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calcularF_Click(object sender, EventArgs e)
        {
            //Resolver f(X)
            //Ver metodo seleccionado
            var metodoAUtilizar = metodosSelect.SelectedItem;
            object resultado = null;
            switch (metodoAUtilizar)
            {
                case "Biseccion":

                    resultado = MetodosHelper.Biseccion(Funcion.Text, double.Parse(xi.Text), double.Parse(xd.Text), int.Parse(ite.Text), double.Parse(tole.Text));
                    
                    break;

                case "ReglaFalsa":
                     resultado = MetodosHelper.ReglaFalsa(Funcion.Text, double.Parse(xi.Text), double.Parse(xd.Text), int.Parse(ite.Text), double.Parse(tole.Text));
                   
                    break;
                case "NewtonRaphson":
                     resultado = MetodosHelper.NewtonRaphson(Funcion.Text, double.Parse(xi.Text), int.Parse(ite.Text), double.Parse(tole.Text));
                    
                    break;
                case "Secante":
                    resultado = MetodosHelper.Secante(Funcion.Text, double.Parse(xi.Text), double.Parse(xd.Text), int.Parse(ite.Text), double.Parse(tole.Text));
                    break;
                default:
                    break;
                
            }
            if(resultado != null)
                EnviarResultados(resultado);




        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void EnviarResultados(object resultado)
        {
            if (resultado is Result)
            {
                CargarResultadosALabels(resultado as Result);
            }
            else
            {
                //Hubo error , debo mostrarlo
                MostrarError(resultado as Error);
            }
        }
        private void CargarResultadosALabels(Result r)
        {
            //Cargo los resultados al formularioS
            this.errorRelativo.Text = r.ErrorRelativo;
            this.Iteraciones.Text = r.Iteraciones.ToString();
            this.Xresult.Text = r.XR.ToString();
            this.convergelabel.Text =  r.ConvergeOInfo == "" || r.ConvergeOInfo == null? "Converge":r.ConvergeOInfo ;

        }
        private void MostrarError(Error e)
        {
            //Muestro el error en algun lado
             MessageBox.Show(e.error_msg, "Error");
            this.errorRelativo.Text = "-";
            this.Iteraciones.Text = "-";
            this.Xresult.Text = "-";
            this.convergelabel.Text = $"No Converge: {e.error_msg}";
        }

        private void metodosSelect_SelectedValueChanged(object sender, EventArgs e)
        {
            if(this.metodosSelect.SelectedItem.ToString() == "NewtonRaphson" )
            {
                xd.Enabled = false;
            }
            else
            {
                xd.Enabled = true;
            }
        }
        
        private void matrizgenerator_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Controls.Clear();
                int txtno = int.Parse(matrizvalues.Text);
                int pointX = 30;
                int pointY = 30;

                for (int i = 0; i < txtno; i++)
                {
                    for (int j = 0; j < txtno + 1; j++)
                    {
                        TextBox a = new TextBox();
                        a.Name = $"txt{i}{j}";
                        a.Location = new Point(pointX, pointY);
                        a.AutoSize = false;
                        a.Size = new Size(30, 20);
                        if (j == txtno)
                        {
                            a.Name = $"txt{i}{j}";
                            a.BackColor = Color.Yellow;
                            int coef = i;
                            switch (coef)
                            {
                                case 0:
                                    Coeficiente var = Coeficiente.X;
                                    a.Text = var.ToString();
                                    break;
                                case 1:
                                    Coeficiente var1 = Coeficiente.Y;
                                    a.Text = var1.ToString();
                                    break;
                                case 2:
                                    Coeficiente var2 = Coeficiente.Z;
                                    a.Text = var2.ToString();
                                    break;
                                case 3:
                                    Coeficiente var3 = Coeficiente.W;
                                    a.Text = var3.ToString();
                                    break;
                                case 4:
                                    Coeficiente var4 = Coeficiente.V;
                                    a.Text = var4.ToString();
                                    break;
                                case 5:
                                    Coeficiente var5 = Coeficiente.U;
                                    a.Text = var5.ToString();
                                    break;
                                default:
                                    break;
                            }

                        }
                        a.Font = new Font("Microsoft Sans Serif", 10);
                        panel1.Controls.Add(a);
                        panel1.Show();
                        pointX += 50;

                    }

                    pointY += 50;
                    pointX = 30;
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Valor incorrecto", "Tamaño de matriz");
            }
        }
        enum Coeficiente
        {
            X,
            Y,
            Z,
            W,
            V,
            U
        }

        private void ExeSeidel_Click(object sender, EventArgs e)
        {

        }

        private void ExeGauss_Click(object sender, EventArgs e)
        {
            int txtno = int.Parse(matrizvalues.Text);

            var m = GenerarMatriz();
            var x = MetodosHelper.GaussJordan(m, txtno);
        }
        private double[,] GenerarMatriz()
        {
            int txtno = int.Parse(matrizvalues.Text);

            double[,] matriz = new double[txtno, txtno + 1];
            for (int i = 0; i < txtno; i++)
            {
                for (int j = 0; j < txtno + 1; j++)
                {
                    Control tbx = panel1.Controls.Find($"txt{i}{j}", true).First();
                    matriz[i, j] = double.Parse((tbx as TextBox).Text);
                }
            }
            return matriz;
        }
    }
}
