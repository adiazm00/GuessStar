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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace VideoInteractivo
{
	public partial class MainWindow : Window
	{
		
		DispatcherTimer timer;
		int puntuacion = 0;
		int respuestas = 0;
		string[] pActual = {};
		string[] p1 = { "Libre, como el sol", "Libre, como las olas", "Libre  como el viento", "0", "1", "F", "Algo que nunca puede detener sus ansias de volar..." };
		string[] p2 = { "I must vanished all the times", "I've lost a  paradise", "I must've called a thousand times", "2", "2", "F", "Hello from the other side..." };
		string[] p3 = { "Romper el pico en el hierro", "Poner el alma en el ruedo", "Poner el alma en el fuego", "1", "3", "F", "Si hay que ser torero..." };
		string[] p4 = { "We will,We'll never rock you", "We will, we will smoke you", "We will, we will rock you", "2", "4", "F", "Kicking your can all over the place...'" };
		string[] p5 = { "Algo que no concibe", "Algo que no conoce", "Algo que no sabe", "1", "5", "F", "Y al despertar ya mi vida sabrás..." };
		string[] p6 = { "Annie, are you walking?", "Annie, Are you talking?", "Annie, are you okay?", "2", "6", "F", "She was struck down, it was her doom..." };
		string[] p7 = { "Oppan Gangnam style", "Opa voy hacer un corral", "Opa batman Style", "0", "7", "F", "Jigeumbuteo gal ddaekkaji gabolkka..." };
		string[] p8 = { "Te amo con el impetu del viento", "Te amo con el impetu del hierro", "Pero me lo impide el resto", "0", "8", "F", "Te amo con la fuerza de los mares yo..." };
		string[] p9 = { "Its going to Nether", "Its snows as ever", "Its now or never", "2", "9", "F", "It is my life..." };
		string[] p10 = { "'til I can go home", "til I cant no more", "'til I can't go on", "1", "10", "F", "I'm gonna ride..." };
		string[] p11 = { "Macedonia", "Macarena", "Maradona", "1", "11", "F", "Dale a tu cuerpo alegria Macarena..." };
		string[] p12 = { "don't love me? just leave", "dont' release my Apple watch", "don't believe me? just watch", "2", "12", "F", "Saturday night, and we in the spot..." };
		string[] p13 = { "the shape of you", "the shame on you", "the shadow of yours", "0", "13", "F", "I'm in love with..." };
		public MainWindow()
		{
			InitializeComponent();
			WelcomeWindow pantallaInicio = new WelcomeWindow();
			pantallaInicio.ShowDialog();
			mePlayer.Source = new Uri(System.AppDomain.CurrentDomain.BaseDirectory + "/multimedia.mp4", UriKind.Absolute);
			mePlayer.Volume = 0.5;
			timer = new DispatcherTimer();
			timer.Interval = TimeSpan.FromSeconds(1);
			timer.Tick += timer_Tick;
			timer.Start();
			mePlayer.Play();
		}

		void timer_Tick(object sender, EventArgs e)
		{
			if (mePlayer.Source != null)
			{
				if (mePlayer.NaturalDuration.HasTimeSpan) { 
					lblStatus.Content = String.Format("{0} / {1}", mePlayer.Position.ToString(@"mm\:ss"), mePlayer.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));
					compararTiempo(mePlayer.Position.ToString(@"mm\:ss"));
				}
			}
			else
				lblStatus.Content = "No file selected...";
		}


		private void compararTiempo(string tiempoActual)
		{
            switch (tiempoActual)
            {
                case "00:09":
					if (p1[5].Equals("F")){
						lanzarPreguntas(p1);
						p1[5] = "T";
					}
					break;
				case "00:39": // 00:39
					if (p2[5].Equals("F")){
						lanzarPreguntas(p2);
						p2[5] = "T";
					}
					break;
				case "00:59":// 00:59
					if (p3[5].Equals("F"))
					{
						lanzarPreguntas(p3);
						p3[5] = "T";
					}
					break;
				case "01:27": //"01:27"
					if (p4[5].Equals("F"))
					{
						lanzarPreguntas(p4);
						p4[5] = "T";
					}
					break;
				case "01:49": //"01:49"
					if (p5[5].Equals("F"))
					{
						lanzarPreguntas(p5);
						p5[5] = "T";
					}
					break;
				case "02:10": //02:10
					if (p6[5].Equals("F"))
					{
						lanzarPreguntas(p6);
						p6[5] = "T";
					}
					break;
				case "02:40": //02:40
					if (p7[5].Equals("F"))
					{
						lanzarPreguntas(p7);
						p7[5] = "T";
					}
					break;
				case "03:01":// 03:01
					if (p8[5].Equals("F"))
					{
						lanzarPreguntas(p8);
						p8[5] = "T";
					}
					break;
				case "03:28"://03:28
					if (p9[5].Equals("F"))
					{
						lanzarPreguntas(p9);
						p9[5] = "T";
					}
					break;
				case "03:53":// 03:52
					if (p10[5].Equals("F"))
					{
						lanzarPreguntas(p10);
						p10[5] = "T";
					}
					break;
				case "04:17"://4:16
					if (p11[5].Equals("F"))
					{
						lanzarPreguntas(p11);
						p11[5] = "T";
					}
					break;
				case "04:45"://4:45
					if (p12[5].Equals("F"))
					{
						lanzarPreguntas(p12);
						p12[5] = "T";
					}
					break;
				case "05:04"://05:03
					if (p13[5].Equals("F"))
					{
						lanzarPreguntas(p13);
						p13[5] = "T";
					}
					break;
				case "05:22":
					finPrograma();
					break;
			}

		}

        private void finPrograma()
        {
			mePlayer.Pause();
			this.Visibility = Visibility.Hidden;
			FinWindow pantallaFinal = new FinWindow(this);
			pantallaFinal.ShowDialog();
		}

		public void putVisible()
        {
			this.Visibility = Visibility.Visible;
		}

        private void lanzarPreguntas(string[] pa)
		{
			tbFirst.IsEnabled = true;
			tbSecond.IsEnabled = true;
			tbThird.IsEnabled = true;
			timer.Stop();
			tbResult.Text = "";
			tbResult.Foreground = new SolidColorBrush(Colors.White);
			tbFirst.Foreground = new SolidColorBrush(Colors.White);
			tbSecond.Foreground = new SolidColorBrush(Colors.White);
			tbThird.Foreground = new SolidColorBrush(Colors.White);
			mePlayer.Pause();
			tbFirst.Text = pa[0];
			tbSecond.Text = pa[1];
			tbThird.Text = pa[2];
			tbLetra.Text = pa[6];
			pActual = pa;
			wpSelect.Visibility = Visibility.Visible;
			gridFondo.Visibility = Visibility.Visible;
			imPause.IsEnabled = false;
			imPlay.IsEnabled = false;

		}

        private void select(object sender, MouseButtonEventArgs e)
        {
			string solucion = pActual[int.Parse(pActual[3])];
			
			if (sender.GetHashCode() == tbFirst.GetHashCode())
			{           //1
                if (tbFirst.Text.Equals(solucion)){
					puntuacion++;
					tbResult.Text = "Correcto +1";
					tbResult.Foreground = new SolidColorBrush(Colors.Green);

				}
				else
                {
					tbResult.Text = "Incorrecto +0";
					tbResult.Foreground = new SolidColorBrush(Colors.Red);
				}

			}
			
			else if (sender.GetHashCode()== tbSecond.GetHashCode())
			{    //2
				if (tbSecond.Text.Equals(solucion))
                {
					puntuacion++;
					tbResult.Text = "Correcto +1";
					tbResult.Foreground = new SolidColorBrush(Colors.Green);
				}
				else
                {
					tbResult.Text = "Incorrecto +0";
					tbResult.Foreground = new SolidColorBrush(Colors.Red); ;
				}
			}
			else if (sender.GetHashCode() == tbThird.GetHashCode())
			{   //3
				if (tbThird.Text.Equals(solucion))
                {
					puntuacion++;
					tbResult.Text = "Correcto +1";
					tbResult.Foreground = new SolidColorBrush(Colors.Green);
				}
				else {
					tbResult.Text = "Incorrecto +0";
					tbResult.Foreground = new SolidColorBrush(Colors.Red);
				}
			}
			if(int.Parse(pActual[3]) == 0)
            {
				tbFirst.Foreground = new SolidColorBrush(Colors.Green);
				tbSecond.Foreground = new SolidColorBrush(Colors.Red);
				tbThird.Foreground = new SolidColorBrush(Colors.Red);
			}
            else if(int.Parse(pActual[3]) == 1) {
				tbFirst.Foreground = new SolidColorBrush(Colors.Red);
				tbSecond.Foreground = new SolidColorBrush(Colors.Green);
				tbThird.Foreground = new SolidColorBrush(Colors.Red);
			}
			else {
				tbFirst.Foreground = new SolidColorBrush(Colors.Red);
				tbSecond.Foreground = new SolidColorBrush(Colors.Red);
				tbThird.Foreground = new SolidColorBrush(Colors.Green);
			}
			tbPuntuacion.Text = "Puntuacion actual: "+(puntuacion)+"/"+ (++respuestas);


			tbFirst.IsEnabled = false;
			tbSecond.IsEnabled = false;
			tbThird.IsEnabled = false;

			imPlay.IsEnabled = true;
			imPause.IsEnabled = true;
			imStop.IsEnabled = true;
		}

        private void btnPause_Click(object sender, MouseButtonEventArgs e)
        {
			mePlayer.Pause();
		}

        private void btnPlay_Click(object sender, MouseButtonEventArgs e)
        {
			timer.Start();
			wpSelect.Visibility = Visibility.Hidden;
			gridFondo.Visibility = Visibility.Hidden;
			mePlayer.Play();
			imPause.IsEnabled = true;
			imStop.IsEnabled = true;
		}

        private void btnStop_Click(object sender, MouseButtonEventArgs e)
        {
			wpSelect.Visibility = Visibility.Hidden;
			gridFondo.Visibility = Visibility.Hidden;
			p1[5] = "F";
			p2[5] = "F";
			p3[5] = "F";
			p4[5] = "F";
			p5[5] = "F";
			p6[5] = "F";
			p7[5] = "F";
			p8[5] = "F";
			p9[5] = "F";
			p10[5] = "F";
			p11[5] = "F";
			p12[5] = "F";
			p13[5] = "F";
			puntuacion = 0;
			respuestas = 0;
			
			tbPuntuacion.Text = "Puntuacion actual: " + puntuacion + "/" + (respuestas);
			mePlayer.Stop();
			timer.Start();
			mePlayer.Play();
		}

		public void restart()
        {
			wpSelect.Visibility = Visibility.Hidden;
			gridFondo.Visibility = Visibility.Hidden;
			p1[5] = "F";
			p2[5] = "F";
			p3[5] = "F";
			p4[5] = "F";
			p5[5] = "F";
			p6[5] = "F";
			p7[5] = "F";
			p8[5] = "F";
			p9[5] = "F";
			p10[5] = "F";
			p11[5] = "F";
			p12[5] = "F";
			p13[5] = "F";
			puntuacion = 0;
			respuestas = 0;

			tbPuntuacion.Text = "Puntuacion actual: " + puntuacion + "/" + (respuestas);
			mePlayer.Stop();
			timer.Start();
			mePlayer.Play();
		}

		public int getPuntuacion()
		{
			return this.puntuacion;
		}

        private void btnFin_Click(object sender, MouseButtonEventArgs e)
        {
			finPrograma();
		}

        private void btnApagar_Click(object sender, MouseButtonEventArgs e)
        {
			App.Current.Shutdown();
		}

        private void subirVolumen(object sender, MouseButtonEventArgs e)
        {
			if (mePlayer.Volume < 1)
			{
				double x = mePlayer.Volume + 0.25;
				mePlayer.Volume = x;
			}
			if (mePlayer.Volume == 1)
            {
				imgVol.Source = new BitmapImage(new Uri(@"/assets/volumen4.png", UriKind.Relative));
			} else if (mePlayer.Volume == 0.75)
            {
				imgVol.Source = new BitmapImage(new Uri(@"/assets/volumen3.png", UriKind.Relative));
			} else if (mePlayer.Volume == 0.5)
            {
				imgVol.Source = new BitmapImage(new Uri(@"/assets/volumen2.png", UriKind.Relative));
			} else if (mePlayer.Volume == 0.25)
			{
				imgVol.Source = new BitmapImage(new Uri(@"/assets/volumen1.png", UriKind.Relative));
			} else
            {
				imgVol.Source = new BitmapImage(new Uri(@"/assets/volumen0.png", UriKind.Relative));
			}
		}

        private void bajarVolumen(object sender, MouseButtonEventArgs e)
        {
			if (mePlayer.Volume > 0)
			{
				double x = mePlayer.Volume - 0.25;
				mePlayer.Volume = x;
			}
			if (mePlayer.Volume == 1)
			{
				imgVol.Source = new BitmapImage(new Uri(@"/assets/volumen4.png", UriKind.Relative));
			}
			else if (mePlayer.Volume == 0.75)
			{
				imgVol.Source = new BitmapImage(new Uri(@"/assets/volumen3.png", UriKind.Relative));
			}
			else if (mePlayer.Volume == 0.5)
			{
				imgVol.Source = new BitmapImage(new Uri(@"/assets/volumen2.png", UriKind.Relative));
			}
			else if (mePlayer.Volume == 0.25)
			{
				imgVol.Source = new BitmapImage(new Uri(@"/assets/volumen1.png", UriKind.Relative));
			}
			else
			{
				imgVol.Source = new BitmapImage(new Uri(@"/assets/volumen0.png", UriKind.Relative));
			}
		}
    }
}