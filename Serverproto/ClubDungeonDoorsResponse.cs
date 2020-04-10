using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubDungeonDoorsResponse : IMessage<ClubDungeonDoorsResponse>, IMessage, IEquatable<ClubDungeonDoorsResponse>, IDeepCloneable<ClubDungeonDoorsResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubDungeonDoorsResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int FailedDoorsFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ulong> _repeated_failedDoors_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<ulong> failedDoors_;

		[FieldOffset(Offset="0x0")]
		public const int MapPrefabFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string mapPrefab_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10959E0", Offset="0x10959E0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A4FF98", Offset="0x1A4FF98", VA="0x1A4FF98")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095A00", Offset="0x1095A00")]
		public RepeatedField<ulong> FailedDoors
		{
			[Address(RVA="0x1A50264", Offset="0x1A50264", VA="0x1A50264")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095A10", Offset="0x1095A10")]
		public string MapPrefab
		{
			[Address(RVA="0x1A5026C", Offset="0x1A5026C", VA="0x1A5026C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A50274", Offset="0x1A50274", VA="0x1A50274")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10959D0", Offset="0x10959D0")]
		public static MessageParser<ClubDungeonDoorsResponse> Parser
		{
			[Address(RVA="0x1A4FF30", Offset="0x1A4FF30", VA="0x1A4FF30")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10959F0", Offset="0x10959F0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A50088", Offset="0x1A50088", VA="0x1A50088", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1A5094C", Offset="0x1A5094C", VA="0x1A5094C")]
		static ClubDungeonDoorsResponse()
		{
		}

		[Address(RVA="0x1A500E4", Offset="0x1A500E4", VA="0x1A500E4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CEBC", Offset="0x107CEBC")]
		public ClubDungeonDoorsResponse()
		{
		}

		[Address(RVA="0x1A50164", Offset="0x1A50164", VA="0x1A50164")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CECC", Offset="0x107CECC")]
		public ClubDungeonDoorsResponse(ClubDungeonDoorsResponse other)
		{
		}

		[Address(RVA="0x1A50664", Offset="0x1A50664", VA="0x1A50664", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CF3C", Offset="0x107CF3C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A50204", Offset="0x1A50204", VA="0x1A50204", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CEDC", Offset="0x107CEDC")]
		public ClubDungeonDoorsResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1A502E4", Offset="0x1A502E4", VA="0x1A502E4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CEEC", Offset="0x107CEEC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A50358", Offset="0x1A50358", VA="0x1A50358", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CEFC", Offset="0x107CEFC")]
		public bool Equals(ClubDungeonDoorsResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1A5041C", Offset="0x1A5041C", VA="0x1A5041C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CF0C", Offset="0x107CF0C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A50774", Offset="0x1A50774", VA="0x1A50774", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CF4C", Offset="0x107CF4C")]
		public void MergeFrom(ClubDungeonDoorsResponse other)
		{
		}

		[Address(RVA="0x1A50830", Offset="0x1A50830", VA="0x1A50830", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CF5C", Offset="0x107CF5C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A504C8", Offset="0x1A504C8", VA="0x1A504C8", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CF1C", Offset="0x107CF1C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A50530", Offset="0x1A50530", VA="0x1A50530", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CF2C", Offset="0x107CF2C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FA08", Offset="0x104FA08")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubDungeonDoorsResponse.<>c <>9;

			[Address(RVA="0x1A50A3C", Offset="0x1A50A3C", VA="0x1A50A3C")]
			static <>c()
			{
			}

			[Address(RVA="0x1A50AA0", Offset="0x1A50AA0", VA="0x1A50AA0")]
			public <>c()
			{
			}

			[Address(RVA="0x1A50AA8", Offset="0x1A50AA8", VA="0x1A50AA8")]
			internal ClubDungeonDoorsResponse <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}