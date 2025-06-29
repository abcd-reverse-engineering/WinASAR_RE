using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000127 RID: 295
	public class SnakeCaseNamingStrategy : NamingStrategy
	{
		// Token: 0x06000BE1 RID: 3041 RVA: 0x00069B1C File Offset: 0x00067D1C
		public SnakeCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames)
		{
			for (;;)
			{
				IL_0036:
				base.ProcessDictionaryKeys = processDictionaryKeys;
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a != 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						base.OverrideSpecifiedNames = overrideSpecifiedNames;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede != 0)
						{
							continue;
						}
						break;
					case 2:
						goto IL_0036;
					}
					return;
				}
			}
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x00069B7C File Offset: 0x00067D7C
		public SnakeCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames)
			: this(processDictionaryKeys, overrideSpecifiedNames)
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6 != 0)
			{
				for (;;)
				{
					switch (num)
					{
					case 1:
						base.ProcessExtensionDataNames = processExtensionDataNames;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f != 0)
						{
							continue;
						}
						break;
					}
					break;
				}
			}
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x00069BD0 File Offset: 0x00067DD0
		public SnakeCaseNamingStrategy()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x0000526D File Offset: 0x0000346D
		[NullableContext(1)]
		protected override string ResolvePropertyName(string name)
		{
			return StringUtils.ToSnakeCase(name);
		}
	}
}
