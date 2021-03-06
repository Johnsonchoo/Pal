﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pal.View.CustomViewCell
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OutgoingImgViewCell : ViewCell
	{
		public OutgoingImgViewCell ()
		{
			InitializeComponent ();
		}

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var uri = ((Image)sender).Source.ToString();
            await Application.Current.MainPage.Navigation.PushAsync(new WebViewAttachment(uri));
        }
    }
}