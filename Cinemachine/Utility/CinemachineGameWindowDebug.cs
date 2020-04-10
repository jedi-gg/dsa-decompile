using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cinemachine.Utility
{
	public class CinemachineGameWindowDebug
	{
		[FieldOffset(Offset="0x0")]
		private static HashSet<UnityEngine.Object> mClients;

		[Address(RVA="0x146146C", Offset="0x146146C", VA="0x146146C")]
		public CinemachineGameWindowDebug()
		{
		}

		[Address(RVA="0x14611C8", Offset="0x14611C8", VA="0x14611C8")]
		public static Rect GetScreenPos(UnityEngine.Object client, string text, GUIStyle style)
		{
			return new Rect();
		}

		[Address(RVA="0x1461120", Offset="0x1461120", VA="0x1461120")]
		public static void ReleaseScreenPos(UnityEngine.Object client)
		{
		}
	}
}