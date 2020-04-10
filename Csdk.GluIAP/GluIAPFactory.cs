using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Csdk.GluIAP
{
	public class GluIAPFactory
	{
		[Address(RVA="0x21E00C4", Offset="0x21E00C4", VA="0x21E00C4")]
		public GluIAPFactory()
		{
		}

		[Address(RVA="0x21DFCFC", Offset="0x21DFCFC", VA="0x21DFCFC")]
		private IInAppPurchase CreateAndroidInAppPurchase(GameObject gameObject, string jsonConfig, IDictionary<string, object> runtimeConfig)
		{
			return null;
		}

		[Address(RVA="0x21DFC98", Offset="0x21DFC98", VA="0x21DFC98")]
		private IInAppPurchase CreateDummyInAppPurchase(GameObject gameObject, string jsonConfig, IDictionary<string, object> runtimeConfig)
		{
			return null;
		}

		[Address(RVA="0x21DFB48", Offset="0x21DFB48", VA="0x21DFB48")]
		public IInAppPurchase CreateInAppPurchase(GameObject gameObject, string jsonConfig, IDictionary<string, object> runtimeConfig)
		{
			return null;
		}
	}
}