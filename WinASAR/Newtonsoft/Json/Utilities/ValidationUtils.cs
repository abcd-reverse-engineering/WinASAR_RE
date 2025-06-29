using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000E1 RID: 225
	internal static class ValidationUtils
	{
		// Token: 0x060008D1 RID: 2257 RVA: 0x0005298C File Offset: 0x00050B8C
		[NullableContext(1)]
		public static void ArgumentNotNull([Nullable(2)] [NotNull] object value, string parameterName)
		{
			while (value != null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					case 2:
						goto IL_0031;
					}
				}
				return;
			}
			IL_0031:
			throw new ArgumentNullException(parameterName);
		}
	}
}
