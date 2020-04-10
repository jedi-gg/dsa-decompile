using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class KothClearCooldownRequest : IMessage<KothClearCooldownRequest>, IMessage, IEquatable<KothClearCooldownRequest>, IDeepCloneable<KothClearCooldownRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<KothClearCooldownRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int RewardTypeFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private RevSdkRewardType rewardType_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B400", Offset="0x109B400")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A9DCA8", Offset="0x1A9DCA8", VA="0x1A9DCA8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B3F0", Offset="0x109B3F0")]
		public static MessageParser<KothClearCooldownRequest> Parser
		{
			[Address(RVA="0x1A9DC40", Offset="0x1A9DC40", VA="0x1A9DC40")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B410", Offset="0x109B410")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A9DD98", Offset="0x1A9DD98", VA="0x1A9DD98", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B420", Offset="0x109B420")]
		public RevSdkRewardType RewardType
		{
			[Address(RVA="0x1A9DEC0", Offset="0x1A9DEC0", VA="0x1A9DEC0")]
			get
			{
				return new RevSdkRewardType();
			}
			[Address(RVA="0x1A9DEC8", Offset="0x1A9DEC8", VA="0x1A9DEC8")]
			set
			{
			}
		}

		[Address(RVA="0x1A9E23C", Offset="0x1A9E23C", VA="0x1A9E23C")]
		static KothClearCooldownRequest()
		{
		}

		[Address(RVA="0x1A9DDF4", Offset="0x1A9DDF4", VA="0x1A9DDF4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086B0C", Offset="0x1086B0C")]
		public KothClearCooldownRequest()
		{
		}

		[Address(RVA="0x1A9DDFC", Offset="0x1A9DDFC", VA="0x1A9DDFC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086B1C", Offset="0x1086B1C")]
		public KothClearCooldownRequest(KothClearCooldownRequest other)
		{
		}

		[Address(RVA="0x1A9E0F0", Offset="0x1A9E0F0", VA="0x1A9E0F0", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086B8C", Offset="0x1086B8C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A9DE60", Offset="0x1A9DE60", VA="0x1A9DE60", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086B2C", Offset="0x1086B2C")]
		public KothClearCooldownRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1A9DED0", Offset="0x1A9DED0", VA="0x1A9DED0", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086B3C", Offset="0x1086B3C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A9DF44", Offset="0x1A9DF44", VA="0x1A9DF44", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086B4C", Offset="0x1086B4C")]
		public bool Equals(KothClearCooldownRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1A9DF80", Offset="0x1A9DF80", VA="0x1A9DF80", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086B5C", Offset="0x1086B5C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A9E180", Offset="0x1A9E180", VA="0x1A9E180", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086B9C", Offset="0x1086B9C")]
		public void MergeFrom(KothClearCooldownRequest other)
		{
		}

		[Address(RVA="0x1A9E1C0", Offset="0x1A9E1C0", VA="0x1A9E1C0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086BAC", Offset="0x1086BAC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A9DFE8", Offset="0x1A9DFE8", VA="0x1A9DFE8", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086B6C", Offset="0x1086B6C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A9E050", Offset="0x1A9E050", VA="0x1A9E050", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086B7C", Offset="0x1086B7C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050848", Offset="0x1050848")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static KothClearCooldownRequest.<>c <>9;

			[Address(RVA="0x1A9E314", Offset="0x1A9E314", VA="0x1A9E314")]
			static <>c()
			{
			}

			[Address(RVA="0x1A9E378", Offset="0x1A9E378", VA="0x1A9E378")]
			public <>c()
			{
			}

			[Address(RVA="0x1A9E380", Offset="0x1A9E380", VA="0x1A9E380")]
			internal KothClearCooldownRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}