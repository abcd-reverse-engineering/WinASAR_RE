using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x02000188 RID: 392
	[NullableContext(2)]
	[Nullable(0)]
	internal class ScanFilter : PathFilter
	{
		// Token: 0x0600117F RID: 4479 RVA: 0x0008B7C4 File Offset: 0x000899C4
		public ScanFilter(string name)
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c != 0)
			{
				goto IL_0032;
			}
			IL_001A:
			this.Name = name;
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 == 0)
			{
				return;
			}
			IL_0032:
			switch (num)
			{
			case 1:
				goto IL_001A;
			}
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x00006989 File Offset: 0x00004B89
		[NullableContext(1)]
		public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, [Nullable(2)] JsonSelectSettings settings)
		{
			ScanFilter.<ExecuteFilter>d__2 <ExecuteFilter>d__ = new ScanFilter.<ExecuteFilter>d__2(-2);
			<ExecuteFilter>d__.<>4__this = this;
			<ExecuteFilter>d__.<>3__current = current;
			return <ExecuteFilter>d__;
		}

		// Token: 0x040007D4 RID: 2004
		internal string Name;
	}
}
