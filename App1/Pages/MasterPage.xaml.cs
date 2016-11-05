using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace App1
{
	public partial class MasterPage : MasterDetailPage
	{
		public MasterPage()
		{
			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			App.Navigator = this.Navigator;
			App.Master = this;
		}
	}
}
