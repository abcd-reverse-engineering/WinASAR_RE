using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000124 RID: 292
	[NullableContext(1)]
	[Nullable(0)]
	public class ReflectionAttributeProvider : GInterface0
	{
		// Token: 0x06000BCF RID: 3023 RVA: 0x000697F0 File Offset: 0x000679F0
		public ReflectionAttributeProvider(object attributeProvider)
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 != 0)
			{
				goto IL_0046;
			}
			IL_001A:
			ValidationUtils.ArgumentNotNull(attributeProvider, Class15.smethod_17(1985288832 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba));
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 == 0)
			{
				goto IL_005B;
			}
			IL_0046:
			switch (num)
			{
			case 1:
				goto IL_001A;
			case 2:
				return;
			}
			IL_005B:
			this.icustomAttributeProvider_0 = attributeProvider;
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x00005240 File Offset: 0x00003440
		public IList<Attribute> GetAttributes(bool inherit)
		{
			return ReflectionUtils.GetAttributes(this.icustomAttributeProvider_0, null, inherit);
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x0000524F File Offset: 0x0000344F
		public IList<Attribute> GetAttributes(Type attributeType, bool inherit)
		{
			return ReflectionUtils.GetAttributes(this.icustomAttributeProvider_0, attributeType, inherit);
		}

		// Token: 0x040005C8 RID: 1480
		private readonly ICustomAttributeProvider icustomAttributeProvider_0;
	}
}
