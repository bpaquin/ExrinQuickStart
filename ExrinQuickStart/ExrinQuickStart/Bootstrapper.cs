using Exrin.Abstraction;
using ExrinQuickStart.Proxy;
using System;
using Xamarin.Forms;

namespace ExrinQuickStart
{
	public class Bootstrapper : Exrin.Framework.Bootstrapper
	{
		private static Bootstrapper _instance = null;
		public Bootstrapper(IInjectionProxy injection, Action<object> setRoot, Func<object> getRoot)
			: base(injection, setRoot, getRoot)
		{
		}

		public static Bootstrapper GetInstance()
		{
			if (_instance == null)
				_instance = new Bootstrapper(new Injection(),
											 (view) => Application.Current.MainPage = view as Page,
											 () => { return Application.Current.MainPage; });

			return _instance;
		}

	}
}
