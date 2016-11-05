using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace App1
{
	public partial class MenuPages : ContentPage
	{
		public MenuPages()
		{
			InitializeComponent();

			List<string> words = new List<string>();
			words.Add("Some");
			words.Add("Little");
			words.Add("Sample");

			lstSample.ItemsSource = words;
		}
	}
}
