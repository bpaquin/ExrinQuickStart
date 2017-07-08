using ExrinQuickStart.Model;

namespace ExrinQuickStart.ViewModel
{
	public class AboutViewModel : Exrin.Framework.ViewModel
	{
		private readonly IAppModel _model;
		public AboutViewModel(IAppModel model)
		{
			_model = model;
		}
	}
}
