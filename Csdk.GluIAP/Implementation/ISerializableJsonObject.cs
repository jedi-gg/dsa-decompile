using System;

namespace Csdk.GluIAP.Implementation
{
	public interface ISerializableJsonObject
	{
		void WriteObject(JsonStringer json);
	}
}