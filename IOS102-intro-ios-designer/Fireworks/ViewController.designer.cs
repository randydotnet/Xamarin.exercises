// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Fireworks
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton buttonAbout { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton buttonStart { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISlider sliderSize { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISwitch switchNight { get; set; }

		[Action ("NightValueChanged:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void NightValueChanged (UISwitch sender);

		[Action ("SliderSizeValueChanged:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void SliderSizeValueChanged (UISlider sender);

		void ReleaseDesignerOutlets ()
		{
			if (buttonAbout != null) {
				buttonAbout.Dispose ();
				buttonAbout = null;
			}
			if (buttonStart != null) {
				buttonStart.Dispose ();
				buttonStart = null;
			}
			if (sliderSize != null) {
				sliderSize.Dispose ();
				sliderSize = null;
			}
			if (switchNight != null) {
				switchNight.Dispose ();
				switchNight = null;
			}
		}
	}
}
