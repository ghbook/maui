using System;
using System.Collections.Generic;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Core.UnitTests;
using Microsoft.Maui.Graphics;
using NUnit.Framework;

namespace Microsoft.Maui.Controls.Xaml.UnitTests
{
	public partial class Bz28545 : ContentPage
	{
		public Bz28545()
		{
			InitializeComponent();
		}

		public Bz28545(bool useCompiledXaml)
		{
			//this stub will be replaced at compile time
		}

		[TestFixture]
		class Tests
		{
			[SetUp] public void Setup() => Device.PlatformServices = new MockPlatformServices();
			[TearDown] public void TearDown() => Device.PlatformServices = null;

			[Test]
			public void TypeConverterAreAppliedForSettersToAttachedBP([Values (false, true)]bool useCompiledXaml)
			{
				var layout = new Bz28545(useCompiledXaml);
				Assert.AreEqual(Colors.Pink, layout.label.TextColor);
				Assert.AreEqual(AbsoluteLayoutFlags.PositionProportional, AbsoluteLayout.GetLayoutFlags(layout.label));
				Assert.AreEqual(new Rectangle(1, 1, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize), AbsoluteLayout.GetLayoutBounds(layout.label));
			}
		}
	}
}