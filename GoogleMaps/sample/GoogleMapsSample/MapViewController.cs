using System;
using MonoTouch.UIKit;
using GoogleMaps;
using System.Drawing;
using MonoTouch.CoreLocation;

namespace GoogleMapsSample
{
	public class MapViewController : UIViewController
	{
		GMSMapView mapView;
		public MapViewController ()
		{

		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			GMSCamera camera = new GMSCamera(-33.8683, 151.2086, 6);
			mapView = new GMSMapView{Camera =  camera};
			mapView.MyLocationEnabled = true ;
			this.View = mapView;

			var xamarinhq = new GMSMarkerOptions {
				Title = "Xamarin HQ",
				Snippet = "Where the magic happens.",
				Position = new CLLocationCoordinate2D (37.797865, -122.402526)
			};
			mapView.AddMarker (xamarinhq);
		}
		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			mapView.StartRendering ();
		}
		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
			mapView.StopRendering ();
		}
	}
}

