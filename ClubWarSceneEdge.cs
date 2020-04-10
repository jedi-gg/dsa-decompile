using Il2CppDummyDll;
using System;
using UnityEngine;

public class ClubWarSceneEdge : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	private string _nodeAId;

	[FieldOffset(Offset="0x20")]
	private string _nodeBId;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private LineRenderer _connectedLine;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private LineRenderer _disconnectedLine;

	public bool IsConnected
	{
		[Address(RVA="0x14DAF18", Offset="0x14DAF18", VA="0x14DAF18")]
		get
		{
			return new bool();
		}
	}

	public string NodeAId
	{
		[Address(RVA="0x14DAF08", Offset="0x14DAF08", VA="0x14DAF08")]
		get
		{
			return null;
		}
	}

	public string NodeBId
	{
		[Address(RVA="0x14DAF10", Offset="0x14DAF10", VA="0x14DAF10")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x14DB150", Offset="0x14DB150", VA="0x14DB150")]
	public ClubWarSceneEdge()
	{
	}

	[Address(RVA="0x14DB0B8", Offset="0x14DB0B8", VA="0x14DB0B8")]
	public void SetConnected(bool connected)
	{
	}

	[Address(RVA="0x14DAF60", Offset="0x14DAF60", VA="0x14DAF60")]
	public void SetNodeData(string nodeAId, Vector3 nodeAPos, string nodeBId, Vector3 nodeBPos)
	{
	}
}