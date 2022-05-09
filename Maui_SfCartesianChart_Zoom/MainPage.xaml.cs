using Syncfusion.Maui.Charts;

namespace Maui_SfCartesianChart_Zoom;

public partial class MainPage : ContentPage
{
	
	public MainPage()
	{
		InitializeComponent();

		var random = new Random();
		var data = Enumerable.Range(0, 20000).Select(number => new SpectrumChartDataPoint() { Energy_keV = number * 0.002, IntensityLinear = random.NextDouble() * 900.0 }).ToArray();

		ChartView.Series.Add(new FastLineSeries()
		{
			StrokeWidth = 2,
			Fill = Color.FromArgb("#75547DD7"),
			XBindingPath = nameof(SpectrumChartDataPoint.Energy_keV),
			YBindingPath = nameof(SpectrumChartDataPoint.IntensityLinear),
			ItemsSource = data,
		});
	}
}

