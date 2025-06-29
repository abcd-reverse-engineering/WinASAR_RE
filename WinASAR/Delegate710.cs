using System;
using System.Reflection;

// Token: 0x020004D6 RID: 1238
internal sealed class Delegate710 : MulticastDelegate
{
	// Token: 0x060022EC RID: 8940
	public extern MemberInfo Invoke(object object_0);

	// Token: 0x060022ED RID: 8941 RVA: 0x0000C810 File Offset: 0x0000AA10
	public static MemberInfo smethod_0(object object_0, Delegate710 delegate710_1)
	{
		return delegate710_1(object_0);
	}

	// Token: 0x060022EE RID: 8942
	public extern Delegate710(object object_0, IntPtr intptr_0);

	// Token: 0x060022EF RID: 8943 RVA: 0x0000C81B File Offset: 0x0000AA1B
	static Delegate710()
	{
		Class15.smethod_14(typeof(Delegate710).TypeHandle);
	}

	// Token: 0x04000CA6 RID: 3238
	internal static Delegate710 delegate710_0;
}
