using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace App1
{
	public partial class samplePage : ContentPage
	{
		public samplePage()
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
