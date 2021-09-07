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
    }
}
