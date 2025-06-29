using System;
using System.Reflection;

// Token: 0x020004A3 RID: 1187
internal sealed class Delegate659 : MulticastDelegate
{
	// Token: 0x06002220 RID: 8736
	public extern ParameterInfo[] Invoke(object object_0);

	// Token: 0x06002221 RID: 8737 RVA: 0x0000C30B File Offset: 0x0000A50B
	public static ParameterInfo[] smethod_0(object object_0, Delegate659 delegate659_1)
	{
		return delegate659_1(object_0);
	}

	// Token: 0x06002222 RID: 8738
	public extern Delegate659(object object_0, IntPtr intptr_0);

	// Token: 0x06002223 RID: 8739 RVA: 0x0000C316 File Offset: 0x0000A516
	static Delegate659()
	{
		Class15.smethod_14(typeof(Delegate659).TypeHandle);
	}

	// Token: 0x04000C73 RID: 3187
	internal static Delegate659 delegate659_0;
}
