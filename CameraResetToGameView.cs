using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CameraResetToGameView : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private Vector3 defaultCamPos;

	[FieldOffset(Offset="0x24")]
	[SerializeField]
	private Vector3 defaultCamRot;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private Vector3 moveCamPos;

	[FieldOffset(Offset="0x3C")]
	[SerializeField]
	private Vector3 moveCamRot;

	[FieldOffset(Offset="0x48")]
	private Vector3 newCamPos;

	[FieldOffset(Offset="0x54")]
	private Vector3 newCamRot;

	[FieldOffset(Offset="0x60")]
	private Camera cam;

	[FieldOffset(Offset="0x68")]
	private string tip;

	[FieldOffset(Offset="0x70")]
	private bool showTip;

	[FieldOffset(Offset="0x78")]
	private GUIStyle style;

	[FieldOffset(Offset="0x80")]
	private bool moveBool;

	[Address(RVA="0x11249D0", Offset="0x11249D0", VA="0x11249D0")]
	public CameraResetToGameView()
	{
	}

	[Address(RVA="0x1124490", Offset="0x1124490", VA="0x1124490")]
	private void Awake()
	{
	}

	[Address(RVA="0x1124854", Offset="0x1124854", VA="0x1124854")]
	private void MoveWorld()
	{
	}

	[Address(RVA="0x11248B8", Offset="0x11248B8", VA="0x11248B8")]
	private void OnGUI()
	{
	}

	[Address(RVA="0x11246A4", Offset="0x11246A4", VA="0x11246A4")]
	private void ResetCamera()
	{
	}

	[Address(RVA="0x1124630", Offset="0x1124630", VA="0x1124630")]
	[Attribute(Name="IteratorStateMachineAttribute", RVA="0x106DEE4", Offset="0x106DEE4")]
	private IEnumerator ShowTip()
	{
		return null;
	}

	[Address(RVA="0x11247CC", Offset="0x11247CC", VA="0x11247CC")]
	private void Update()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104AD3C", Offset="0x104AD3C")]
	private sealed class <ShowTip>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset="0x10")]
		private int <>1__state;

		[FieldOffset(Offset="0x18")]
		private object <>2__current;

		[FieldOffset(Offset="0x20")]
		public CameraResetToGameView <>4__this;

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA="0x1124C00", Offset="0x1124C00", VA="0x1124C00", Slot="4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System.Collections.IEnumerator.Current
		{
			[Address(RVA="0x1124C70", Offset="0x1124C70", VA="0x1124C70", Slot="7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x11249A4", Offset="0x11249A4", VA="0x11249A4")]
		[DebuggerHidden]
		public <ShowTip>d__16(int u003cu003e1__state)
		{
		}

		[Address(RVA="0x1124B34", Offset="0x1124B34", VA="0x1124B34", Slot="6")]
		private bool MoveNext()
		{
			return new bool();
		}

		[Address(RVA="0x1124C08", Offset="0x1124C08", VA="0x1124C08", Slot="8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}

		[Address(RVA="0x1124B30", Offset="0x1124B30", VA="0x1124B30", Slot="5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}
	}
}