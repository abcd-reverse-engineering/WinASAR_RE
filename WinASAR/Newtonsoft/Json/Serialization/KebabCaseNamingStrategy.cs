using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200011F RID: 287
	public class KebabCaseNamingStrategy : NamingStrategy
	{
		// Token: 0x06000BA5 RID: 2981 RVA: 0x00068F18 File Offset: 0x00067118
		public KebabCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
			{
				goto IL_0037;
			}
			goto IL_0052;
			IL_001C:
			base.OverrideSpecifiedNames = overrideSpecifiedNames;
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0)
			{
				return;
			}
			goto IL_0052;
			IL_0037:
			base.ProcessDictionaryKeys = processDictionaryKeys;
			num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c == 0)
			{
				goto IL_001C;
			}
			IL_0052:
			switch (num)
			{
			case 1:
				goto IL_0037;
			case 2:
				goto IL_001C;
			}
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x00068F8C File Offset: 0x0006718C
		public KebabCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames)
			: this(processDictionaryKeys, overrideSpecifiedNames)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 != 0)
			{
				goto IL_0037;
			}
			do
			{
				IL_001C:
				base.ProcessExtensionDataNames = processExtensionDataNames;
				num = 1;
			}
			while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 == 0);
			IL_0037:
			switch (num)
			{
			case 0:
				goto IL_001C;
			case 1:
				return;
			default:
				goto IL_001C;
			}
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x00068FE0 File Offset: 0x000671E0
		public KebabCaseNamingStrategy()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x00005202 File Offset: 0x00003402
		[NullableContext(1)]
		protected override string ResolvePropertyName(string name)
		{
			return StringUtils.ToKebabCase(name);
		}
	}
}
