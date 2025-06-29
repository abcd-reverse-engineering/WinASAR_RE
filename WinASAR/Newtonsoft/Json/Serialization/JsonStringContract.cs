using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200011B RID: 283
	public class JsonStringContract : JsonPrimitiveContract
	{
		// Token: 0x06000B80 RID: 2944 RVA: 0x0006807C File Offset: 0x0006627C
		[NullableContext(1)]
		public JsonStringContract(Type underlyingType)
			: base(underlyingType)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 != 0)
			{
				goto IL_0036;
			}
			do
			{
				IL_001B:
				this.ContractType = JsonContractType.String;
				num = 1;
			}
			while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 != 0);
			IL_0036:
			switch (num)
			{
			case 0:
				goto IL_001B;
			case 1:
				return;
			default:
				goto IL_001B;
			}
		}
	}
}
