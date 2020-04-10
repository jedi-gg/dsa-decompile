using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Networking;

public class ServerMaintenanceUtil : ILoggable<LogCategory>
{
	[Attribute(Name="InjectAttribute", RVA="0x105FB30", Offset="0x105FB30")]
	[FieldOffset(Offset="0x10")]
	private BootstrapConfig _bootstrapConfig;

	public LogCategory LogCategory
	{
		[Address(RVA="0x2C4255C", Offset="0x2C4255C", VA="0x2C4255C", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x2C4272C", Offset="0x2C4272C", VA="0x2C4272C")]
	public ServerMaintenanceUtil()
	{
	}

	[Address(RVA="0x2C42564", Offset="0x2C42564", VA="0x2C42564")]
	public void CheckForMaintenanceMode(Action<DServerMaintenance> finished)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D1EC", Offset="0x104D1EC")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public ServerMaintenanceUtil <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action<DServerMaintenance> finished;

		[Address(RVA="0x2C4271C", Offset="0x2C4271C", VA="0x2C4271C")]
		public <>c__DisplayClass2_0()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D1FC", Offset="0x104D1FC")]
	private sealed class <>c__DisplayClass2_1
	{
		[FieldOffset(Offset="0x10")]
		public UnityWebRequest webRequest;

		[FieldOffset(Offset="0x18")]
		public ServerMaintenanceUtil.<>c__DisplayClass2_0 CS$<>8__locals1;

		[Address(RVA="0x2C42724", Offset="0x2C42724", VA="0x2C42724")]
		public <>c__DisplayClass2_1()
		{
		}

		[Address(RVA="0x2C42734", Offset="0x2C42734", VA="0x2C42734")]
		internal void <CheckForMaintenanceMode>b__0(AsyncOperation asyncOp)
		{
		}
	}
}