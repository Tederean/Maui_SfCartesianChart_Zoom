using System.ComponentModel;
using System.Diagnostics;

namespace Maui_SfCartesianChart_Zoom
{

  public class MainPageViewModel : INotifyPropertyChanged
  {

		private double m_VisibleRangeStart;
		public double VisibleRangeStart
		{
			get { return m_VisibleRangeStart; }
			set
			{
				if (m_VisibleRangeStart == value) return;
				m_VisibleRangeStart = value;
				RaisePropertyChanged(nameof(VisibleRangeStart));
			}
		}


		private double m_VisibleRangeEnd;
		public double VisibleRangeEnd
		{
			get { return m_VisibleRangeEnd; }
			set
			{
				if (m_VisibleRangeEnd == value) return;
				m_VisibleRangeEnd = value;
				RaisePropertyChanged(nameof(VisibleRangeEnd));
			}
		}


		public event PropertyChangedEventHandler PropertyChanged;


		public MainPageViewModel()
    {
			m_VisibleRangeStart = 0.0;
			m_VisibleRangeEnd = 50.0;
		}


    protected virtual void RaisePropertyChanged(string propertyName)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

			if (Debugger.IsAttached)
				Debugger.Break();
    }
  }
}
