using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class BootstrapConfig : ISerializationCallbackReceiver
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1054D14", Offset="0x1054D14")]
	[FieldOffset(Offset="0x10")]
	private Glunies.LogLevel <DefaultLogLevel>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1054D24", Offset="0x1054D24")]
	[FieldOffset(Offset="0x18")]
	private Dictionary<LogCategory, Glunies.LogLevel> <LogLevels>k__BackingField;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private string client_version;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private string client_build_num;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private string service_url;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private string default_log_level;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private List<BootstrapConfig.LogLevelKvp> log_levels;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private string server_maintenance_url;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private BootstrapConfig.DebugSettings debug_settings;

	public string ClientBuildNum
	{
		[Address(RVA="0x1120244", Offset="0x1120244", VA="0x1120244")]
		get
		{
			return null;
		}
	}

	public string ClientVersion
	{
		[Address(RVA="0x112023C", Offset="0x112023C", VA="0x112023C")]
		get
		{
			return null;
		}
	}

	public Glunies.LogLevel DefaultLogLevel
	{
		[Address(RVA="0x1120254", Offset="0x1120254", VA="0x1120254")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E8A8", Offset="0x106E8A8")]
		get
		{
			return new Glunies.LogLevel();
		}
		[Address(RVA="0x112025C", Offset="0x112025C", VA="0x112025C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E8B8", Offset="0x106E8B8")]
		private set
		{
		}
	}

	public Dictionary<LogCategory, Glunies.LogLevel> LogLevels
	{
		[Address(RVA="0x1120264", Offset="0x1120264", VA="0x1120264")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E8C8", Offset="0x106E8C8")]
		get
		{
			return null;
		}
		[Address(RVA="0x112026C", Offset="0x112026C", VA="0x112026C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E8D8", Offset="0x106E8D8")]
		private set
		{
		}
	}

	public string ServerMaintenanceUrl
	{
		[Address(RVA="0x1120274", Offset="0x1120274", VA="0x1120274")]
		get
		{
			return null;
		}
	}

	public string ServiceUrl
	{
		[Address(RVA="0x112024C", Offset="0x112024C", VA="0x112024C")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x112062C", Offset="0x112062C", VA="0x112062C")]
	public BootstrapConfig()
	{
	}

	[Address(RVA="0x112027C", Offset="0x112027C", VA="0x112027C")]
	public void ApplyLogLevels()
	{
	}

	[Address(RVA="0x1120444", Offset="0x1120444", VA="0x1120444", Slot="5")]
	public void OnAfterDeserialize()
	{
	}

	[Address(RVA="0x1120440", Offset="0x1120440", VA="0x1120440", Slot="4")]
	public void OnBeforeSerialize()
	{
	}

	[Serializable]
	private class DebugSettings
	{
		[FieldOffset(Offset="0x10")]
		public string gamedata_base_url;

		[FieldOffset(Offset="0x18")]
		public string loc_base_url;

		[FieldOffset(Offset="0x20")]
		public string asset_base_url;

		[FieldOffset(Offset="0x28")]
		public bool validate_asset_ids;

		[FieldOffset(Offset="0x30")]
		public string admin_server_url;

		[Address(RVA="0x112070C", Offset="0x112070C", VA="0x112070C")]
		public DebugSettings()
		{
		}
	}

	public static class Factory
	{
		[Address(RVA="0x1120714", Offset="0x1120714", VA="0x1120714")]
		public static BootstrapConfig Create()
		{
			return null;
		}
	}

	[Serializable]
	private class LogLevelKvp
	{
		[FieldOffset(Offset="0x10")]
		public string category;

		[FieldOffset(Offset="0x18")]
		public string level;

		[Address(RVA="0x1120790", Offset="0x1120790", VA="0x1120790")]
		public LogLevelKvp()
		{
		}
	}
}