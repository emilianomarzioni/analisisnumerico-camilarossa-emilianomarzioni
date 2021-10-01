using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace WinFormsApp1
{
    public static class MetodosHelper
    {
       //Poner si converge en caso de que funcione o no converge y razon ej: cant max ite o  o división por cero
        public static object Biseccion(string f, double xi, double xd, double ite, double tole)
        {
            //Aca hago el algoritmo de biseccion
            Function fu = new Function($"f(x) = {f}");
            //Valido si xi o xd es raiz
            Expression exi = new Expression($"f({xi.ToString(CultureInfo.CreateSpecificCulture("en-GB"))})", fu);
            var fxir = exi.calculate();
            if(Math.Abs(fxir) < tole )
                return new Result() { ErrorRelativo = "0", XR = xi.ToString(), Iteraciones = "0" };
            Expression exd = new Expression($"f({xd.ToString(CultureInfo.CreateSpecificCulture("en-GB"))})", fu);
            var fxdr = exd.calculate();
            if(Math.Abs(fxdr) < tole)
                return new Result() { ErrorRelativo = "0", XR = xd.ToString(), Iteraciones = "0" };
            
            if((fxir * fxdr) >0)
                return new Error() { error_msg = "Reingrese el intervalo" };
            else
            {
                double xant = 0;
                var c = 0;
                double error;
                double xr;
                while (c <= ite)
                {
                    xr = (xi + xd) / 2;
                    error = Math.Abs((xr - xant) / xr);
                    Expression exr = new Expression($"f({xr.ToString(CultureInfo.CreateSpecificCulture("en-GB"))})", fu);
                    var fxrr = exr.calculate();
                    if ((Math.Abs(fxrr) < tole) || (error < tole))
                    {
                        return new Result() { ErrorRelativo = error.ToString(), XR = xr.ToString(), Iteraciones = c.ToString() };
                    }
                    else
                    {
                        if ((fxir * fxrr) > 0)
                        {
                            xi = xr;
                            //exi = new Expression($"f({xi.ToString(CultureInfo.CreateSpecificCulture("en-GB"))})", fu);
                            //fxir = exi.calculate();
                        }
                        else
                        {
                            xd = xr;
                        }
                        xant = xr;
                        c += 1;

                    }
                }
                return new Error() { error_msg = "Se llego al limite de iteraciones" };
                    
            }
            


        }
        public static object ReglaFalsa(string f, double xi, double xd, double ite, double tole)
        {
            //Aca hago el algoritmo de reglafalsa
            Function fu = new Function($"f(x) = {f}");
            //Valido si xi o xd es raiz
            Expression exi = new Expression($"f({xi.ToString(CultureInfo.CreateSpecificCulture("en-GB"))})", fu);
            var fxir = exi.calculate();
            if (fxir == 0)
                return new Result() { ErrorRelativo = "0", XR = xi.ToString(), Iteraciones = "0" };
            Expression exd = new Expression($"f({xd.ToString(CultureInfo.CreateSpecificCulture("en-GB"))})", fu);
            var fxdr = exd.calculate();
            if (fxdr == 0)
                return new Result() { ErrorRelativo = "0", XR = xd.ToString(), Iteraciones = "0" };

            if ((fxir * fxdr) > 0)
                return new Error() { error_msg = "Reingrese el intervalo, no corta el eje x" };
            else
            {
                double xant = 0;
                var c = 0;
                double error;
                double xr;
                while (c <= ite)
                {
                    xr = ((fxdr *  xi)- (fxir * xd)) / (fxdr - fxir);
                    error = Math.Abs((xr - xant) / xr);
                    Expression exr = new Expression($"f({xr.ToString(CultureInfo.CreateSpecificCulture("en-GB"))})", fu);
                    var fxrr = exr.calculate();
                    if ((Math.Abs(fxrr) < tole) || (error < tole) )
                    {
                        return new Result() { ErrorRelativo = error.ToString(), XR = xr.ToString(), Iteraciones = c.ToString() };
                    }
                    else
                    {
                        if ((fxir * fxrr) > 0)
                        {
                            xi = xr;
                            exi = new Expression($"f({xi.ToString(CultureInfo.CreateSpecificCulture("en-GB"))})", fu);
                            fxir = exi.calculate();
                        }
                        else
                        {
                            xd = xr;
                            exd = new Expression($"f({xd.ToString(CultureInfo.CreateSpecificCulture("en-GB"))})", fu);
                            fxdr = exd.calculate();
                        }
                        xant = xr;
                        c += 1;

                    }
                }
                return new Error() { error_msg = "Se llego al limite de iteraciones" };
            }
        }

        public static object NewtonRaphson(string f, double xi,  double ite, double tole)
        {
            Function fu = new Function($"f(x) = {f}");
            Expression exi = new Expression($"f({xi.ToString(CultureInfo.CreateSpecificCulture("en-GB"))})", fu);
            Expression exd = new Expression($"f({(xi+tole).ToString(CultureInfo.CreateSpecificCulture("en-GB"))})", fu);
            var fxir = exi.calculate();
            var fxdr = exd.calculate();

            if (fxir == 0)
                return new Result() { ErrorRelativo = "0", XR = xi.ToString(), Iteraciones = "0" };
            else
            {
                double xant = 0;
                var c = 0;
                double error;
                double xr;
                while (c <= ite)
                {
                    exi = new Expression($"f({xi.ToString(CultureInfo.CreateSpecificCulture("en-GB"))})", fu);
                    fxir = exi.calculate();
                    exd = new Expression($"f({(xi + tole).ToString(CultureInfo.CreateSpecificCulture("en-GB"))})", fu);
                    fxdr = exd.calculate(); 
                    xr = xi - (fxir / ((fxdr - fxir)/tole));
                    if (double.IsInfinity(xr))
                    {
                        return new Error() { error_msg = "Diverge: Infinito" };
                    }
                    if (double.IsNaN(xr))
                    {
                        return new Error() { error_msg = "Diverge: Nan" };
                    }
                    string xrstr = xr.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
                    error = Math.Abs((xr - xant) / xr);
                    Expression exr = new Expression($"f({xr.ToString(CultureInfo.CreateSpecificCulture("en-GB"))})", fu);
                    var fxrr = exr.calculate();
                    if ((Math.Abs(fxrr) < tole) || (error < tole))
                    {
                        return new Result() { ErrorRelativo = error.ToString(), XR = xr.ToString(), Iteraciones = c.ToString() };
                    }
                    else
                    {
                        xi = xr;
                        xant = xr;
                        c += 1;

                    }
                }
                return new Error() { error_msg = "Se llego al limite de iteraciones" };
            }
        }
        public static object Secante(string f, double xi,double xd, double ite, double tole)
        {
            Function fu = new Function($"f(x) = {f}");
            Expression exi = new Expression($"f({xi.ToString(CultureInfo.CreateSpecificCulture("en-GB"))})", fu);
            var fxir = exi.calculate();
            if (fxir == 0)
                return new Result() { ErrorRelativo = "0", XR = xi.ToString(), Iteraciones = "0" };
            Expression exd = new Expression($"f({xd.ToString(CultureInfo.CreateSpecificCulture("en-GB"))})", fu);
            var fxdr = exd.calculate();
            if (fxdr == 0)
                return new Result() { ErrorRelativo = "0", XR = xd.ToString(), Iteraciones = "0" };
            double xant = 0;
            var c = 0;
            double error;
            double xr;
            while (c <= ite)
            {
                exi = new Expression($"f({xi.ToString(CultureInfo.CreateSpecificCulture("en-GB"))})", fu);
                fxir = exi.calculate();
                exd = new Expression($"f({xd.ToString(CultureInfo.CreateSpecificCulture("en-GB"))})", fu);
                fxdr = exd.calculate();
                xr = ((fxir * xd) - (fxdr * xi))/(fxir -fxdr);
                if (double.IsInfinity(xr))
                {
                    return new Error() { error_msg = "Diverge: Infinito" };
                }
                if (double.IsNaN(xr))
                {
                    return new Error() { error_msg = "Diverge: Nan" };
                }
                error = Math.Abs((xr - xant) / xr);
                Expression exr = new Expression($"f({xr.ToString(CultureInfo.CreateSpecificCulture("en-GB"))})", fu);
                var fxrr = exr.calculate();

                if ((Math.Abs(fxrr) < tole) || (error < tole) )
                {
                    return new Result() { ErrorRelativo = error.ToString(), XR = xr.ToString(), Iteraciones = c.ToString() };
                }
                else
                {
                    xd = xi;
                    xi = xr;
                    xant = xr;
                    c += 1;

                }
            }
            return new Error() { error_msg = "Se llego al limite de iteraciones" };
            
        }

        public static double[] GaussJordan(double[,] matriz, int dim)
        {
            for (int i = 0; i <= dim - 1; i++)
            {
                double coef = matriz[i, i];
                for (int j = 0; j <= dim; j++)
                {
                    matriz[i, j] = matriz[i, j] / coef;
                }
                for (int j = 0; j <= dim - 1; j++)
                {
                    if (i != j)
                    {
                        coef = matriz[j, i];
                        for (int k = 0; k <= dim; k++)
                        {
                            matriz[j, k] = matriz[j, k] - (coef * matriz[i, k]);
                        }
                    }
                }
            }

            double[] resul = new double[dim];
            for (int i = 0; i < dim; i++)
            {
                resul[i] = matriz[i, dim];
            }
            return resul;
        }

    }

    public class Result
    {
        public string ErrorRelativo { get; set; }
        public string ConvergeOInfo { get; set; }
        public string Iteraciones { get; set; }
        public string XR { get; set; }
    }
    public class Error
    {
        public string error_msg { get; set; }
    }
}
