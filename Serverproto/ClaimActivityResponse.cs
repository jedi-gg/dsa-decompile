using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClaimActivityResponse : IMessage<ClaimActivityResponse>, IMessage, IEquatable<ClaimActivityResponse>, IDeepCloneable<ClaimActivityResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClaimActivityResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int DefinitionIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong definitionId_;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[FieldOffset(Offset="0x0")]
		public const int ValidatedFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private bool validated_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A400", Offset="0x109A400")]
		public ulong DefinitionId
		{
			[Address(RVA="0x1A3FE2C", Offset="0x1A3FE2C", VA="0x1A3FE2C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A3FE34", Offset="0x1A3FE34", VA="0x1A3FE34")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A3E0", Offset="0x109A3E0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A3FBE8", Offset="0x1A3FBE8", VA="0x1A3FBE8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A410", Offset="0x109A410")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x1A3FDBC", Offset="0x1A3FDBC", VA="0x1A3FDBC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A3FDC4", Offset="0x1A3FDC4", VA="0x1A3FDC4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A3D0", Offset="0x109A3D0")]
		public static MessageParser<ClaimActivityResponse> Parser
		{
			[Address(RVA="0x1A3FB80", Offset="0x1A3FB80", VA="0x1A3FB80")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A3F0", Offset="0x109A3F0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A3FCD8", Offset="0x1A3FCD8", VA="0x1A3FCD8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A420", Offset="0x109A420")]
		public bool Validated
		{
			[Address(RVA="0x1A3FE3C", Offset="0x1A3FE3C", VA="0x1A3FE3C")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1A3FE44", Offset="0x1A3FE44", VA="0x1A3FE44")]
			set
			{
			}
		}

		[Address(RVA="0x1A404A8", Offset="0x1A404A8", VA="0x1A404A8")]
		static ClaimActivityResponse()
		{
		}

		[Address(RVA="0x1A3FD34", Offset="0x1A3FD34", VA="0x1A3FD34")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108432C", Offset="0x108432C")]
		public ClaimActivityResponse()
		{
		}

		[Address(RVA="0x1A3FD3C", Offset="0x1A3FD3C", VA="0x1A3FD3C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108433C", Offset="0x108433C")]
		public ClaimActivityResponse(ClaimActivityResponse other)
		{
		}

		[Address(RVA="0x1A401B8", Offset="0x1A401B8", VA="0x1A401B8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10843AC", Offset="0x10843AC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A3FDCC", Offset="0x1A3FDCC", VA="0x1A3FDCC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108434C", Offset="0x108434C")]
		public ClaimActivityResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1A3FE50", Offset="0x1A3FE50", VA="0x1A3FE50", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108435C", Offset="0x108435C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A3FEC4", Offset="0x1A3FEC4", VA="0x1A3FEC4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108436C", Offset="0x108436C")]
		public bool Equals(ClaimActivityResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1A3FF58", Offset="0x1A3FF58", VA="0x1A3FF58", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108437C", Offset="0x108437C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A402A4", Offset="0x1A402A4", VA="0x1A402A4", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10843BC", Offset="0x10843BC")]
		public void MergeFrom(ClaimActivityResponse other)
		{
		}

		[Address(RVA="0x1A40370", Offset="0x1A40370", VA="0x1A40370", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10843CC", Offset="0x10843CC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A3FFFC", Offset="0x1A3FFFC", VA="0x1A3FFFC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108438C", Offset="0x108438C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A40064", Offset="0x1A40064", VA="0x1A40064", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108439C", Offset="0x108439C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10504A8", Offset="0x10504A8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClaimActivityResponse.<>c <>9;

			[Address(RVA="0x1A40580", Offset="0x1A40580", VA="0x1A40580")]
			static <>c()
			{
			}

			[Address(RVA="0x1A405E4", Offset="0x1A405E4", VA="0x1A405E4")]
			public <>c()
			{
			}

			[Address(RVA="0x1A405EC", Offset="0x1A405EC", VA="0x1A405EC")]
			internal ClaimActivityResponse <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}