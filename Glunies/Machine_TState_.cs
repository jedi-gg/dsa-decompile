using Il2CppDummyDll;
using System;

namespace Glunies
{
	public class Machine<TState> : ILoggable<LogCategory>
	where TState : AState
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1064340", Offset="0x1064340")]
		[FieldOffset(Offset="0x0")]
		private Action<TState> StateExiting;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1064350", Offset="0x1064350")]
		[FieldOffset(Offset="0x0")]
		private Action<TState> StateEntering;

		[FieldOffset(Offset="0x0")]
		protected TState _current;

		[FieldOffset(Offset="0x0")]
		private bool _isExiting;

		[FieldOffset(Offset="0x0")]
		private bool _isEntering;

		[FieldOffset(Offset="0x0")]
		private TState _next;

		[FieldOffset(Offset="0x0")]
		private ITransitionContext _nextContext;

		protected bool IsTransitioning
		{
			[Address(RVA="0x1C02194", Offset="0x1C02194", VA="0x1C02194")]
			get
			{
				return new bool();
			}
		}

		public LogCategory LogCategory
		{
			[Address(RVA="0x1C01980", Offset="0x1C01980", VA="0x1C01980", Slot="4")]
			get
			{
				return new LogCategory();
			}
		}

		[Address(RVA="0x1C021B4", Offset="0x1C021B4", VA="0x1C021B4")]
		public Machine()
		{
		}

		[Address(RVA="0x1C01E64", Offset="0x1C01E64", VA="0x1C01E64", Slot="9")]
		protected virtual bool BeginEnteringState()
		{
			return new bool();
		}

		[Address(RVA="0x1387CA8", Offset="0x1387CA8", VA="0x1387CA8", Slot="5")]
		public virtual void EnterState<UState>(ITransitionContext context = // 
		// Current member / type: System.Void Glunies.Machine`1::EnterState(Glunies.ITransitionContext)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void EnterState(Glunies.ITransitionContext)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x1C01D48", Offset="0x1C01D48", VA="0x1C01D48", Slot="6")]
		public virtual void EnterState(TState state, ITransitionContext context = // 
		// Current member / type: System.Void Glunies.Machine`1::EnterState(TState,Glunies.ITransitionContext)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void EnterState(TState,Glunies.ITransitionContext)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x1C01E80", Offset="0x1C01E80", VA="0x1C01E80")]
		protected void EnterStateInternal(TState entering, ITransitionContext context)
		{
		}

		[Address(RVA="0x1C02024", Offset="0x1C02024", VA="0x1C02024")]
		protected void ExitCurrentState(TState nextState, Action finished)
		{
		}

		[Address(RVA="0x1C01E6C", Offset="0x1C01E6C", VA="0x1C01E6C", Slot="10")]
		protected virtual void FinishExitingState(TState nextState, Action finished)
		{
		}

		[Address(RVA="0x1C01E20", Offset="0x1C01E20", VA="0x1C01E20", Slot="7")]
		public virtual void Initialize()
		{
		}

		[Address(RVA="0x1C01E24", Offset="0x1C01E24", VA="0x1C01E24", Slot="8")]
		public virtual void Shutdown()
		{
		}

		public event Action<TState> StateEntering
		{
			[Address(RVA="0x1C01B68", Offset="0x1C01B68", VA="0x1C01B68")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A384", Offset="0x108A384")]
			add
			{
			}
			[Address(RVA="0x1C01C58", Offset="0x1C01C58", VA="0x1C01C58")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A394", Offset="0x108A394")]
			remove
			{
			}
		}

		public event Action<TState> StateExiting
		{
			[Address(RVA="0x1C01988", Offset="0x1C01988", VA="0x1C01988")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A364", Offset="0x108A364")]
			add
			{
			}
			[Address(RVA="0x1C01A78", Offset="0x1C01A78", VA="0x1C01A78")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A374", Offset="0x108A374")]
			remove
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051078", Offset="0x1051078")]
		private sealed class <>c__DisplayClass14_0
		{
			[FieldOffset(Offset="0x0")]
			public Machine<TState> <>4__this;

			[FieldOffset(Offset="0x0")]
			public TState entering;

			[FieldOffset(Offset="0x0")]
			public ITransitionContext context;

			[Address(RVA="0x1C016DC", Offset="0x1C016DC", VA="0x1C016DC")]
			public <>c__DisplayClass14_0()
			{
			}

			[Address(RVA="0x1C01708", Offset="0x1C01708", VA="0x1C01708")]
			internal void <EnterStateInternal>b__0()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051088", Offset="0x1051088")]
		private sealed class <>c__DisplayClass15_0
		{
			[FieldOffset(Offset="0x0")]
			public Action finished;

			[FieldOffset(Offset="0x0")]
			public Machine<TState> <>4__this;

			[Address(RVA="0x1C018E4", Offset="0x1C018E4", VA="0x1C018E4")]
			public <>c__DisplayClass15_0()
			{
			}

			[Address(RVA="0x1C01910", Offset="0x1C01910", VA="0x1C01910")]
			internal void <ExitCurrentState>b__0()
			{
			}

			[Address(RVA="0x1C01924", Offset="0x1C01924", VA="0x1C01924")]
			internal void <ExitCurrentState>b__1()
			{
			}
		}
	}
}