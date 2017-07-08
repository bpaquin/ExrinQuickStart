using Exrin.Abstraction;
using System;
using Xamarin.Forms;

namespace ExrinQuickStart.Proxy
{
	public class PageProxy: ContentPage, IView
	{
		protected override bool OnBackButtonPressed()
		{
			return ((IView)this).OnBackButtonPressed();
		}

		Func<bool> IView.OnBackButtonPressed { get; set; }
	}
}
