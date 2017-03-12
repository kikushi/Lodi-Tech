using System;
using CoreLocation;
using MapKit;

namespace maptest3
{
	public class CustomAnnotation : MKAnnotation
	{
		string title;
		CLLocationCoordinate2D coord;

		public CustomAnnotation(string title, CLLocationCoordinate2D coord)
		{
			this.title = title;
			this.coord = coord;
		}

		public override string Title
		{
			get
			{
				return title;
			}
		}

		public override CLLocationCoordinate2D Coordinate
		{
			get
			{
				return coord;
			}
		}
	}
}