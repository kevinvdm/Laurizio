using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;	
using Android.OS;
using System.Collections.Generic;

namespace Laurizio
{
	[Activity (Label = "Laurizio", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{

		List<string> mSettingsItems = new List<string>();
		ArrayAdapter mSettingsAdapter;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			//var myHomePage = new contentPage();


	//DATABASE ATTEMPT
			//Valid filepath for dbfile to be stored
//			string dbPath = System.IO.Path.Combine (System.Environment.GetFolderPath (System.Environment.SpecialFolder.Personal), "database.db3");
//			var sqliteFilename = "MyDatabase.db3";
//			string libraryPath = System.Environment.GetFolderPath (System.Environment.SpecialFolder.Personal);
//
//			object locker = new object ();
//

		}
	}
}


