using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace App1
{
	public partial class HubPages : ContentPage
	{
		public HubPages()
		{
			InitializeComponent();
		}

		public void Click(object sender, EventArgs e)
		{
			App.Navigator.PushAsync(new samplePage());
		}
	}
}
