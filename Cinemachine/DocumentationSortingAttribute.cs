using Il2CppDummyDll;
using System;

namespace Cinemachine
{
	[Attribute(Name="DocumentationSortingAttribute", RVA="0x104ABA4", Offset="0x104ABA4")]
	public sealed class DocumentationSortingAttribute : Attribute
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1069144", Offset="0x1069144")]
		[FieldOffset(Offset="0x10")]
		private float <SortOrder>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1069154", Offset="0x1069154")]
		[FieldOffset(Offset="0x14")]
		private DocumentationSortingAttribute.Level <Category>k__BackingField;

		public DocumentationSortingAttribute.Level Category
		{
			[Address(RVA="0x145E31C", Offset="0x145E31C", VA="0x145E31C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AF34", Offset="0x108AF34")]
			get
			{
				return new DocumentationSortingAttribute.Level();
			}
			[Address(RVA="0x145E324", Offset="0x145E324", VA="0x145E324")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AF44", Offset="0x108AF44")]
			private set
			{
			}
		}

		public float SortOrder
		{
			[Address(RVA="0x145E30C", Offset="0x145E30C", VA="0x145E30C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AF14", Offset="0x108AF14")]
			get
			{
				return new float();
			}
			[Address(RVA="0x145E314", Offset="0x145E314", VA="0x145E314")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AF24", Offset="0x108AF24")]
			private set
			{
			}
		}

		[Address(RVA="0x145E32C", Offset="0x145E32C", VA="0x145E32C")]
		public DocumentationSortingAttribute(float sortOrder, DocumentationSortingAttribute.Level category)
		{
		}

		public enum Level
		{
			[FieldOffset(Offset="0x0")]
			Undoc,
			[FieldOffset(Offset="0x0")]
			API,
			[FieldOffset(Offset="0x0")]
			UserRef
		}
	}
}