using System;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000A8 RID: 168
	[Nullable(0)]
	[NullableContext(1)]
	internal class NoThrowGetBinderMember : GetMemberBinder
	{
		// Token: 0x060006F5 RID: 1781 RVA: 0x0004968C File Offset: 0x0004788C
		public NoThrowGetBinderMember(GetMemberBinder innerBinder)
			: base(innerBinder.Name, innerBinder.IgnoreCase)
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 != 0)
			{
				goto IL_003E;
			}
			IL_0026:
			this.getMemberBinder_0 = innerBinder;
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
			{
				return;
			}
			IL_003E:
			switch (num)
			{
			case 1:
				goto IL_0026;
			}
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x000496E8 File Offset: 0x000478E8
		public override DynamicMetaObject FallbackGetMember(DynamicMetaObject target, [Nullable(2)] DynamicMetaObject errorSuggestion)
		{
			DynamicMetaObject dynamicMetaObject;
			for (;;)
			{
				dynamicMetaObject = this.getMemberBinder_0.Bind(target, CollectionUtils.ArrayEmpty<DynamicMetaObject>());
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb == 0)
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
			return new DynamicMetaObject(new NoThrowExpressionVisitor().Visit(dynamicMetaObject.Expression), dynamicMetaObject.Restrictions);
		}

		// Token: 0x04000411 RID: 1041
		private readonly GetMemberBinder getMemberBinder_0;
	}
}
