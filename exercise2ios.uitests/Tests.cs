﻿using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.iOS;
using Xamarin.UITest.Queries;

namespace exercise2ios.uitests
{
	[TestFixture]
	public class Tests
	{
		iOSApp app;

		[SetUp]
		public void BeforeEachTest ()
		{
			// TODO: If the iOS app being tested is included in the solution then open
			// the Unit Tests window, right click Test Apps, select Add App Project
			// and select the app projects that should be tested.
			app = ConfigureApp
				.iOS
			// TODO: Update this path to point to your iOS app and uncomment the
			// code if the app is not included in the solution.
			.AppBundle ("../../../exercise2/bin/iPhoneSimulator/Debug/exercise2.app")
				.EnableLocalScreenshots()
				.StartApp ();
		}

		[Test]
		public void AppLaunches ()
		{
			app.EnterText ("namefieldid", "Gillian");
			app.Tap ("Change name");
			app.ClearText ("namefieldid");
			app.Query ("Gillian");
		}
	}
}

