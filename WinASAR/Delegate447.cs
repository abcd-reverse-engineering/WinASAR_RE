using System;
using System.Reflection;

// Token: 0x020003CF RID: 975
internal sealed class Delegate447 : MulticastDelegate
{
	// Token: 0x06001ED0 RID: 7888
	public extern MethodInfo Invoke(object object_0, string string_0, Type[] type_0);

	// Token: 0x06001ED1 RID: 7889 RVA: 0x0000ADC3 File Offset: 0x00008FC3
	public static MethodInfo smethod_0(object object_0, string string_0, Type[] type_0, Delegate447 delegate447_1)
	{
		return delegate447_1(object_0, string_0, type_0);
	}

	// Token: 0x06001ED2 RID: 7890
	public extern Delegate447(object object_0, IntPtr intptr_0);

	// Token: 0x06001ED3 RID: 7891 RVA: 0x0000ADD2 File Offset: 0x00008FD2
	static Delegate447()
	{
		Class15.smethod_14(typeof(Delegate447).TypeHandle);
	}

	// Token: 0x04000B9F RID: 2975
	internal static Delegate447 delegate447_0;
}
