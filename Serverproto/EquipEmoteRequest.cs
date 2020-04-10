using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class EquipEmoteRequest : IMessage<EquipEmoteRequest>, IMessage, IEquatable<EquipEmoteRequest>, IDeepCloneable<EquipEmoteRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<EquipEmoteRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int EmoteDeckFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ulong> _repeated_emoteDeck_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<ulong> emoteDeck_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099120", Offset="0x1099120")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FC2CD4", Offset="0x1FC2CD4", VA="0x1FC2CD4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099140", Offset="0x1099140")]
		public RepeatedField<ulong> EmoteDeck
		{
			[Address(RVA="0x1FC2F88", Offset="0x1FC2F88", VA="0x1FC2F88")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099110", Offset="0x1099110")]
		public static MessageParser<EquipEmoteRequest> Parser
		{
			[Address(RVA="0x1FC2C6C", Offset="0x1FC2C6C", VA="0x1FC2C6C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099130", Offset="0x1099130")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FC2DC4", Offset="0x1FC2DC4", VA="0x1FC2DC4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1FC3478", Offset="0x1FC3478", VA="0x1FC3478")]
		static EquipEmoteRequest()
		{
		}

		[Address(RVA="0x1FC2E20", Offset="0x1FC2E20", VA="0x1FC2E20")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108297C", Offset="0x108297C")]
		public EquipEmoteRequest()
		{
		}

		[Address(RVA="0x1FC2E90", Offset="0x1FC2E90", VA="0x1FC2E90")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108298C", Offset="0x108298C")]
		public EquipEmoteRequest(EquipEmoteRequest other)
		{
		}

		[Address(RVA="0x1FC3240", Offset="0x1FC3240", VA="0x1FC3240", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10829FC", Offset="0x10829FC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FC2F28", Offset="0x1FC2F28", VA="0x1FC2F28", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108299C", Offset="0x108299C")]
		public EquipEmoteRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1FC2F90", Offset="0x1FC2F90", VA="0x1FC2F90", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10829AC", Offset="0x10829AC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FC3004", Offset="0x1FC3004", VA="0x1FC3004", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10829BC", Offset="0x10829BC")]
		public bool Equals(EquipEmoteRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1FC30B4", Offset="0x1FC30B4", VA="0x1FC30B4", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10829CC", Offset="0x10829CC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FC32FC", Offset="0x1FC32FC", VA="0x1FC32FC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082A0C", Offset="0x1082A0C")]
		public void MergeFrom(EquipEmoteRequest other)
		{
		}

		[Address(RVA="0x1FC338C", Offset="0x1FC338C", VA="0x1FC338C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082A1C", Offset="0x1082A1C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FC3114", Offset="0x1FC3114", VA="0x1FC3114", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10829DC", Offset="0x10829DC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FC317C", Offset="0x1FC317C", VA="0x1FC317C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10829EC", Offset="0x10829EC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050258", Offset="0x1050258")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static EquipEmoteRequest.<>c <>9;

			[Address(RVA="0x1FC3568", Offset="0x1FC3568", VA="0x1FC3568")]
			static <>c()
			{
			}

			[Address(RVA="0x1FC35CC", Offset="0x1FC35CC", VA="0x1FC35CC")]
			public <>c()
			{
			}

			[Address(RVA="0x1FC35D4", Offset="0x1FC35D4", VA="0x1FC35D4")]
			internal EquipEmoteRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}