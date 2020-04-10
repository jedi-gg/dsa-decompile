using Il2CppDummyDll;
using System;

public class ConsoleCommandButtonData
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1057568", Offset="0x1057568")]
	[FieldOffset(Offset="0x10")]
	private string <Text>k__BackingField;

	[FieldOffset(Offset="0x18")]
	private Action<string> _command;

	[FieldOffset(Offset="0x20")]
	private string _parameters;

	public string Text
	{
		[Address(RVA="0x1544C8C", Offset="0x1544C8C", VA="0x1544C8C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F324", Offset="0x106F324")]
		get
		{
			return null;
		}
		[Address(RVA="0x1544C94", Offset="0x1544C94", VA="0x1544C94")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F334", Offset="0x106F334")]
		private set
		{
		}
	}

	[Address(RVA="0x1544C9C", Offset="0x1544C9C", VA="0x1544C9C")]
	public ConsoleCommandButtonData(string text, string parameters = "")
	{
	}

	[Address(RVA="0x1544CE0", Offset="0x1544CE0", VA="0x1544CE0")]
	public void Execute()
	{
	}

	[Address(RVA="0x1544CD8", Offset="0x1544CD8", VA="0x1544CD8")]
	public void RegisterCommand(Action<string> command)
	{
	}
}