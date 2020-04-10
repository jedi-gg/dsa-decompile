using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class RefreshEventBattleLimitRequest : IMessage<RefreshEventBattleLimitRequest>, IMessage, IEquatable<RefreshEventBattleLimitRequest>, IDeepCloneable<RefreshEventBattleLimitRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<RefreshEventBattleLimitRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int EventContentIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong eventContentId_;

		[FieldOffset(Offset="0x0")]
		public const int UseFreeClubSupportFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private bool useFreeClubSupport_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097538", Offset="0x1097538")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x201E128", Offset="0x201E128", VA="0x201E128")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097558", Offset="0x1097558")]
		public ulong EventContentId
		{
			[Address(RVA="0x201E35C", Offset="0x201E35C", VA="0x201E35C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x201E364", Offset="0x201E364", VA="0x201E364")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097528", Offset="0x1097528")]
		public static MessageParser<RefreshEventBattleLimitRequest> Parser
		{
			[Address(RVA="0x201E0C0", Offset="0x201E0C0", VA="0x201E0C0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097548", Offset="0x1097548")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x201E218", Offset="0x201E218", VA="0x201E218", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097568", Offset="0x1097568")]
		public bool UseFreeClubSupport
		{
			[Address(RVA="0x201E36C", Offset="0x201E36C", VA="0x201E36C")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x201E374", Offset="0x201E374", VA="0x201E374")]
			set
			{
			}
		}

		[Address(RVA="0x201E7DC", Offset="0x201E7DC", VA="0x201E7DC")]
		static RefreshEventBattleLimitRequest()
		{
		}

		[Address(RVA="0x201E274", Offset="0x201E274", VA="0x201E274")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FD7C", Offset="0x107FD7C")]
		public RefreshEventBattleLimitRequest()
		{
		}

		[Address(RVA="0x201E27C", Offset="0x201E27C", VA="0x201E27C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FD8C", Offset="0x107FD8C")]
		public RefreshEventBattleLimitRequest(RefreshEventBattleLimitRequest other)
		{
		}

		[Address(RVA="0x201E640", Offset="0x201E640", VA="0x201E640", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FDFC", Offset="0x107FDFC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x201E2FC", Offset="0x201E2FC", VA="0x201E2FC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FD9C", Offset="0x107FD9C")]
		public RefreshEventBattleLimitRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x201E380", Offset="0x201E380", VA="0x201E380", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FDAC", Offset="0x107FDAC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x201E3F4", Offset="0x201E3F4", VA="0x201E3F4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FDBC", Offset="0x107FDBC")]
		public bool Equals(RefreshEventBattleLimitRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x201E450", Offset="0x201E450", VA="0x201E450", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FDCC", Offset="0x107FDCC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x201E6E8", Offset="0x201E6E8", VA="0x201E6E8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FE0C", Offset="0x107FE0C")]
		public void MergeFrom(RefreshEventBattleLimitRequest other)
		{
		}

		[Address(RVA="0x201E734", Offset="0x201E734", VA="0x201E734", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FE1C", Offset="0x107FE1C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x201E4DC", Offset="0x201E4DC", VA="0x201E4DC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FDDC", Offset="0x107FDDC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x201E544", Offset="0x201E544", VA="0x201E544", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FDEC", Offset="0x107FDEC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FE58", Offset="0x104FE58")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static RefreshEventBattleLimitRequest.<>c <>9;

			[Address(RVA="0x201E8B4", Offset="0x201E8B4", VA="0x201E8B4")]
			static <>c()
			{
			}

			[Address(RVA="0x201E918", Offset="0x201E918", VA="0x201E918")]
			public <>c()
			{
			}

			[Address(RVA="0x201E920", Offset="0x201E920", VA="0x201E920")]
			internal RefreshEventBattleLimitRequest <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}