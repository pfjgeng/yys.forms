﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace yysgl.forms
{
	[ContentProperty("Source")]
	public class ResourceImageExtension : IMarkupExtension
	{

		public string Source
		{
			get;
			set;
		}

		public object ProvideValue(IServiceProvider serviceProvider)
		{
			if (Source == null)
				return null;

			return ImageSource.FromResource(Source);
		}
	}
}
