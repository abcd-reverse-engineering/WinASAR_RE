using System;
using System.Reflection;

// Token: 0x0200042C RID: 1068
internal sealed class Delegate540 : MulticastDelegate
{
	// Token: 0x06002044 RID: 8260
	public extern MethodInfo Invoke(object object_0, string string_0);

	// Token: 0x06002045 RID: 8261 RVA: 0x0000B725 File Offset: 0x00009925
	public static MethodInfo smethod_0(object object_0, string string_0, Delegate540 delegate540_1)
	{
		return delegate540_1(object_0, string_0);
	}

	// Token: 0x06002046 RID: 8262
	public extern Delegate540(object object_0, IntPtr intptr_0);

	// Token: 0x06002047 RID: 8263 RVA: 0x0000B732 File Offset: 0x00009932
	static Delegate540()
	{
		Class15.smethod_14(typeof(Delegate540).TypeHandle);
	}

	// Token: 0x04000BFC RID: 3068
	internal static Delegate540 delegate540_0;
}
