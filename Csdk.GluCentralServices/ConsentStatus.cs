using Il2CppDummyDll;
using System;

namespace Csdk.GluCentralServices
{
	public class ConsentStatus
	{
		[FieldOffset(Offset="0x10")]
		public readonly bool NoticeAccepted;

		[FieldOffset(Offset="0x11")]
		public readonly bool AgeGateAccepted;

		[FieldOffset(Offset="0x12")]
		public readonly bool BehavioralAdsAccepted;

		[FieldOffset(Offset="0x13")]
		public readonly bool PersonalizationAccepted;

		[Address(RVA="0x155C490", Offset="0x155C490", VA="0x155C490")]
		public ConsentStatus(bool noticeAccepted, bool ageGateAccepted, bool behavioralAdsAccepted, bool personalizationAccepted)
		{
		}
	}
}