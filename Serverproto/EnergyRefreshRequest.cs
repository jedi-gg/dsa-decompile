using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class EnergyRefreshRequest : IMessage<EnergyRefreshRequest>, IMessage, IEquatable<EnergyRefreshRequest>, IDeepCloneable<EnergyRefreshRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<EnergyRefreshRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int EnergyItemIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong energyItemId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A440", Offset="0x109A440")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FBF834", Offset="0x1FBF834", VA="0x1FBF834")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A460", Offset="0x109A460")]
		public ulong EnergyItemId
		{
			[Address(RVA="0x1FBFA4C", Offset="0x1FBFA4C", VA="0x1FBFA4C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FBFA54", Offset="0x1FBFA54", VA="0x1FBFA54")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A430", Offset="0x109A430")]
		public static MessageParser<EnergyRefreshRequest> Parser
		{
			[Address(RVA="0x1FBF7CC", Offset="0x1FBF7CC", VA="0x1FBF7CC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A450", Offset="0x109A450")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FBF924", Offset="0x1FBF924", VA="0x1FBF924", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1FBFDC8", Offset="0x1FBFDC8", VA="0x1FBFDC8")]
		static EnergyRefreshRequest()
		{
		}

		[Address(RVA="0x1FBF980", Offset="0x1FBF980", VA="0x1FBF980")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10843DC", Offset="0x10843DC")]
		public EnergyRefreshRequest()
		{
		}

		[Address(RVA="0x1FBF988", Offset="0x1FBF988", VA="0x1FBF988")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10843EC", Offset="0x10843EC")]
		public EnergyRefreshRequest(EnergyRefreshRequest other)
		{
		}

		[Address(RVA="0x1FBFC7C", Offset="0x1FBFC7C", VA="0x1FBFC7C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108445C", Offset="0x108445C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FBF9EC", Offset="0x1FBF9EC", VA="0x1FBF9EC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10843FC", Offset="0x10843FC")]
		public EnergyRefreshRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1FBFA5C", Offset="0x1FBFA5C", VA="0x1FBFA5C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108440C", Offset="0x108440C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FBFAD0", Offset="0x1FBFAD0", VA="0x1FBFAD0", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108441C", Offset="0x108441C")]
		public bool Equals(EnergyRefreshRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1FBFB0C", Offset="0x1FBFB0C", VA="0x1FBFB0C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108442C", Offset="0x108442C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FBFD0C", Offset="0x1FBFD0C", VA="0x1FBFD0C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108446C", Offset="0x108446C")]
		public void MergeFrom(EnergyRefreshRequest other)
		{
		}

		[Address(RVA="0x1FBFD4C", Offset="0x1FBFD4C", VA="0x1FBFD4C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108447C", Offset="0x108447C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FBFB74", Offset="0x1FBFB74", VA="0x1FBFB74", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108443C", Offset="0x108443C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FBFBDC", Offset="0x1FBFBDC", VA="0x1FBFBDC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108444C", Offset="0x108444C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10504B8", Offset="0x10504B8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static EnergyRefreshRequest.<>c <>9;

			[Address(RVA="0x1FBFEA0", Offset="0x1FBFEA0", VA="0x1FBFEA0")]
			static <>c()
			{
			}

			[Address(RVA="0x1FBFF04", Offset="0x1FBFF04", VA="0x1FBFF04")]
			public <>c()
			{
			}

			[Address(RVA="0x1FBFF0C", Offset="0x1FBFF0C", VA="0x1FBFF0C")]
			internal EnergyRefreshRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}