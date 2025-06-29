using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200010D RID: 269
	public class JsonLinqContract : JsonContract
	{
		// Token: 0x06000A49 RID: 2633 RVA: 0x0005A580 File Offset: 0x00058780
		[NullableContext(1)]
		public JsonLinqContract(Type underlyingType)
			: base(underlyingType)
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 != 0)
			{
				goto IL_0033;
			}
			IL_001B:
			this.ContractType = JsonContractType.Linq;
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
			{
				return;
			}
			IL_0033:
			switch (num)
			{
			case 1:
				goto IL_001B;
			}
		}
	}
}
