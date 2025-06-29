using System;
using System.Reflection;

// Token: 0x0200048E RID: 1166
internal sealed class Delegate638 : MulticastDelegate
{
	// Token: 0x060021CC RID: 8652
	public extern MethodInfo[] Invoke(object object_0);

	// Token: 0x060021CD RID: 8653 RVA: 0x0000C0F9 File Offset: 0x0000A2F9
	public static MethodInfo[] smethod_0(object object_0, Delegate638 delegate638_1)
	{
		return delegate638_1(object_0);
	}

	// Token: 0x060021CE RID: 8654
	public extern Delegate638(object object_0, IntPtr intptr_0);

	// Token: 0x060021CF RID: 8655 RVA: 0x0000C104 File Offset: 0x0000A304
	static Delegate638()
	{
		Class15.smethod_14(typeof(Delegate638).TypeHandle);
	}

	// Token: 0x04000C5E RID: 3166
	internal static Delegate638 delegate638_0;
}
