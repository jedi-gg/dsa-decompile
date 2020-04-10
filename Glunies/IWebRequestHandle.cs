using System;
using UnityEngine.Networking;

namespace Glunies
{
	public interface IWebRequestHandle
	{
		UnityWebRequest CurrentRequest
		{
			get;
		}

		bool Silent
		{
			get;
			set;
		}
	}
}