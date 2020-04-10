using Il2CppDummyDll;
using System;

namespace Helpshift
{
	public static class HelpshiftJSONUtility
	{
		[Address(RVA="0x12E56F4", Offset="0x12E56F4", VA="0x12E56F4")]
		public static HelpshiftAuthFailureReason getAuthFailureReason(string serializedJSONAuthFailure)
		{
			return new HelpshiftAuthFailureReason();
		}

		[Address(RVA="0x12E53E8", Offset="0x12E53E8", VA="0x12E53E8")]
		public static HelpshiftUser getHelpshiftUser(string serializedJSONHelpshiftUser)
		{
			return null;
		}
	}
}