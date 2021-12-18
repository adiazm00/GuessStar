using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace VideoInteractivo
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class FinWindow : Window
    {
        MainWindow pad;
        public FinWindow(MainWindow padre)
        {
            InitializeComponent();
            pad = padre;
            string calificacion = "";
            int puntuacion = padre.getPuntuacion();
            if(puntuacion < 4)
            {
                calificacion = "Vaya, tu resultado no es el esperado. Espero que tengas más suerte la próxima vez.";
            } else if (puntuacion < 8)
            {
                calificacion = "No está mal, aunque puedes mejorar todavía más.";
            }
            else if(puntuacion < 11)
            {
                calificacion = "¡Muy bien!, has tenido pocos fallos.";
            }
            else
            {
                calificacion = "¡¡ENHORABUENA!!, me tienes que enseñar sobre música.";
            }

            tbResultadoFinal.Text = "Puntuacion Final: " + padre.getPuntuacion() + "/13\n"+calificacion ;
        }

        private void iniciar(object sender, RoutedEventArgs e)
        {
            this.Close();
            pad.restart();
            pad.putVisible();
        }

        private void cerrar(object sender, MouseButtonEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
