using Csdk.GluIAP;
using Csdk.GluIAP.Implementation.Json;
using Il2CppDummyDll;
using System;

namespace Csdk.GluIAP.Implementation
{
	public static class MarshallingUtil
	{
		[Address(RVA="0x21EA86C", Offset="0x21EA86C", VA="0x21EA86C")]
		private static Exception ErrorFromJsonObject(JsonResult err)
		{
			return null;
		}

		[Address(RVA="0x21E096C", Offset="0x21E096C", VA="0x21E096C")]
		public static string JsonArg(object val)
		{
			return null;
		}

		[Address(RVA="0x21E1504", Offset="0x21E1504", VA="0x21E1504")]
		public static PurchaseEvent PurchaseEventFromString(string message)
		{
			return null;
		}

		[Address(RVA="0x21E17D8", Offset="0x21E17D8", VA="0x21E17D8")]
		public static QueryEvent QueryEventFromString(string message)
		{
			return null;
		}

		[Address(RVA="0x21E2360", Offset="0x21E2360", VA="0x21E2360")]
		public static QuerySubscriptionAwardsEvent QuerySubscriptionAwardsEventFromString(string message)
		{
			return null;
		}

		[Address(RVA="0x21E1DEC", Offset="0x21E1DEC", VA="0x21E1DEC")]
		public static QuerySubscriptionsEvent QuerySubscriptionsEventFromString(string message)
		{
			return null;
		}
	}
}