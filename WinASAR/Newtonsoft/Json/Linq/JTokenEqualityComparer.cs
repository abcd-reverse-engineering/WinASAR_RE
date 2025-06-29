using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x02000169 RID: 361
	public class JTokenEqualityComparer : IEqualityComparer<JToken>
	{
		// Token: 0x06001031 RID: 4145 RVA: 0x00006658 File Offset: 0x00004858
		[NullableContext(2)]
		public bool Equals(JToken x, JToken y)
		{
			return JToken.DeepEquals(x, y);
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x00080650 File Offset: 0x0007E850
		[NullableContext(1)]
		public int GetHashCode(JToken obj)
		{
			while (obj == null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e == 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
				}
				return 0;
			}
			return obj.GetDeepHashCode();
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x00080690 File Offset: 0x0007E890
		public JTokenEqualityComparer()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 != 0)
			{
				switch (num)
				{
				}
			}
		}
	}
}
