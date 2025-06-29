using System;
using System.Reflection;

// Token: 0x02000488 RID: 1160
internal sealed class Delegate632 : MulticastDelegate
{
	// Token: 0x060021B4 RID: 8628
	public extern MethodInfo Invoke(object object_0, string string_0, BindingFlags bindingFlags_0);

	// Token: 0x060021B5 RID: 8629 RVA: 0x0000C061 File Offset: 0x0000A261
	public static MethodInfo smethod_0(object object_0, string string_0, BindingFlags bindingFlags_0, Delegate632 delegate632_1)
	{
		return delegate632_1(object_0, string_0, bindingFlags_0);
	}

	// Token: 0x060021B6 RID: 8630
	public extern Delegate632(object object_0, IntPtr intptr_0);

	// Token: 0x060021B7 RID: 8631 RVA: 0x0000C070 File Offset: 0x0000A270
	static Delegate632()
	{
		Class15.smethod_14(typeof(Delegate632).TypeHandle);
	}

	// Token: 0x04000C58 RID: 3160
	internal static Delegate632 delegate632_0;
}
