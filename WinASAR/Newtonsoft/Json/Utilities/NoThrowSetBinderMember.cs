using System;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000A9 RID: 169
	[NullableContext(1)]
	[Nullable(0)]
	internal class NoThrowSetBinderMember : SetMemberBinder
	{
		// Token: 0x060006FA RID: 1786 RVA: 0x00049748 File Offset: 0x00047948
		public NoThrowSetBinderMember(SetMemberBinder innerBinder)
			: base(innerBinder.Name, innerBinder.IgnoreCase)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 == 0)
			{
				goto IL_0041;
			}
			do
			{
				IL_0026:
				this.setMemberBinder_0 = innerBinder;
				num = 1;
			}
			while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 == 0);
			IL_0041:
			switch (num)
			{
			case 0:
				goto IL_0026;
			case 1:
				return;
			default:
				goto IL_0026;
			}
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x000497A8 File Offset: 0x000479A8
		public override DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value, [Nullable(2)] DynamicMetaObject errorSuggestion)
		{
			DynamicMetaObject dynamicMetaObject;
			for (;;)
			{
				dynamicMetaObject = this.setMemberBinder_0.Bind(target, new DynamicMetaObject[] { value });
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 != 0)
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

		// Token: 0x04000413 RID: 1043
		private readonly SetMemberBinder setMemberBinder_0;
	}
}
