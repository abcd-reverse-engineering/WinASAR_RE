using System;
using System.Reflection;

// Token: 0x020004B9 RID: 1209
internal sealed class Delegate681 : MulticastDelegate
{
	// Token: 0x06002278 RID: 8824
	public extern MethodInfo[] Invoke(object object_0, BindingFlags bindingFlags_0);

	// Token: 0x06002279 RID: 8825 RVA: 0x0000C540 File Offset: 0x0000A740
	public static MethodInfo[] smethod_0(object object_0, BindingFlags bindingFlags_0, Delegate681 delegate681_1)
	{
		return delegate681_1(object_0, bindingFlags_0);
	}

	// Token: 0x0600227A RID: 8826
	public extern Delegate681(object object_0, IntPtr intptr_0);

	// Token: 0x0600227B RID: 8827 RVA: 0x0000C54D File Offset: 0x0000A74D
	static Delegate681()
	{
		Class15.smethod_14(typeof(Delegate681).TypeHandle);
	}

	// Token: 0x04000C89 RID: 3209
	internal static Delegate681 delegate681_0;
}
