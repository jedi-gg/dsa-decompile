using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class HomeTowerStatusResponse : IMessage<HomeTowerStatusResponse>, IMessage, IEquatable<HomeTowerStatusResponse>, IDeepCloneable<HomeTowerStatusResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<HomeTowerStatusResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int CurrentNodeFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private uint currentNode_;

		[FieldOffset(Offset="0x0")]
		public const int TotalNodesFieldNumber = 2;

		[FieldOffset(Offset="0x1C")]
		private uint totalNodes_;

		[FieldOffset(Offset="0x0")]
		public const int TowerIdFieldNumber = 3;

		[FieldOffset(Offset="0x20")]
		private TowerIdentifier towerId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097AC0", Offset="0x1097AC0")]
		public uint CurrentNode
		{
			[Address(RVA="0x18D8248", Offset="0x18D8248", VA="0x18D8248")]
			get
			{
				return new uint();
			}
			[Address(RVA="0x18D8250", Offset="0x18D8250", VA="0x18D8250")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097AA0", Offset="0x1097AA0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x18D7FF0", Offset="0x18D7FF0", VA="0x18D7FF0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097A90", Offset="0x1097A90")]
		public static MessageParser<HomeTowerStatusResponse> Parser
		{
			[Address(RVA="0x18D7F88", Offset="0x18D7F88", VA="0x18D7F88")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097AB0", Offset="0x1097AB0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x18D80E0", Offset="0x18D80E0", VA="0x18D80E0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097AD0", Offset="0x1097AD0")]
		public uint TotalNodes
		{
			[Address(RVA="0x18D8258", Offset="0x18D8258", VA="0x18D8258")]
			get
			{
				return new uint();
			}
			[Address(RVA="0x18D8260", Offset="0x18D8260", VA="0x18D8260")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097AE0", Offset="0x1097AE0")]
		public TowerIdentifier TowerId
		{
			[Address(RVA="0x18D81D8", Offset="0x18D81D8", VA="0x18D81D8")]
			get
			{
				return null;
			}
			[Address(RVA="0x18D81E0", Offset="0x18D81E0", VA="0x18D81E0")]
			set
			{
			}
		}

		[Address(RVA="0x18D88C4", Offset="0x18D88C4", VA="0x18D88C4")]
		static HomeTowerStatusResponse()
		{
		}

		[Address(RVA="0x18D813C", Offset="0x18D813C", VA="0x18D813C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108045C", Offset="0x108045C")]
		public HomeTowerStatusResponse()
		{
		}

		[Address(RVA="0x18D8144", Offset="0x18D8144", VA="0x18D8144")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108046C", Offset="0x108046C")]
		public HomeTowerStatusResponse(HomeTowerStatusResponse other)
		{
		}

		[Address(RVA="0x18D85B4", Offset="0x18D85B4", VA="0x18D85B4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10804DC", Offset="0x10804DC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x18D81E8", Offset="0x18D81E8", VA="0x18D81E8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108047C", Offset="0x108047C")]
		public HomeTowerStatusResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x18D8268", Offset="0x18D8268", VA="0x18D8268", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108048C", Offset="0x108048C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x18D82DC", Offset="0x18D82DC", VA="0x18D82DC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108049C", Offset="0x108049C")]
		public bool Equals(HomeTowerStatusResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x18D8360", Offset="0x18D8360", VA="0x18D8360", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10804AC", Offset="0x10804AC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x18D86C4", Offset="0x18D86C4", VA="0x18D86C4", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10804EC", Offset="0x10804EC")]
		public void MergeFrom(HomeTowerStatusResponse other)
		{
		}

		[Address(RVA="0x18D8790", Offset="0x18D8790", VA="0x18D8790", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10804FC", Offset="0x10804FC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x18D83FC", Offset="0x18D83FC", VA="0x18D83FC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10804BC", Offset="0x10804BC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x18D8464", Offset="0x18D8464", VA="0x18D8464", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10804CC", Offset="0x10804CC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FEF8", Offset="0x104FEF8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static HomeTowerStatusResponse.<>c <>9;

			[Address(RVA="0x18D899C", Offset="0x18D899C", VA="0x18D899C")]
			static <>c()
			{
			}

			[Address(RVA="0x18D8A00", Offset="0x18D8A00", VA="0x18D8A00")]
			public <>c()
			{
			}

			[Address(RVA="0x18D8A08", Offset="0x18D8A08", VA="0x18D8A08")]
			internal HomeTowerStatusResponse <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}