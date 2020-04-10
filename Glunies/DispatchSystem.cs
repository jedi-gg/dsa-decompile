using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Glunies
{
	public class DispatchSystem
	{
		[FieldOffset(Offset="0x10")]
		private readonly Type _genericDispatchHandlerType;

		[FieldOffset(Offset="0x18")]
		private Dictionary<Type, List<IDispatchHandler>> _actionTypeToHandlers;

		[FieldOffset(Offset="0x20")]
		private List<DispatchSystem.DPendingRequest> _pendingRequests;

		[FieldOffset(Offset="0x28")]
		private int _numberOfActionsCurrentlyDispatching;

		[Address(RVA="0x1420F70", Offset="0x1420F70", VA="0x1420F70")]
		public DispatchSystem()
		{
		}

		[Address(RVA="0x19A3334", Offset="0x19A3334", VA="0x19A3334")]
		public void Dispatch<T>(T gameAction)
		where T : struct
		{
		}

		[Address(RVA="0x1418ED4", Offset="0x1418ED4", VA="0x1418ED4")]
		public void Register(IDispatchHandler handler)
		{
		}

		[Address(RVA="0x28C58AC", Offset="0x28C58AC", VA="0x28C58AC")]
		public void Register<T>(IDispatchHandler handler)
		where T : struct
		{
		}

		[Address(RVA="0x14210F4", Offset="0x14210F4", VA="0x14210F4")]
		private void Register(IDispatchHandler handler, Type actionType)
		{
		}

		[Address(RVA="0x1421068", Offset="0x1421068", VA="0x1421068")]
		public void Shutdown()
		{
		}

		[Address(RVA="0x1417724", Offset="0x1417724", VA="0x1417724")]
		public void Unregister(IDispatchHandler handler)
		{
		}

		[Address(RVA="0x28C5B3C", Offset="0x28C5B3C", VA="0x28C5B3C")]
		public void Unregister<T>(IDispatchHandler handler)
		where T : struct
		{
		}

		[Address(RVA="0x1421340", Offset="0x1421340", VA="0x1421340")]
		private void Unregister(IDispatchHandler handler, Type actionType)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050E78", Offset="0x1050E78")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static DispatchSystem.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static Predicate<IDispatchHandler> <>9__7_0;

			[Address(RVA="0x1421494", Offset="0x1421494", VA="0x1421494")]
			static <>c()
			{
			}

			[Address(RVA="0x14214F8", Offset="0x14214F8", VA="0x14214F8")]
			public <>c()
			{
			}

			[Address(RVA="0x1421500", Offset="0x1421500", VA="0x1421500")]
			internal bool <Register>b__7_0(IDispatchHandler h)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050E88", Offset="0x1050E88")]
		private sealed class <>c__DisplayClass8_0
		{
			[FieldOffset(Offset="0x10")]
			public IDispatchHandler handler;

			[Address(RVA="0x142148C", Offset="0x142148C", VA="0x142148C")]
			public <>c__DisplayClass8_0()
			{
			}

			[Address(RVA="0x1421520", Offset="0x1421520", VA="0x1421520")]
			internal bool <Unregister>b__0(IDispatchHandler h)
			{
				return new bool();
			}
		}

		private struct DPendingRequest
		{
			[FieldOffset(Offset="0x0")]
			public IDispatchHandler Handler;

			[FieldOffset(Offset="0x8")]
			public Type ActionType;

			[FieldOffset(Offset="0x10")]
			public DispatchSystem.RequestType RequestType;
		}

		private enum RequestType
		{
			[FieldOffset(Offset="0x0")]
			Register,
			[FieldOffset(Offset="0x0")]
			Unregister
		}
	}
}