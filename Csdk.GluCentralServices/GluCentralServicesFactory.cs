using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Csdk.GluCentralServices
{
	public class GluCentralServicesFactory
	{
		[Address(RVA="0x155CCA0", Offset="0x155CCA0", VA="0x155CCA0")]
		public GluCentralServicesFactory()
		{
		}

		[Address(RVA="0x155CA58", Offset="0x155CA58", VA="0x155CA58")]
		public IGluCentralServices Create(GameObject gameObject, string jsonConfig, IDictionary<string, object> runtimeConfig)
		{
			return null;
		}

		[Address(RVA="0x155CBA8", Offset="0x155CBA8", VA="0x155CBA8")]
		private IGluCentralServices CreateDummy(GameObject gameObject, string jsonConfig, IDictionary<string, object> runtimeConfig)
		{
			return null;
		}

		[Address(RVA="0x155CC0C", Offset="0x155CC0C", VA="0x155CC0C")]
		private IGluCentralServices CreateNative(GameObject gameObject, string jsonConfig, IDictionary<string, object> runtimeConfig)
		{
			return null;
		}
	}
}