using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Glu.Plugins.GluAnalytics
{
	public class GluAnalyticsFactory
	{
		[Address(RVA="0x14ED2FC", Offset="0x14ED2FC", VA="0x14ED2FC")]
		public GluAnalyticsFactory()
		{
		}

		[Address(RVA="0x14ECDCC", Offset="0x14ECDCC", VA="0x14ECDCC")]
		public IGluAnalytics CreateGluAnalytics(GameObject gameObject, string jsonConfig, IDictionary<string, object> runtimeConfig)
		{
			return null;
		}

		[Address(RVA="0x14ECFB0", Offset="0x14ECFB0", VA="0x14ECFB0")]
		private static IGluAnalytics CreateGluAnalyticsAndroid(GameObject gameObject, string jsonConfig, IDictionary<string, object> runtimeConfig)
		{
			return null;
		}

		[Address(RVA="0x14ED288", Offset="0x14ED288", VA="0x14ED288")]
		private static IGluAnalytics CreateGluAnalyticsDummy(GameObject gameObject, string jsonConfig, IDictionary<string, object> runtimeConfig)
		{
			return null;
		}
	}
}