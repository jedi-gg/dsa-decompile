using Il2CppDummyDll;
using System;

public class UniWebViewLogger
{
	[FieldOffset(Offset="0x0")]
	private static UniWebViewLogger instance;

	[FieldOffset(Offset="0x10")]
	private UniWebViewLogger.Level level;

	public static UniWebViewLogger Instance
	{
		[Address(RVA="0x159092C", Offset="0x159092C", VA="0x159092C")]
		get
		{
			return null;
		}
	}

	public UniWebViewLogger.Level LogLevel
	{
		[Address(RVA="0x159E3D4", Offset="0x159E3D4", VA="0x159E3D4")]
		get
		{
			return new UniWebViewLogger.Level();
		}
		[Address(RVA="0x159E3DC", Offset="0x159E3DC", VA="0x159E3DC")]
		set
		{
		}
	}

	[Address(RVA="0x159E580", Offset="0x159E580", VA="0x159E580")]
	private UniWebViewLogger(UniWebViewLogger.Level level)
	{
	}

	[Address(RVA="0x15909C4", Offset="0x15909C4", VA="0x15909C4")]
	public void Critical(string message)
	{
	}

	[Address(RVA="0x159E5BC", Offset="0x159E5BC", VA="0x159E5BC")]
	public void Debug(string message)
	{
	}

	[Address(RVA="0x15909B4", Offset="0x15909B4", VA="0x15909B4")]
	public void Info(string message)
	{
	}

	[Address(RVA="0x159E498", Offset="0x159E498", VA="0x159E498")]
	private void Log(UniWebViewLogger.Level level, string message)
	{
	}

	[Address(RVA="0x159E5AC", Offset="0x159E5AC", VA="0x159E5AC")]
	public void Verbose(string message)
	{
	}

	public enum Level
	{
		[FieldOffset(Offset="0x0")]
		Verbose = 0,
		[FieldOffset(Offset="0x0")]
		Debug = 10,
		[FieldOffset(Offset="0x0")]
		Info = 20,
		[FieldOffset(Offset="0x0")]
		Critical = 80,
		[FieldOffset(Offset="0x0")]
		Off = 99
	}
}