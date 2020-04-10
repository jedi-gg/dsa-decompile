using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class StandardSingletonDeclaration
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060704", Offset="0x1060704")]
		[FieldOffset(Offset="0x10")]
		private List<TypeValuePair> <Arguments>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060714", Offset="0x1060714")]
		[FieldOffset(Offset="0x18")]
		private SingletonId <Id>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060724", Offset="0x1060724")]
		[FieldOffset(Offset="0x20")]
		private SingletonTypes <Type>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060734", Offset="0x1060734")]
		[FieldOffset(Offset="0x28")]
		private object <SpecificId>k__BackingField;

		public List<TypeValuePair> Arguments
		{
			[Address(RVA="0x2334AE0", Offset="0x2334AE0", VA="0x2334AE0")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1073BC0", Offset="0x1073BC0")]
			get
			{
				return null;
			}
			[Address(RVA="0x2334A34", Offset="0x2334A34", VA="0x2334A34")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1073BD0", Offset="0x1073BD0")]
			private set
			{
			}
		}

		public SingletonId Id
		{
			[Address(RVA="0x2334AE8", Offset="0x2334AE8", VA="0x2334AE8")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1073BE0", Offset="0x1073BE0")]
			get
			{
				return null;
			}
			[Address(RVA="0x2334A1C", Offset="0x2334A1C", VA="0x2334A1C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1073BF0", Offset="0x1073BF0")]
			private set
			{
			}
		}

		public object SpecificId
		{
			[Address(RVA="0x2334AF8", Offset="0x2334AF8", VA="0x2334AF8")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1073C20", Offset="0x1073C20")]
			get
			{
				return null;
			}
			[Address(RVA="0x2334A2C", Offset="0x2334A2C", VA="0x2334A2C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1073C30", Offset="0x1073C30")]
			private set
			{
			}
		}

		public SingletonTypes Type
		{
			[Address(RVA="0x2334AF0", Offset="0x2334AF0", VA="0x2334AF0")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1073C00", Offset="0x1073C00")]
			get
			{
				return new SingletonTypes();
			}
			[Address(RVA="0x2334A24", Offset="0x2334A24", VA="0x2334A24")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1073C10", Offset="0x1073C10")]
			private set
			{
			}
		}

		[Address(RVA="0x23349CC", Offset="0x23349CC", VA="0x23349CC")]
		public StandardSingletonDeclaration(SingletonId id, List<TypeValuePair> args, SingletonTypes type, object singletonSpecificId)
		{
		}

		[Address(RVA="0x2334A3C", Offset="0x2334A3C", VA="0x2334A3C")]
		public StandardSingletonDeclaration(System.Type concreteType, object concreteIdentifier, List<TypeValuePair> args, SingletonTypes type, object singletonSpecificId)
		{
		}
	}
}