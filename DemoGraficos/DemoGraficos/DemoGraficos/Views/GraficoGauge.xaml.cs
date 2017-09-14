using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkiaSharp;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoGraficos.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GraficoGauge : ContentPage
	{
	    List<Microcharts.Entry> entries = new List<Microcharts.Entry>
	    {
	        new Microcharts.Entry(200)
	        {
	            Label = "Janeiro",
	            ValueLabel = "200",
	            Color = SKColor.Parse("#266489")
	        },
	        new Microcharts.Entry(250)
	        {
	            Label = "Fevereiro",
	            ValueLabel = "250",
	            Color = SKColor.Parse("#68B9C0")
	        },
	        new Microcharts.Entry(100)
	        {
	            Label = "Março",
	            ValueLabel = "100",
	            Color = SKColor.Parse("#90D585")
	        },
	        new Microcharts.Entry(150)
	        {
	            Label = "Abril",
	            ValueLabel = "150",
	            Color = SKColor.Parse("#e77e23")
	        }
	    };


        public GraficoGauge ()
		{
			InitializeComponent ();
		    Grafico.Chart = new Microcharts.RadialGaugeChart() { Entries = entries };
		}
	}
}