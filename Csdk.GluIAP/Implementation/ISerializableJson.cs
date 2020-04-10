using System;

namespace Csdk.GluIAP.Implementation
{
	public interface ISerializableJson
	{
		void Write(JsonStringer json, string key);
	}
}