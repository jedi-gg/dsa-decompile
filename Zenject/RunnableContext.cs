using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Zenject
{
	public abstract class RunnableContext : Context
	{
		[Attribute(Name="TooltipAttribute", RVA="0x1060314", Offset="0x1060314")]
		[FieldOffset(Offset="0x40")]
		[SerializeField]
		private bool _autoRun;

		[FieldOffset(Offset="0x0")]
		private static bool _staticAutoRun;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060360", Offset="0x1060360")]
		[FieldOffset(Offset="0x41")]
		private bool <Initialized>k__BackingField;

		public bool Initialized
		{
			[Address(RVA="0x1844CA8", Offset="0x1844CA8", VA="0x1844CA8")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072BA8", Offset="0x1072BA8")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1844CB0", Offset="0x1844CB0", VA="0x1844CB0")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072BB8", Offset="0x1072BB8")]
			private set
			{
			}
		}

		[Address(RVA="0x1844D34", Offset="0x1844D34", VA="0x1844D34")]
		static RunnableContext()
		{
		}

		[Address(RVA="0x18376E0", Offset="0x18376E0", VA="0x18376E0")]
		protected RunnableContext()
		{
		}

		[Address(RVA="0x15751CC", Offset="0x15751CC", VA="0x15751CC")]
		public static T CreateComponent<T>(GameObject gameObject)
		where T : RunnableContext
		{
			return null;
		}

		[Address(RVA="0x18368B8", Offset="0x18368B8", VA="0x18368B8")]
		protected void Initialize()
		{
		}

		[Address(RVA="0x1844CBC", Offset="0x1844CBC", VA="0x1844CBC")]
		public void Run()
		{
		}

		protected abstract void RunInternal();
	}
}