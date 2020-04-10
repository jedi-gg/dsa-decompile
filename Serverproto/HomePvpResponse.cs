using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class HomePvpResponse : IMessage<HomePvpResponse>, IMessage, IEquatable<HomePvpResponse>, IDeepCloneable<HomePvpResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<HomePvpResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int HomePvpAssetFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string homePvpAsset_;

		[FieldOffset(Offset="0x0")]
		public const int PvpPackAssetFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string pvpPackAsset_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098190", Offset="0x1098190")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1D08150", Offset="0x1D08150", VA="0x1D08150")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10981B0", Offset="0x10981B0")]
		public string HomePvpAsset
		{
			[Address(RVA="0x1D083CC", Offset="0x1D083CC", VA="0x1D083CC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D083D4", Offset="0x1D083D4", VA="0x1D083D4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098180", Offset="0x1098180")]
		public static MessageParser<HomePvpResponse> Parser
		{
			[Address(RVA="0x1D080E8", Offset="0x1D080E8", VA="0x1D080E8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10981A0", Offset="0x10981A0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1D0823C", Offset="0x1D0823C", VA="0x1D0823C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10981C0", Offset="0x10981C0")]
		public string PvpPackAsset
		{
			[Address(RVA="0x1D08444", Offset="0x1D08444", VA="0x1D08444")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D0844C", Offset="0x1D0844C", VA="0x1D0844C")]
			set
			{
			}
		}

		[Address(RVA="0x1D08A68", Offset="0x1D08A68", VA="0x1D08A68")]
		static HomePvpResponse()
		{
		}

		[Address(RVA="0x1D08298", Offset="0x1D08298", VA="0x1D08298")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10812CC", Offset="0x10812CC")]
		public HomePvpResponse()
		{
		}

		[Address(RVA="0x1D082F0", Offset="0x1D082F0", VA="0x1D082F0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10812DC", Offset="0x10812DC")]
		public HomePvpResponse(HomePvpResponse other)
		{
		}

		[Address(RVA="0x1D08808", Offset="0x1D08808", VA="0x1D08808", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108134C", Offset="0x108134C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1D0836C", Offset="0x1D0836C", VA="0x1D0836C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10812EC", Offset="0x10812EC")]
		public HomePvpResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1D084BC", Offset="0x1D084BC", VA="0x1D084BC", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10812FC", Offset="0x10812FC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1D08530", Offset="0x1D08530", VA="0x1D08530", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108130C", Offset="0x108130C")]
		public bool Equals(HomePvpResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1D085A8", Offset="0x1D085A8", VA="0x1D085A8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108131C", Offset="0x108131C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1D0891C", Offset="0x1D0891C", VA="0x1D0891C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108135C", Offset="0x108135C")]
		public void MergeFrom(HomePvpResponse other)
		{
		}

		[Address(RVA="0x1D089B4", Offset="0x1D089B4", VA="0x1D089B4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108136C", Offset="0x108136C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1D08678", Offset="0x1D08678", VA="0x1D08678", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108132C", Offset="0x108132C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1D086E0", Offset="0x1D086E0", VA="0x1D086E0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108133C", Offset="0x108133C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050048", Offset="0x1050048")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static HomePvpResponse.<>c <>9;

			[Address(RVA="0x1D08B40", Offset="0x1D08B40", VA="0x1D08B40")]
			static <>c()
			{
			}

			[Address(RVA="0x1D08BA4", Offset="0x1D08BA4", VA="0x1D08BA4")]
			public <>c()
			{
			}

			[Address(RVA="0x1D08BAC", Offset="0x1D08BAC", VA="0x1D08BAC")]
			internal HomePvpResponse <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}