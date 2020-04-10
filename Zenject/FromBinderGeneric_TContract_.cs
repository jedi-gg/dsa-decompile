using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject
{
	public class FromBinderGeneric<TContract> : FromBinder
	{
		[Address(RVA="0x234BA70", Offset="0x234BA70", VA="0x234BA70")]
		public FromBinderGeneric(Zenject.BindInfo bindInfo, BindFinalizerWrapper finalizerWrapper)
		{
		}

		[Address(RVA="0x234BC30", Offset="0x234BC30", VA="0x234BC30")]
		public ScopeArgConditionCopyNonLazyBinder FromComponentInChildren(Func<TContract, bool> predicate, bool includeInactive = false)
		{
			return null;
		}

		[Address(RVA="0x234BC88", Offset="0x234BC88", VA="0x234BC88")]
		public ScopeArgConditionCopyNonLazyBinder FromComponentInChildren(bool excludeSelf = false, Func<TContract, bool> predicate = // 
		// Current member / type: Zenject.ScopeArgConditionCopyNonLazyBinder Zenject.FromBinderGeneric`1::FromComponentInChildren(System.Boolean,System.Func`2<TContract,System.Boolean>,System.Boolean)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: Zenject.ScopeArgConditionCopyNonLazyBinder FromComponentInChildren(System.Boolean,System.Func<TContract,System.Boolean>,System.Boolean)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x234C0D8", Offset="0x234C0D8", VA="0x234C0D8")]
		public ScopeArgConditionCopyNonLazyBinder FromComponentInHierarchy(Func<TContract, bool> predicate = // 
		// Current member / type: Zenject.ScopeArgConditionCopyNonLazyBinder Zenject.FromBinderGeneric`1::FromComponentInHierarchy(System.Func`2<TContract,System.Boolean>,System.Boolean)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: Zenject.ScopeArgConditionCopyNonLazyBinder FromComponentInHierarchy(System.Func<TContract,System.Boolean>,System.Boolean)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x234BDD0", Offset="0x234BDD0", VA="0x234BDD0")]
		public ScopeArgConditionCopyNonLazyBinder FromComponentInParents(bool excludeSelf = false)
		{
			return null;
		}

		[Address(RVA="0x234BED4", Offset="0x234BED4", VA="0x234BED4")]
		public ScopeArgConditionCopyNonLazyBinder FromComponentSibling()
		{
			return null;
		}

		[Address(RVA="0x2AFB8EC", Offset="0x2AFB8EC", VA="0x2AFB8EC")]
		public ScopeArgConditionCopyNonLazyBinder FromFactory<TFactory>()
		where TFactory : IFactory<TContract>
		{
			return null;
		}

		[Address(RVA="0x234BBFC", Offset="0x234BBFC", VA="0x234BBFC")]
		public ScopeConditionCopyNonLazyBinder FromInstance(TContract instance)
		{
			return null;
		}

		[Address(RVA="0x234BB64", Offset="0x234BB64", VA="0x234BB64")]
		public ScopeArgConditionCopyNonLazyBinder FromMethod(Func<InjectContext, TContract> method)
		{
			return null;
		}

		[Address(RVA="0x234BBB0", Offset="0x234BBB0", VA="0x234BBB0")]
		public ScopeArgConditionCopyNonLazyBinder FromMethodMultiple(Func<InjectContext, IEnumerable<TContract>> method)
		{
			return null;
		}

		[Address(RVA="0x2AFBCAC", Offset="0x2AFBCAC", VA="0x2AFBCAC")]
		public ScopeConditionCopyNonLazyBinder FromResolveGetter<TObj>(Func<TObj, TContract> method)
		{
			return null;
		}

		[Address(RVA="0x2AFBCF8", Offset="0x2AFBCF8", VA="0x2AFBCF8")]
		public ScopeConditionCopyNonLazyBinder FromResolveGetter<TObj>(object identifier, Func<TObj, TContract> method)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DA28", Offset="0x104DA28")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static FromBinderGeneric<TContract>.<>c <>9;

			[FieldOffset(Offset="0x0")]
			public static Func<InjectContext, IEnumerable<TContract>> <>9__10_0;

			[Address(RVA="0x234A99C", Offset="0x234A99C", VA="0x234A99C")]
			static <>c()
			{
			}

			[Address(RVA="0x234AA74", Offset="0x234AA74", VA="0x234AA74")]
			public <>c()
			{
			}

			[Address(RVA="0x234AAA0", Offset="0x234AAA0", VA="0x234AAA0")]
			internal IEnumerable<TContract> <FromComponentSibling>b__10_0(InjectContext ctx)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DA18", Offset="0x104DA18")]
		private sealed class <>c__DisplayClass10_0
		{
			[FieldOffset(Offset="0x0")]
			public InjectContext ctx;

			[Address(RVA="0x234AD54", Offset="0x234AD54", VA="0x234AD54")]
			public <>c__DisplayClass10_0()
			{
			}

			[Address(RVA="0x234AD80", Offset="0x234AD80", VA="0x234AD80")]
			internal bool <FromComponentSibling>b__1(TContract x)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DA38", Offset="0x104DA38")]
		private sealed class <>c__DisplayClass11_0
		{
			[FieldOffset(Offset="0x0")]
			public bool includeInactive;

			[FieldOffset(Offset="0x0")]
			public Func<TContract, bool> predicate;

			[FieldOffset(Offset="0x0")]
			public Func<GameObject, IEnumerable<TContract>> <>9__1;

			[Address(RVA="0x234ADC0", Offset="0x234ADC0", VA="0x234ADC0")]
			public <>c__DisplayClass11_0()
			{
			}

			[Address(RVA="0x234ADEC", Offset="0x234ADEC", VA="0x234ADEC")]
			internal IEnumerable<TContract> <FromComponentInHierarchy>b__0(InjectContext ctx)
			{
				return null;
			}

			[Address(RVA="0x234B000", Offset="0x234B000", VA="0x234B000")]
			internal IEnumerable<TContract> <FromComponentInHierarchy>b__1(GameObject x)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DA48", Offset="0x104DA48")]
		private sealed class <>c__DisplayClass11_1
		{
			[FieldOffset(Offset="0x0")]
			public InjectContext ctx;

			[Address(RVA="0x234B054", Offset="0x234B054", VA="0x234B054")]
			public <>c__DisplayClass11_1()
			{
			}

			[Address(RVA="0x234B080", Offset="0x234B080", VA="0x234B080")]
			internal bool <FromComponentInHierarchy>b__2(TContract x)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D9D8", Offset="0x104D9D8")]
		private sealed class <>c__DisplayClass8_0
		{
			[FieldOffset(Offset="0x0")]
			public bool includeInactive;

			[FieldOffset(Offset="0x0")]
			public bool excludeSelf;

			[FieldOffset(Offset="0x0")]
			public Func<TContract, bool> predicate;

			[Address(RVA="0x234B0C0", Offset="0x234B0C0", VA="0x234B0C0")]
			public <>c__DisplayClass8_0()
			{
			}

			[Address(RVA="0x234B0EC", Offset="0x234B0EC", VA="0x234B0EC")]
			internal IEnumerable<TContract> <FromComponentInChildren>b__0(InjectContext ctx)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D9E8", Offset="0x104D9E8")]
		private sealed class <>c__DisplayClass8_1
		{
			[FieldOffset(Offset="0x0")]
			public InjectContext ctx;

			[Address(RVA="0x234B450", Offset="0x234B450", VA="0x234B450")]
			public <>c__DisplayClass8_1()
			{
			}

			[Address(RVA="0x234B47C", Offset="0x234B47C", VA="0x234B47C")]
			internal bool <FromComponentInChildren>b__1(TContract x)
			{
				return new bool();
			}

			[Address(RVA="0x234B4BC", Offset="0x234B4BC", VA="0x234B4BC")]
			internal bool <FromComponentInChildren>b__2(TContract x)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D9F8", Offset="0x104D9F8")]
		private sealed class <>c__DisplayClass9_0
		{
			[FieldOffset(Offset="0x0")]
			public bool excludeSelf;

			[Address(RVA="0x234B5B4", Offset="0x234B5B4", VA="0x234B5B4")]
			public <>c__DisplayClass9_0()
			{
			}

			[Address(RVA="0x234B5E0", Offset="0x234B5E0", VA="0x234B5E0")]
			internal IEnumerable<TContract> <FromComponentInParents>b__0(InjectContext ctx)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DA08", Offset="0x104DA08")]
		private sealed class <>c__DisplayClass9_1
		{
			[FieldOffset(Offset="0x0")]
			public InjectContext ctx;

			[Address(RVA="0x234B90C", Offset="0x234B90C", VA="0x234B90C")]
			public <>c__DisplayClass9_1()
			{
			}

			[Address(RVA="0x234B938", Offset="0x234B938", VA="0x234B938")]
			internal bool <FromComponentInParents>b__1(TContract x)
			{
				return new bool();
			}

			[Address(RVA="0x234B978", Offset="0x234B978", VA="0x234B978")]
			internal bool <FromComponentInParents>b__2(TContract x)
			{
				return new bool();
			}
		}
	}
}