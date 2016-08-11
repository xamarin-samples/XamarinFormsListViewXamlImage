using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinFormsListViewXamlImage
{
	public partial class Page1 : ContentPage
	{
		public Page1()
		{
			InitializeComponent();

			// Make data list
			List<ItemInfo> list = new List<ItemInfo>();
			list.Add(
				new ItemInfo
				{
					Image = "https://avatars0.githubusercontent.com/u/20608487?v=3&s=200",
					Name = "John",
					State = "Hello"
				}
			);
			list.Add(
				new ItemInfo
				{
					Image = "https://avatars0.githubusercontent.com/u/20608487?v=3&s=200",
					Name = "Kei",
					State = "こんにちは"
				}
			);
			list.Add(
				new ItemInfo
				{
					Image = "https://avatars0.githubusercontent.com/u/20608487?v=3&s=200",
					Name = "Tama",
					State = "(◔౪◔)"
				}
			);

			// Bind
			this.BindingContext = list;
		}
	}
}
