using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Csdk.GluAds
{
	public class GluAdsFactory
	{
		[Address(RVA="0x154F058", Offset="0x154F058", VA="0x154F058")]
		public GluAdsFactory()
		{
		}

		[Address(RVA="0x154EADC", Offset="0x154EADC", VA="0x154EADC")]
		public IAdvertising CreateAdvertising(GameObject gameObject, string jsonConfig, IDictionary<string, object> runtimeConfig)
		{
			return null;
		}

		[Address(RVA="0x154EC90", Offset="0x154EC90", VA="0x154EC90")]
		private IAdvertising CreateAndroidAdvertising(GameObject gameObject, string jsonConfig, IDictionary<string, object> runtimeConfig)
		{
			return null;
		}

		[Address(RVA="0x154EC2C", Offset="0x154EC2C", VA="0x154EC2C")]
		private IAdvertising CreateDummyAdvertising(GameObject gameObject, string jsonConfig, IDictionary<string, object> runtimeConfig)
		{
			return null;
		}
	}
}