using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class RefreshTowerResponse : IMessage<RefreshTowerResponse>, IMessage, IEquatable<RefreshTowerResponse>, IDeepCloneable<RefreshTowerResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<RefreshTowerResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CFB8", Offset="0x109CFB8")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x20220BC", Offset="0x20220BC", VA="0x20220BC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CFA8", Offset="0x109CFA8")]
		public static MessageParser<RefreshTowerResponse> Parser
		{
			[Address(RVA="0x2022054", Offset="0x2022054", VA="0x2022054")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CFC8", Offset="0x109CFC8")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x20221AC", Offset="0x20221AC", VA="0x20221AC", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x20224C0", Offset="0x20224C0", VA="0x20224C0")]
		static RefreshTowerResponse()
		{
		}

		[Address(RVA="0x2022208", Offset="0x2022208", VA="0x2022208")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1089A7C", Offset="0x1089A7C")]
		public RefreshTowerResponse()
		{
		}

		[Address(RVA="0x2022210", Offset="0x2022210", VA="0x2022210")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1089A8C", Offset="0x1089A8C")]
		public RefreshTowerResponse(RefreshTowerResponse other)
		{
		}

		[Address(RVA="0x2022424", Offset="0x2022424", VA="0x2022424", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1089AFC", Offset="0x1089AFC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x2022254", Offset="0x2022254", VA="0x2022254", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1089A9C", Offset="0x1089A9C")]
		public RefreshTowerResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x20222B4", Offset="0x20222B4", VA="0x20222B4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1089AAC", Offset="0x1089AAC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x202234C", Offset="0x202234C", VA="0x202234C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1089ABC", Offset="0x1089ABC")]
		public bool Equals(RefreshTowerResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x2022378", Offset="0x2022378", VA="0x2022378", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1089ACC", Offset="0x1089ACC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x2022438", Offset="0x2022438", VA="0x2022438", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1089B0C", Offset="0x1089B0C")]
		public void MergeFrom(RefreshTowerResponse other)
		{
		}

		[Address(RVA="0x202246C", Offset="0x202246C", VA="0x202246C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1089B1C", Offset="0x1089B1C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x20223A8", Offset="0x20223A8", VA="0x20223A8", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1089ADC", Offset="0x1089ADC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x2022410", Offset="0x2022410", VA="0x2022410", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1089AEC", Offset="0x1089AEC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050CA8", Offset="0x1050CA8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static RefreshTowerResponse.<>c <>9;

			[Address(RVA="0x2022598", Offset="0x2022598", VA="0x2022598")]
			static <>c()
			{
			}

			[Address(RVA="0x20225FC", Offset="0x20225FC", VA="0x20225FC")]
			public <>c()
			{
			}

			[Address(RVA="0x2022604", Offset="0x2022604", VA="0x2022604")]
			internal RefreshTowerResponse <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}