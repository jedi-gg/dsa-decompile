using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class TowerAutoWinResponse : IMessage<TowerAutoWinResponse>, IMessage, IEquatable<TowerAutoWinResponse>, IDeepCloneable<TowerAutoWinResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<TowerAutoWinResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10930B0", Offset="0x10930B0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B6DDB8", Offset="0x1B6DDB8", VA="0x1B6DDB8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10930D0", Offset="0x10930D0")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x1B6DF88", Offset="0x1B6DF88", VA="0x1B6DF88")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B6DF90", Offset="0x1B6DF90", VA="0x1B6DF90")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10930A0", Offset="0x10930A0")]
		public static MessageParser<TowerAutoWinResponse> Parser
		{
			[Address(RVA="0x1B6DD50", Offset="0x1B6DD50", VA="0x1B6DD50")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10930C0", Offset="0x10930C0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B6DEA8", Offset="0x1B6DEA8", VA="0x1B6DEA8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B6E450", Offset="0x1B6E450", VA="0x1B6E450")]
		static TowerAutoWinResponse()
		{
		}

		[Address(RVA="0x1B6DF04", Offset="0x1B6DF04", VA="0x1B6DF04")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10780AC", Offset="0x10780AC")]
		public TowerAutoWinResponse()
		{
		}

		[Address(RVA="0x1B6DF0C", Offset="0x1B6DF0C", VA="0x1B6DF0C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10780BC", Offset="0x10780BC")]
		public TowerAutoWinResponse(TowerAutoWinResponse other)
		{
		}

		[Address(RVA="0x1B6E230", Offset="0x1B6E230", VA="0x1B6E230", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107812C", Offset="0x107812C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B6DF98", Offset="0x1B6DF98", VA="0x1B6DF98", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10780CC", Offset="0x10780CC")]
		public TowerAutoWinResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1B6DFF8", Offset="0x1B6DFF8", VA="0x1B6DFF8", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10780DC", Offset="0x10780DC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B6E06C", Offset="0x1B6E06C", VA="0x1B6E06C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10780EC", Offset="0x10780EC")]
		public bool Equals(TowerAutoWinResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1B6E0D0", Offset="0x1B6E0D0", VA="0x1B6E0D0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10780FC", Offset="0x10780FC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B6E2C0", Offset="0x1B6E2C0", VA="0x1B6E2C0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107813C", Offset="0x107813C")]
		public void MergeFrom(TowerAutoWinResponse other)
		{
		}

		[Address(RVA="0x1B6E374", Offset="0x1B6E374", VA="0x1B6E374", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107814C", Offset="0x107814C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B6E128", Offset="0x1B6E128", VA="0x1B6E128", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107810C", Offset="0x107810C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B6E190", Offset="0x1B6E190", VA="0x1B6E190", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107811C", Offset="0x107811C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F2B8", Offset="0x104F2B8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static TowerAutoWinResponse.<>c <>9;

			[Address(RVA="0x1B6E528", Offset="0x1B6E528", VA="0x1B6E528")]
			static <>c()
			{
			}

			[Address(RVA="0x1B6E58C", Offset="0x1B6E58C", VA="0x1B6E58C")]
			public <>c()
			{
			}

			[Address(RVA="0x1B6E594", Offset="0x1B6E594", VA="0x1B6E594")]
			internal TowerAutoWinResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}