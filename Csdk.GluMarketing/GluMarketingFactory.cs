using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Csdk.GluMarketing
{
	public class GluMarketingFactory
	{
		[Address(RVA="0x21EBCB0", Offset="0x21EBCB0", VA="0x21EBCB0")]
		public GluMarketingFactory()
		{
		}

		[Address(RVA="0x21EB8F0", Offset="0x21EB8F0", VA="0x21EB8F0")]
		private IMarketing CreateAndroidMarketing(GameObject gameObject, string jsonConfig, IDictionary<string, object> runtimeConfig)
		{
			return null;
		}

		[Address(RVA="0x21EB88C", Offset="0x21EB88C", VA="0x21EB88C")]
		private IMarketing CreateDummyMarketing(GameObject gameObject, string jsonConfig, IDictionary<string, object> runtimeConfig)
		{
			return null;
		}

		[Address(RVA="0x21EB73C", Offset="0x21EB73C", VA="0x21EB73C")]
		public IMarketing CreateMarketing(GameObject gameObject, string jsonConfig, IDictionary<string, object> runtimeConfig)
		{
			return null;
		}
	}
}