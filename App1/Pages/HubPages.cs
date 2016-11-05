using System;

using Xamarin.Forms;

namespace App1
{
	public class HubPages : ContentPage
	{
		public HubPages()
		{
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}

