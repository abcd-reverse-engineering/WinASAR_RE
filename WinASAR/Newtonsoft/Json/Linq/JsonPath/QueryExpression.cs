using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x02000180 RID: 384
	[Nullable(0)]
	[NullableContext(1)]
	internal abstract class QueryExpression
	{
		// Token: 0x0600113F RID: 4415 RVA: 0x00089DD8 File Offset: 0x00087FD8
		public QueryExpression(QueryOperator @operator)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad != 0)
			{
				goto IL_0032;
			}
			IL_001A:
			this.Operator = @operator;
			num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
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

		// Token: 0x06001140 RID: 4416 RVA: 0x000068F7 File Offset: 0x00004AF7
		public bool IsMatch(JToken root, JToken t)
		{
			return this.IsMatch(root, t, null);
		}

		// Token: 0x06001141 RID: 4417
		public abstract bool IsMatch(JToken root, JToken t, [Nullable(2)] JsonSelectSettings settings);

		// Token: 0x040007AD RID: 1965
		internal QueryOperator Operator;
	}
}
