using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001B7 RID: 439
	[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
	public class BsonObjectId
	{
		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x0600134E RID: 4942 RVA: 0x00006FC5 File Offset: 0x000051C5
		public byte[] Value { get; }

		// Token: 0x0600134F RID: 4943 RVA: 0x00097E64 File Offset: 0x00096064
		public BsonObjectId(byte[] value)
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
			{
				goto IL_0049;
			}
			for (;;)
			{
				IL_007C:
				switch (num)
				{
				case 1:
					ValidationUtils.ArgumentNotNull(value, Class15.smethod_17(432117059 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2));
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa != 0)
					{
						continue;
					}
					break;
				case 2:
					goto IL_0098;
				case 3:
					return;
				}
				break;
			}
			IL_0049:
			if (value.Length != 12)
			{
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 != 0)
				{
					goto IL_007C;
				}
			}
			else
			{
				this.Value = value;
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 != 0)
				{
					goto IL_007C;
				}
			}
			IL_0098:
			throw new ArgumentException(Class15.smethod_17(432097263 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2), Class15.smethod_17(1424583878 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf));
		}

		// Token: 0x04000844 RID: 2116
		[CompilerGenerated]
		private readonly byte[] byte_0;
	}
}
