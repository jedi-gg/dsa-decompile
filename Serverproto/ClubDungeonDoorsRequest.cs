using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubDungeonDoorsRequest : IMessage<ClubDungeonDoorsRequest>, IMessage, IEquatable<ClubDungeonDoorsRequest>, IDeepCloneable<ClubDungeonDoorsRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubDungeonDoorsRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10959B0", Offset="0x10959B0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A4F98C", Offset="0x1A4F98C", VA="0x1A4F98C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10959A0", Offset="0x10959A0")]
		public static MessageParser<ClubDungeonDoorsRequest> Parser
		{
			[Address(RVA="0x1A4F924", Offset="0x1A4F924", VA="0x1A4F924")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10959C0", Offset="0x10959C0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A4FA7C", Offset="0x1A4FA7C", VA="0x1A4FA7C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1A4FD90", Offset="0x1A4FD90", VA="0x1A4FD90")]
		static ClubDungeonDoorsRequest()
		{
		}

		[Address(RVA="0x1A4FAD8", Offset="0x1A4FAD8", VA="0x1A4FAD8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CE0C", Offset="0x107CE0C")]
		public ClubDungeonDoorsRequest()
		{
		}

		[Address(RVA="0x1A4FAE0", Offset="0x1A4FAE0", VA="0x1A4FAE0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CE1C", Offset="0x107CE1C")]
		public ClubDungeonDoorsRequest(ClubDungeonDoorsRequest other)
		{
		}

		[Address(RVA="0x1A4FCF4", Offset="0x1A4FCF4", VA="0x1A4FCF4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CE8C", Offset="0x107CE8C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A4FB24", Offset="0x1A4FB24", VA="0x1A4FB24", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CE2C", Offset="0x107CE2C")]
		public ClubDungeonDoorsRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1A4FB84", Offset="0x1A4FB84", VA="0x1A4FB84", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CE3C", Offset="0x107CE3C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A4FC1C", Offset="0x1A4FC1C", VA="0x1A4FC1C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CE4C", Offset="0x107CE4C")]
		public bool Equals(ClubDungeonDoorsRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1A4FC48", Offset="0x1A4FC48", VA="0x1A4FC48", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CE5C", Offset="0x107CE5C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A4FD08", Offset="0x1A4FD08", VA="0x1A4FD08", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CE9C", Offset="0x107CE9C")]
		public void MergeFrom(ClubDungeonDoorsRequest other)
		{
		}

		[Address(RVA="0x1A4FD3C", Offset="0x1A4FD3C", VA="0x1A4FD3C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CEAC", Offset="0x107CEAC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A4FC78", Offset="0x1A4FC78", VA="0x1A4FC78", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CE6C", Offset="0x107CE6C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A4FCE0", Offset="0x1A4FCE0", VA="0x1A4FCE0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CE7C", Offset="0x107CE7C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F9F8", Offset="0x104F9F8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubDungeonDoorsRequest.<>c <>9;

			[Address(RVA="0x1A4FE68", Offset="0x1A4FE68", VA="0x1A4FE68")]
			static <>c()
			{
			}

			[Address(RVA="0x1A4FECC", Offset="0x1A4FECC", VA="0x1A4FECC")]
			public <>c()
			{
			}

			[Address(RVA="0x1A4FED4", Offset="0x1A4FED4", VA="0x1A4FED4")]
			internal ClubDungeonDoorsRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}