using Il2CppDummyDll;
using System;

namespace Helpshift
{
	public class HelpshiftUser
	{
		[FieldOffset(Offset="0x10")]
		public readonly string identifier;

		[FieldOffset(Offset="0x18")]
		public readonly string email;

		[FieldOffset(Offset="0x20")]
		public readonly string name;

		[FieldOffset(Offset="0x28")]
		public readonly string authToken;

		[Address(RVA="0x12E6B40", Offset="0x12E6B40", VA="0x12E6B40")]
		private HelpshiftUser(string identifier, string email, string name, string authToken)
		{
		}

		public sealed class Builder
		{
			[FieldOffset(Offset="0x10")]
			private string identifier;

			[FieldOffset(Offset="0x18")]
			private string email;

			[FieldOffset(Offset="0x20")]
			private string name;

			[FieldOffset(Offset="0x28")]
			private string authToken;

			[Address(RVA="0x12E562C", Offset="0x12E562C", VA="0x12E562C")]
			public Builder(string identifier, string email)
			{
			}

			[Address(RVA="0x12E5674", Offset="0x12E5674", VA="0x12E5674")]
			public HelpshiftUser build()
			{
				return null;
			}

			[Address(RVA="0x12E566C", Offset="0x12E566C", VA="0x12E566C")]
			public HelpshiftUser.Builder setAuthToken(string authToken)
			{
				return null;
			}

			[Address(RVA="0x12E5664", Offset="0x12E5664", VA="0x12E5664")]
			public HelpshiftUser.Builder setName(string name)
			{
				return null;
			}
		}
	}
}