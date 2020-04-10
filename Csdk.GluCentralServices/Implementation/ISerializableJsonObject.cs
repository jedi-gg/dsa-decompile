using System;

namespace Csdk.GluCentralServices.Implementation
{
	public interface ISerializableJsonObject
	{
		void WriteObject(JsonStringer json);
	}
}