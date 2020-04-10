using System;
using UnityEngine;

namespace Fenderrio.ImageWarp
{
	public interface IWarp
	{
		bool bezierEdges
		{
			get;
			set;
		}

		Vector3 bottomBezierHandleA
		{
			get;
			set;
		}

		Vector3 bottomBezierHandleB
		{
			get;
			set;
		}

		Vector3 cornerOffsetBL
		{
			get;
			set;
		}

		Vector3 cornerOffsetBR
		{
			get;
			set;
		}

		Vector3 cornerOffsetTL
		{
			get;
			set;
		}

		Vector3 cornerOffsetTR
		{
			get;
			set;
		}

		float cropBottom
		{
			get;
			set;
		}

		float cropLeft
		{
			get;
			set;
		}

		float cropRight
		{
			get;
			set;
		}

		float cropTop
		{
			get;
			set;
		}

		Vector3 leftBezierHandleA
		{
			get;
			set;
		}

		Vector3 leftBezierHandleB
		{
			get;
			set;
		}

		int numSubdivisions
		{
			get;
			set;
		}

		Vector3 rightBezierHandleA
		{
			get;
			set;
		}

		Vector3 rightBezierHandleB
		{
			get;
			set;
		}

		Vector3 topBezierHandleA
		{
			get;
			set;
		}

		Vector3 topBezierHandleB
		{
			get;
			set;
		}

		void ResetAll();

		void ResetBezierHandlesToDefault();

		void ResetCornerOffsets();

		void ResetCropping();
	}
}