using System;
using System.Reflection;

// Token: 0x0200046A RID: 1130
internal sealed class Delegate602 : MulticastDelegate
{
	// Token: 0x0600213C RID: 8508
	public extern FieldInfo Invoke(object object_0, string string_0, BindingFlags bindingFlags_0);

	// Token: 0x0600213D RID: 8509 RVA: 0x0000BD53 File Offset: 0x00009F53
	public static FieldInfo smethod_0(object object_0, string string_0, BindingFlags bindingFlags_0, Delegate602 delegate602_1)
	{
		return delegate602_1(object_0, string_0, bindingFlags_0);
	}

	// Token: 0x0600213E RID: 8510
	public extern Delegate602(object object_0, IntPtr intptr_0);

	// Token: 0x0600213F RID: 8511 RVA: 0x0000BD62 File Offset: 0x00009F62
	static Delegate602()
	{
		Class15.smethod_14(typeof(Delegate602).TypeHandle);
	}

	// Token: 0x04000C3A RID: 3130
	internal static Delegate602 delegate602_0;
}
