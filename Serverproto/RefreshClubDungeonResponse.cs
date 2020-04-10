using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class RefreshClubDungeonResponse : IMessage<RefreshClubDungeonResponse>, IMessage, IEquatable<RefreshClubDungeonResponse>, IDeepCloneable<RefreshClubDungeonResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<RefreshClubDungeonResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095980", Offset="0x1095980")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x201DB1C", Offset="0x201DB1C", VA="0x201DB1C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095970", Offset="0x1095970")]
		public static MessageParser<RefreshClubDungeonResponse> Parser
		{
			[Address(RVA="0x201DAB4", Offset="0x201DAB4", VA="0x201DAB4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095990", Offset="0x1095990")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x201DC0C", Offset="0x201DC0C", VA="0x201DC0C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x201DF20", Offset="0x201DF20", VA="0x201DF20")]
		static RefreshClubDungeonResponse()
		{
		}

		[Address(RVA="0x201DC68", Offset="0x201DC68", VA="0x201DC68")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CD5C", Offset="0x107CD5C")]
		public RefreshClubDungeonResponse()
		{
		}

		[Address(RVA="0x201DC70", Offset="0x201DC70", VA="0x201DC70")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CD6C", Offset="0x107CD6C")]
		public RefreshClubDungeonResponse(RefreshClubDungeonResponse other)
		{
		}

		[Address(RVA="0x201DE84", Offset="0x201DE84", VA="0x201DE84", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CDDC", Offset="0x107CDDC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x201DCB4", Offset="0x201DCB4", VA="0x201DCB4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CD7C", Offset="0x107CD7C")]
		public RefreshClubDungeonResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x201DD14", Offset="0x201DD14", VA="0x201DD14", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CD8C", Offset="0x107CD8C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x201DDAC", Offset="0x201DDAC", VA="0x201DDAC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CD9C", Offset="0x107CD9C")]
		public bool Equals(RefreshClubDungeonResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x201DDD8", Offset="0x201DDD8", VA="0x201DDD8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CDAC", Offset="0x107CDAC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x201DE98", Offset="0x201DE98", VA="0x201DE98", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CDEC", Offset="0x107CDEC")]
		public void MergeFrom(RefreshClubDungeonResponse other)
		{
		}

		[Address(RVA="0x201DECC", Offset="0x201DECC", VA="0x201DECC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CDFC", Offset="0x107CDFC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x201DE08", Offset="0x201DE08", VA="0x201DE08", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CDBC", Offset="0x107CDBC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x201DE70", Offset="0x201DE70", VA="0x201DE70", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CDCC", Offset="0x107CDCC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F9E8", Offset="0x104F9E8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static RefreshClubDungeonResponse.<>c <>9;

			[Address(RVA="0x201DFF8", Offset="0x201DFF8", VA="0x201DFF8")]
			static <>c()
			{
			}

			[Address(RVA="0x201E05C", Offset="0x201E05C", VA="0x201E05C")]
			public <>c()
			{
			}

			[Address(RVA="0x201E064", Offset="0x201E064", VA="0x201E064")]
			internal RefreshClubDungeonResponse <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}