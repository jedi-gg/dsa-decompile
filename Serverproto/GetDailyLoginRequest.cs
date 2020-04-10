using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class GetDailyLoginRequest : IMessage<GetDailyLoginRequest>, IMessage, IEquatable<GetDailyLoginRequest>, IDeepCloneable<GetDailyLoginRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<GetDailyLoginRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AC60", Offset="0x109AC60")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BA8C24", Offset="0x1BA8C24", VA="0x1BA8C24")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AC50", Offset="0x109AC50")]
		public static MessageParser<GetDailyLoginRequest> Parser
		{
			[Address(RVA="0x1BA8BBC", Offset="0x1BA8BBC", VA="0x1BA8BBC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AC70", Offset="0x109AC70")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BA8D14", Offset="0x1BA8D14", VA="0x1BA8D14", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1BA9028", Offset="0x1BA9028", VA="0x1BA9028")]
		static GetDailyLoginRequest()
		{
		}

		[Address(RVA="0x1BA8D70", Offset="0x1BA8D70", VA="0x1BA8D70")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10857CC", Offset="0x10857CC")]
		public GetDailyLoginRequest()
		{
		}

		[Address(RVA="0x1BA8D78", Offset="0x1BA8D78", VA="0x1BA8D78")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10857DC", Offset="0x10857DC")]
		public GetDailyLoginRequest(GetDailyLoginRequest other)
		{
		}

		[Address(RVA="0x1BA8F8C", Offset="0x1BA8F8C", VA="0x1BA8F8C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108584C", Offset="0x108584C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BA8DBC", Offset="0x1BA8DBC", VA="0x1BA8DBC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10857EC", Offset="0x10857EC")]
		public GetDailyLoginRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1BA8E1C", Offset="0x1BA8E1C", VA="0x1BA8E1C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10857FC", Offset="0x10857FC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BA8EB4", Offset="0x1BA8EB4", VA="0x1BA8EB4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108580C", Offset="0x108580C")]
		public bool Equals(GetDailyLoginRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1BA8EE0", Offset="0x1BA8EE0", VA="0x1BA8EE0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108581C", Offset="0x108581C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BA8FA0", Offset="0x1BA8FA0", VA="0x1BA8FA0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108585C", Offset="0x108585C")]
		public void MergeFrom(GetDailyLoginRequest other)
		{
		}

		[Address(RVA="0x1BA8FD4", Offset="0x1BA8FD4", VA="0x1BA8FD4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108586C", Offset="0x108586C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BA8F10", Offset="0x1BA8F10", VA="0x1BA8F10", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108582C", Offset="0x108582C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BA8F78", Offset="0x1BA8F78", VA="0x1BA8F78", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108583C", Offset="0x108583C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050688", Offset="0x1050688")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static GetDailyLoginRequest.<>c <>9;

			[Address(RVA="0x1BA9100", Offset="0x1BA9100", VA="0x1BA9100")]
			static <>c()
			{
			}

			[Address(RVA="0x1BA9164", Offset="0x1BA9164", VA="0x1BA9164")]
			public <>c()
			{
			}

			[Address(RVA="0x1BA916C", Offset="0x1BA916C", VA="0x1BA916C")]
			internal GetDailyLoginRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}