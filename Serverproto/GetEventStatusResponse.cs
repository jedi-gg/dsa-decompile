using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class GetEventStatusResponse : IMessage<GetEventStatusResponse>, IMessage, IEquatable<GetEventStatusResponse>, IDeepCloneable<GetEventStatusResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<GetEventStatusResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int StatusFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private EventStatus status_;

		[FieldOffset(Offset="0x0")]
		public const int StatusesFieldNumber = 2;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<EventStatus> _repeated_statuses_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<EventStatus> statuses_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097650", Offset="0x1097650")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BAA5CC", Offset="0x1BAA5CC", VA="0x1BAA5CC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097640", Offset="0x1097640")]
		public static MessageParser<GetEventStatusResponse> Parser
		{
			[Address(RVA="0x1BAA564", Offset="0x1BAA564", VA="0x1BAA564")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097660", Offset="0x1097660")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BAA6BC", Offset="0x1BAA6BC", VA="0x1BAA6BC", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097670", Offset="0x1097670")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x1097670", Offset="0x1097670")]
		public EventStatus Status
		{
			[Address(RVA="0x1BAA84C", Offset="0x1BAA84C", VA="0x1BAA84C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BAA854", Offset="0x1BAA854", VA="0x1BAA854")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10976A8", Offset="0x10976A8")]
		public RepeatedField<EventStatus> Statuses
		{
			[Address(RVA="0x1B98358", Offset="0x1B98358", VA="0x1B98358")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1BAAF10", Offset="0x1BAAF10", VA="0x1BAAF10")]
		static GetEventStatusResponse()
		{
		}

		[Address(RVA="0x1BAA718", Offset="0x1BAA718", VA="0x1BAA718")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FF8C", Offset="0x107FF8C")]
		public GetEventStatusResponse()
		{
		}

		[Address(RVA="0x1BAA788", Offset="0x1BAA788", VA="0x1BAA788")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FF9C", Offset="0x107FF9C")]
		public GetEventStatusResponse(GetEventStatusResponse other)
		{
		}

		[Address(RVA="0x1BAAC00", Offset="0x1BAAC00", VA="0x1BAAC00", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108000C", Offset="0x108000C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BAA85C", Offset="0x1BAA85C", VA="0x1BAA85C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FFAC", Offset="0x107FFAC")]
		public GetEventStatusResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1BAA8BC", Offset="0x1BAA8BC", VA="0x1BAA8BC", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FFBC", Offset="0x107FFBC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BAA930", Offset="0x1BAA930", VA="0x1BAA930", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FFCC", Offset="0x107FFCC")]
		public bool Equals(GetEventStatusResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1BAA9F4", Offset="0x1BAA9F4", VA="0x1BAA9F4", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FFDC", Offset="0x107FFDC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BAACFC", Offset="0x1BAACFC", VA="0x1BAACFC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108001C", Offset="0x108001C")]
		public void MergeFrom(GetEventStatusResponse other)
		{
		}

		[Address(RVA="0x1BAADD4", Offset="0x1BAADD4", VA="0x1BAADD4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108002C", Offset="0x108002C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BAAA7C", Offset="0x1BAAA7C", VA="0x1BAAA7C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FFEC", Offset="0x107FFEC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BAAAE4", Offset="0x1BAAAE4", VA="0x1BAAAE4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FFFC", Offset="0x107FFFC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FE88", Offset="0x104FE88")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static GetEventStatusResponse.<>c <>9;

			[Address(RVA="0x1BAB030", Offset="0x1BAB030", VA="0x1BAB030")]
			static <>c()
			{
			}

			[Address(RVA="0x1BAB094", Offset="0x1BAB094", VA="0x1BAB094")]
			public <>c()
			{
			}

			[Address(RVA="0x1BAB09C", Offset="0x1BAB09C", VA="0x1BAB09C")]
			internal GetEventStatusResponse <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}