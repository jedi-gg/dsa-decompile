using Il2CppDummyDll;
using System;

namespace Csdk.GluCentralServices
{
	public class ConsentUpdateResult
	{
		[FieldOffset(Offset="0x10")]
		public readonly string Placement;

		[FieldOffset(Offset="0x18")]
		public readonly string Error;

		[FieldOffset(Offset="0x20")]
		public readonly bool DoesGDPRApply;

		[FieldOffset(Offset="0x28")]
		public readonly Csdk.GluCentralServices.ConsentStatus ConsentStatus;

		[Address(RVA="0x155C4F4", Offset="0x155C4F4", VA="0x155C4F4")]
		public ConsentUpdateResult(string placement, string error, bool doesGDPRApply, Csdk.GluCentralServices.ConsentStatus consentStatus)
		{
		}
	}
}