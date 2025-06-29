using System;
using System.Reflection;

// Token: 0x020004E5 RID: 1253
internal sealed class Delegate725 : MulticastDelegate
{
	// Token: 0x06002328 RID: 9000
	public extern bool Invoke(Assembly assembly_0, Assembly assembly_1);

	// Token: 0x06002329 RID: 9001 RVA: 0x0000C982 File Offset: 0x0000AB82
	public static bool smethod_0(Assembly assembly_0, Assembly assembly_1, Delegate725 delegate725_1)
	{
		return delegate725_1(assembly_0, assembly_1);
	}

	// Token: 0x0600232A RID: 9002
	public extern Delegate725(object object_0, IntPtr intptr_0);

	// Token: 0x0600232B RID: 9003 RVA: 0x0000C98F File Offset: 0x0000AB8F
	static Delegate725()
	{
		Class15.smethod_14(typeof(Delegate725).TypeHandle);
	}

	// Token: 0x04000CB5 RID: 3253
	internal static Delegate725 delegate725_0;
}
