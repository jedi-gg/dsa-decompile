using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class GraphicsSettings
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1058710", Offset="0x1058710")]
	[FieldOffset(Offset="0x10")]
	private DeviceGraphicsSetting <Current>k__BackingField;

	[FieldOffset(Offset="0x0")]
	private const int HIGH_FRAMERATE = 60;

	[FieldOffset(Offset="0x0")]
	private const int LOW_FRAMERATE = 30;

	[FieldOffset(Offset="0x0")]
	private const int LOADING_FRAMERATE = 30;

	[FieldOffset(Offset="0x0")]
	private const int MAX_RESOLUTION_HEIGHT = 900;

	[FieldOffset(Offset="0x0")]
	private const int IPAD_MAX_RESOLUTION_HEIGHT = 1400;

	[FieldOffset(Offset="0x0")]
	private const float LOW_RESOLUTION_FACTOR = 0.8f;

	[FieldOffset(Offset="0x0")]
	private const int DEFAULT_ASYNC_UPLOAD_TIME_SLICE_MS = 2;

	[FieldOffset(Offset="0x0")]
	private const int HIGH_PRIORITY_ASYNC_UPLOAD_TIME_SLICE_MS = 4;

	[FieldOffset(Offset="0x0")]
	private const string HIGH_SRP_NAME = "high_srp";

	[FieldOffset(Offset="0x0")]
	private const string MEDIUM_SRP_NAME = "medium_srp";

	[FieldOffset(Offset="0x0")]
	private const string LOW_SRP_NAME = "low_srp";

	[FieldOffset(Offset="0x0")]
	private static int s_desiredTargetFrameRate;

	[Attribute(Name="InjectAttribute", RVA="0x1058720", Offset="0x1058720")]
	[FieldOffset(Offset="0x18")]
	private SharedPrefs _sharedPrefs;

	[Attribute(Name="InjectAttribute", RVA="0x1058730", Offset="0x1058730")]
	[FieldOffset(Offset="0x20")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x28")]
	private DeviceGraphicsSetting _maxSetting;

	public DeviceGraphicsSetting Current
	{
		[Address(RVA="0x12DFDC0", Offset="0x12DFDC0", VA="0x12DFDC0")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FC34", Offset="0x106FC34")]
		get
		{
			return new DeviceGraphicsSetting();
		}
		[Address(RVA="0x12DFDC8", Offset="0x12DFDC8", VA="0x12DFDC8")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FC44", Offset="0x106FC44")]
		private set
		{
		}
	}

	[Address(RVA="0x12E0690", Offset="0x12E0690", VA="0x12E0690")]
	static GraphicsSettings()
	{
	}

	[Address(RVA="0x12E0688", Offset="0x12E0688", VA="0x12E0688")]
	public GraphicsSettings()
	{
	}

	[Address(RVA="0x12E00E0", Offset="0x12E00E0", VA="0x12E00E0")]
	public void AutoGraphicsSettings(DeviceGraphicsSetting autoSetting, DeviceGraphicsSetting maxSetting)
	{
	}

	[Address(RVA="0x12DFDD0", Offset="0x12DFDD0", VA="0x12DFDD0")]
	public static void BeginHighPriorityLoading()
	{
	}

	[Address(RVA="0x12DFCE4", Offset="0x12DFCE4", VA="0x12DFCE4")]
	public static DeviceGraphicsSetting ConvertIntToSetting(int intSetting)
	{
		return new DeviceGraphicsSetting();
	}

	[Address(RVA="0x12DFE00", Offset="0x12DFE00", VA="0x12DFE00")]
	public static void EndHighPriorityLoading()
	{
	}

	[Address(RVA="0x12E0614", Offset="0x12E0614", VA="0x12E0614")]
	private int GetLowResolutionHeight()
	{
		return new int();
	}

	[Address(RVA="0x12E0404", Offset="0x12E0404", VA="0x12E0404")]
	private int GetMaxResolutionHeight()
	{
		return new int();
	}

	[Address(RVA="0x12DFE84", Offset="0x12DFE84", VA="0x12DFE84")]
	public void Initialize()
	{
	}

	[Address(RVA="0x12E0194", Offset="0x12E0194", VA="0x12E0194")]
	public bool ManualGraphicsSettings(int settingNum)
	{
		return new bool();
	}

	[Address(RVA="0x12DFF28", Offset="0x12DFF28", VA="0x12DFF28")]
	private void SetAndSaveGraphicsSettings(DeviceGraphicsSetting setting)
	{
	}

	[Address(RVA="0x12E0258", Offset="0x12E0258", VA="0x12E0258")]
	private void SetHigh()
	{
	}

	[Address(RVA="0x12E0374", Offset="0x12E0374", VA="0x12E0374")]
	private void SetLow()
	{
	}

	[Address(RVA="0x12E02E4", Offset="0x12E02E4", VA="0x12E02E4")]
	private void SetMedium()
	{
	}

	[Address(RVA="0x12E040C", Offset="0x12E040C", VA="0x12E040C")]
	private void SetResolution(int verticalRes)
	{
	}

	[Address(RVA="0x12E04CC", Offset="0x12E04CC", VA="0x12E04CC")]
	private void SetSrp(string srpName)
	{
	}
}