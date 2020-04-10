using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Csdk.GluAppTracking
{
	public class GluAppTrackingFactory
	{
		[Address(RVA="0x15593CC", Offset="0x15593CC", VA="0x15593CC")]
		public GluAppTrackingFactory()
		{
		}

		[Address(RVA="0x1559008", Offset="0x1559008", VA="0x1559008")]
		public IGluAppTracking CreateAppTracking(GameObject gameObject, string jsonConfig)
		{
			return null;
		}

		[Address(RVA="0x1559110", Offset="0x1559110", VA="0x1559110")]
		private static IGluAppTracking CreateAppTrackingAndroid(GameObject gameObject, string jsonConfig)
		{
			return null;
		}
	}
}