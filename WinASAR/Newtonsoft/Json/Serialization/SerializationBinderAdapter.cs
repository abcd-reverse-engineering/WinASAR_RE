using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000126 RID: 294
	[NullableContext(1)]
	[Nullable(0)]
	internal class SerializationBinderAdapter : GInterface2
	{
		// Token: 0x06000BDB RID: 3035 RVA: 0x00069A8C File Offset: 0x00067C8C
		public SerializationBinderAdapter(SerializationBinder serializationBinder)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 != 0)
			{
				goto IL_0032;
			}
			IL_001A:
			this.SerializationBinder = serializationBinder;
			num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 != 0)
			{
				return;
			}
			IL_0032:
			switch (num)
			{
			case 0:
				goto IL_001A;
			case 1:
				break;
			default:
				goto IL_001A;
			}
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x0000525E File Offset: 0x0000345E
		public Type BindToType([Nullable(2)] string assemblyName, string typeName)
		{
			return this.SerializationBinder.BindToType(assemblyName, typeName);
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x00069ADC File Offset: 0x00067CDC
		[NullableContext(2)]
		public void BindToName([Nullable(1)] Type serializedType, out string assemblyName, out string typeName)
		{
			for (;;)
			{
				this.SerializationBinder.BindToName(serializedType, out assemblyName, out typeName);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
					break;
				}
				break;
			}
		}

		// Token: 0x040005CC RID: 1484
		public readonly SerializationBinder SerializationBinder;
	}
}
