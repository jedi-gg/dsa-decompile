using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class EnemyUnitPreview : IMessage<EnemyUnitPreview>, IMessage, IEquatable<EnemyUnitPreview>, IDeepCloneable<EnemyUnitPreview>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<EnemyUnitPreview> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ContentIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong contentId_;

		[FieldOffset(Offset="0x0")]
		public const int IconFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string icon_;

		[FieldOffset(Offset="0x0")]
		public const int RangeFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private float range_;

		[FieldOffset(Offset="0x0")]
		public const int NameKeyFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private string nameKey_;

		[FieldOffset(Offset="0x0")]
		public const int CategoriesFieldNumber = 5;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ulong> _repeated_categories_codec;

		[FieldOffset(Offset="0x38")]
		private readonly RepeatedField<ulong> categories_;

		[FieldOffset(Offset="0x0")]
		public const int UnitTypeFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private ulong unitType_;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1061774", Offset="0x1061774")]
		[FieldOffset(Offset="0x48")]
		private bool <ShowHealth>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1061784", Offset="0x1061784")]
		[FieldOffset(Offset="0x49")]
		private bool <IsAlive>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1061794", Offset="0x1061794")]
		[FieldOffset(Offset="0x4C")]
		private float <HealthPercent>k__BackingField;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094208", Offset="0x1094208")]
		public RepeatedField<ulong> Categories
		{
			[Address(RVA="0x1FBEA20", Offset="0x1FBEA20", VA="0x1FBEA20")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10941C8", Offset="0x10941C8")]
		public ulong ContentId
		{
			[Address(RVA="0x1FBE910", Offset="0x1FBE910", VA="0x1FBE910")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FBE918", Offset="0x1FBE918", VA="0x1FBE918")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10941A8", Offset="0x10941A8")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FBE5CC", Offset="0x1FBE5CC", VA="0x1FBE5CC")]
			get
			{
				return null;
			}
		}

		public float HealthPercent
		{
			[Address(RVA="0x1FBF5F0", Offset="0x1FBF5F0", VA="0x1FBF5F0")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1079A5C", Offset="0x1079A5C")]
			get
			{
				return new float();
			}
			[Address(RVA="0x1FBF5F8", Offset="0x1FBF5F8", VA="0x1FBF5F8")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1079A6C", Offset="0x1079A6C")]
			private set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10941D8", Offset="0x10941D8")]
		public string Icon
		{
			[Address(RVA="0x1FBE920", Offset="0x1FBE920", VA="0x1FBE920")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FBE928", Offset="0x1FBE928", VA="0x1FBE928")]
			set
			{
			}
		}

		public bool IsAlive
		{
			[Address(RVA="0x1FBF5DC", Offset="0x1FBF5DC", VA="0x1FBF5DC")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1079A3C", Offset="0x1079A3C")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1FBF5E4", Offset="0x1FBF5E4", VA="0x1FBF5E4")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1079A4C", Offset="0x1079A4C")]
			private set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10941F8", Offset="0x10941F8")]
		public string NameKey
		{
			[Address(RVA="0x1FBE9A8", Offset="0x1FBE9A8", VA="0x1FBE9A8")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FBE9B0", Offset="0x1FBE9B0", VA="0x1FBE9B0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094198", Offset="0x1094198")]
		public static MessageParser<EnemyUnitPreview> Parser
		{
			[Address(RVA="0x1FBE564", Offset="0x1FBE564", VA="0x1FBE564")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10941B8", Offset="0x10941B8")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FBE6BC", Offset="0x1FBE6BC", VA="0x1FBE6BC", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10941E8", Offset="0x10941E8")]
		public float Range
		{
			[Address(RVA="0x1FBE998", Offset="0x1FBE998", VA="0x1FBE998")]
			get
			{
				return new float();
			}
			[Address(RVA="0x1FBE9A0", Offset="0x1FBE9A0", VA="0x1FBE9A0")]
			set
			{
			}
		}

		public bool ShowHealth
		{
			[Address(RVA="0x1FBF5C8", Offset="0x1FBF5C8", VA="0x1FBF5C8")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1079A1C", Offset="0x1079A1C")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1FBF5D0", Offset="0x1FBF5D0", VA="0x1FBF5D0")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1079A2C", Offset="0x1079A2C")]
			private set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094218", Offset="0x1094218")]
		public ulong UnitType
		{
			[Address(RVA="0x1FBEA28", Offset="0x1FBEA28", VA="0x1FBEA28")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FBEA30", Offset="0x1FBEA30", VA="0x1FBEA30")]
			set
			{
			}
		}

		[Address(RVA="0x1FBF618", Offset="0x1FBF618", VA="0x1FBF618")]
		static EnemyUnitPreview()
		{
		}

		[Address(RVA="0x1FBE718", Offset="0x1FBE718", VA="0x1FBE718")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107996C", Offset="0x107996C")]
		public EnemyUnitPreview()
		{
		}

		[Address(RVA="0x1FBE79C", Offset="0x1FBE79C", VA="0x1FBE79C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107997C", Offset="0x107997C")]
		public EnemyUnitPreview(EnemyUnitPreview other)
		{
		}

		[Address(RVA="0x1FBF0EC", Offset="0x1FBF0EC", VA="0x1FBF0EC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10799EC", Offset="0x10799EC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FBE8B0", Offset="0x1FBE8B0", VA="0x1FBE8B0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107998C", Offset="0x107998C")]
		public EnemyUnitPreview Clone()
		{
			return null;
		}

		[Address(RVA="0x1FBF600", Offset="0x1FBF600", VA="0x1FBF600")]
		public void EnableHealthPreview(bool isAlive, float healthPercent)
		{
		}

		[Address(RVA="0x1FBEA38", Offset="0x1FBEA38", VA="0x1FBEA38", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107999C", Offset="0x107999C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FBEAAC", Offset="0x1FBEAAC", VA="0x1FBEAAC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10799AC", Offset="0x10799AC")]
		public bool Equals(EnemyUnitPreview other)
		{
			return new bool();
		}

		[Address(RVA="0x1FBEC08", Offset="0x1FBEC08", VA="0x1FBEC08", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10799BC", Offset="0x10799BC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FBF2E0", Offset="0x1FBF2E0", VA="0x1FBF2E0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10799FC", Offset="0x10799FC")]
		public void MergeFrom(EnemyUnitPreview other)
		{
		}

		[Address(RVA="0x1FBF3F0", Offset="0x1FBF3F0", VA="0x1FBF3F0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079A0C", Offset="0x1079A0C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FBEDC8", Offset="0x1FBEDC8", VA="0x1FBEDC8", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10799CC", Offset="0x10799CC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FBEE30", Offset="0x1FBEE30", VA="0x1FBEE30", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10799DC", Offset="0x10799DC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F538", Offset="0x104F538")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static EnemyUnitPreview.<>c <>9;

			[Address(RVA="0x1FBF708", Offset="0x1FBF708", VA="0x1FBF708")]
			static <>c()
			{
			}

			[Address(RVA="0x1FBF76C", Offset="0x1FBF76C", VA="0x1FBF76C")]
			public <>c()
			{
			}

			[Address(RVA="0x1FBF774", Offset="0x1FBF774", VA="0x1FBF774")]
			internal EnemyUnitPreview <.cctor>b__63_0()
			{
				return null;
			}
		}
	}
}