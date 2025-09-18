using AudioMob.Internal;
using UnityEngine;

namespace AudioMob.Unmanaged
{
	public class AudioMobLocationService : ILocationService
	{
		public bool IsEnabledByUser => false;

		public GeoStatus Status => default(GeoStatus);

		public LocationInfo LastData => default(LocationInfo);

		public void Start(float desiredAccuracyInMeters)
		{
		}
	}
}
