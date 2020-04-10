using Il2CppDummyDll;
using System;
using TMPro;

public class UiLabel : TextMeshProUGUI
{
	[FieldOffset(Offset="0x0")]
	private readonly static char[] s_emptyCharArray;

	[FieldOffset(Offset="0x15F1")]
	private bool _usedCharArrayToSetText;

	public new string text
	{
		[Address(RVA="0x158690C", Offset="0x158690C", VA="0x158690C")]
		get
		{
			return null;
		}
		[Address(RVA="0x1586914", Offset="0x1586914", VA="0x1586914")]
		private set
		{
		}
	}

	[Address(RVA="0x1586D78", Offset="0x1586D78", VA="0x1586D78")]
	static UiLabel()
	{
	}

	[Address(RVA="0x1586D70", Offset="0x1586D70", VA="0x1586D70")]
	public UiLabel()
	{
	}

	[Address(RVA="0x1586D48", Offset="0x1586D48", VA="0x1586D48", Slot="4")]
	protected override void Awake()
	{
	}

	[Address(RVA="0x1586AE8", Offset="0x1586AE8", VA="0x1586AE8")]
	public bool IsEmpty()
	{
		return new bool();
	}

	[Address(RVA="0x1586920", Offset="0x1586920", VA="0x1586920")]
	public new void SetText(string text, bool syncTextInputBox = true)
	{
	}

	[Address(RVA="0x1586918", Offset="0x1586918", VA="0x1586918")]
	public void SetTextProperty(string text)
	{
	}

	[Address(RVA="0x1586C30", Offset="0x1586C30", VA="0x1586C30")]
	public void ValidateFont()
	{
	}
}