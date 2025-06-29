using System;
using System.Reflection;

// Token: 0x020003B4 RID: 948
internal sealed class Delegate420 : MulticastDelegate
{
	// Token: 0x06001E64 RID: 7780
	public extern ParameterInfo[] Invoke(object object_0);

	// Token: 0x06001E65 RID: 7781 RVA: 0x0000AB0F File Offset: 0x00008D0F
	public static ParameterInfo[] smethod_0(object object_0, Delegate420 delegate420_1)
	{
		return delegate420_1(object_0);
	}

	// Token: 0x06001E66 RID: 7782
	public extern Delegate420(object object_0, IntPtr intptr_0);

	// Token: 0x06001E67 RID: 7783 RVA: 0x0000AB1A File Offset: 0x00008D1A
	static Delegate420()
	{
		Class15.smethod_14(typeof(Delegate420).TypeHandle);
	}

	// Token: 0x04000B84 RID: 2948
	internal static Delegate420 delegate420_0;
}
