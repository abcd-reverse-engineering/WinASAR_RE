using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000E3 RID: 227
	public class CamelCaseNamingStrategy : NamingStrategy
	{
		// Token: 0x060008D9 RID: 2265 RVA: 0x00052A3C File Offset: 0x00050C3C
		public CamelCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames)
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 == 0)
			{
				goto IL_001A;
			}
			goto IL_004E;
			for (;;)
			{
				IL_0033:
				base.OverrideSpecifiedNames = overrideSpecifiedNames;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f != 0)
				{
					goto IL_004E;
				}
			}
			IL_001A:
			base.ProcessDictionaryKeys = processDictionaryKeys;
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff == 0)
			{
				goto IL_0033;
			}
			IL_004E:
			switch (num)
			{
			case 0:
				goto IL_0033;
			case 1:
				return;
			case 2:
				goto IL_001A;
			default:
				goto IL_0033;
			}
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x00052AAC File Offset: 0x00050CAC
		public CamelCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames)
			: this(processDictionaryKeys, overrideSpecifiedNames)
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c != 0)
			{
				goto IL_0034;
			}
			IL_001C:
			base.ProcessExtensionDataNames = processExtensionDataNames;
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 != 0)
			{
				return;
			}
			IL_0034:
			switch (num)
			{
			case 1:
				goto IL_001C;
			}
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x00052B00 File Offset: 0x00050D00
		public CamelCaseNamingStrategy()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00004829 File Offset: 0x00002A29
		[NullableContext(1)]
		protected override string ResolvePropertyName(string name)
		{
			return StringUtils.ToCamelCase(name);
		}
	}
}
