using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.CodeAnalysis
{
	// Token: 0x02000042 RID: 66
	[AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
	internal class DoesNotReturnIfAttribute : Attribute
	{
		// Token: 0x06000205 RID: 517 RVA: 0x000264BC File Offset: 0x000246BC
		public DoesNotReturnIfAttribute(bool parameterValue)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f == 0)
			{
				goto IL_0032;
			}
			IL_001A:
			this.ParameterValue = parameterValue;
			num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
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

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000206 RID: 518 RVA: 0x000028F3 File Offset: 0x00000AF3
		public bool ParameterValue { get; }

		// Token: 0x040001A6 RID: 422
		[CompilerGenerated]
		private readonly bool bool_0;
	}
}
