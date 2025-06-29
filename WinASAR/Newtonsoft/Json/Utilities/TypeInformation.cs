using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000087 RID: 135
	[NullableContext(1)]
	[Nullable(0)]
	internal class TypeInformation
	{
		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060005D6 RID: 1494 RVA: 0x00003900 File Offset: 0x00001B00
		public Type Type { get; }

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060005D7 RID: 1495 RVA: 0x00003908 File Offset: 0x00001B08
		public PrimitiveTypeCode TypeCode { get; }

		// Token: 0x060005D8 RID: 1496 RVA: 0x00040500 File Offset: 0x0003E700
		public TypeInformation(Type type, PrimitiveTypeCode typeCode)
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 != 0)
			{
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.Type = type;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 != 0)
						{
							continue;
						}
						break;
					case 2:
						return;
					}
					break;
				}
			}
			this.TypeCode = typeCode;
		}

		// Token: 0x04000393 RID: 915
		[CompilerGenerated]
		private readonly Type type_0;

		// Token: 0x04000394 RID: 916
		[CompilerGenerated]
		private readonly PrimitiveTypeCode primitiveTypeCode_0;
	}
}
