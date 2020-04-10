using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class RefreshKothAttemptsRequest : IMessage<RefreshKothAttemptsRequest>, IMessage, IEquatable<RefreshKothAttemptsRequest>, IDeepCloneable<RefreshKothAttemptsRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<RefreshKothAttemptsRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int UseFreeClubSupportFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private bool useFreeClubSupport_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B630", Offset="0x109B630")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x201F3F8", Offset="0x201F3F8", VA="0x201F3F8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B620", Offset="0x109B620")]
		public static MessageParser<RefreshKothAttemptsRequest> Parser
		{
			[Address(RVA="0x201F390", Offset="0x201F390", VA="0x201F390")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B640", Offset="0x109B640")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x201F4E8", Offset="0x201F4E8", VA="0x201F4E8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B650", Offset="0x109B650")]
		public bool UseFreeClubSupport
		{
			[Address(RVA="0x201F610", Offset="0x201F610", VA="0x201F610")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x201F618", Offset="0x201F618", VA="0x201F618")]
			set
			{
			}
		}

		[Address(RVA="0x201F94C", Offset="0x201F94C", VA="0x201F94C")]
		static RefreshKothAttemptsRequest()
		{
		}

		[Address(RVA="0x201F544", Offset="0x201F544", VA="0x201F544")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086FDC", Offset="0x1086FDC")]
		public RefreshKothAttemptsRequest()
		{
		}

		[Address(RVA="0x201F54C", Offset="0x201F54C", VA="0x201F54C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086FEC", Offset="0x1086FEC")]
		public RefreshKothAttemptsRequest(RefreshKothAttemptsRequest other)
		{
		}

		[Address(RVA="0x201F854", Offset="0x201F854", VA="0x201F854", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108705C", Offset="0x108705C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x201F5B0", Offset="0x201F5B0", VA="0x201F5B0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086FFC", Offset="0x1086FFC")]
		public RefreshKothAttemptsRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x201F624", Offset="0x201F624", VA="0x201F624", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108700C", Offset="0x108700C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x201F698", Offset="0x201F698", VA="0x201F698", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108701C", Offset="0x108701C")]
		public bool Equals(RefreshKothAttemptsRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x201F6E4", Offset="0x201F6E4", VA="0x201F6E4", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108702C", Offset="0x108702C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x201F88C", Offset="0x201F88C", VA="0x201F88C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108706C", Offset="0x108706C")]
		public void MergeFrom(RefreshKothAttemptsRequest other)
		{
		}

		[Address(RVA="0x201F8CC", Offset="0x201F8CC", VA="0x201F8CC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108707C", Offset="0x108707C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x201F748", Offset="0x201F748", VA="0x201F748", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108703C", Offset="0x108703C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x201F7B0", Offset="0x201F7B0", VA="0x201F7B0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108704C", Offset="0x108704C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10508B8", Offset="0x10508B8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static RefreshKothAttemptsRequest.<>c <>9;

			[Address(RVA="0x201FA24", Offset="0x201FA24", VA="0x201FA24")]
			static <>c()
			{
			}

			[Address(RVA="0x201FA88", Offset="0x201FA88", VA="0x201FA88")]
			public <>c()
			{
			}

			[Address(RVA="0x201FA90", Offset="0x201FA90", VA="0x201FA90")]
			internal RefreshKothAttemptsRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}