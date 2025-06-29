using System;

// Token: 0x02000241 RID: 577
internal sealed class Delegate49 : MulticastDelegate
{
	// Token: 0x06001898 RID: 6296
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x06001899 RID: 6297 RVA: 0x0000861B File Offset: 0x0000681B
	public static void smethod_0(object object_0, string string_0, Delegate49 delegate49_1)
	{
		delegate49_1(object_0, string_0);
	}

	// Token: 0x0600189A RID: 6298
	public extern Delegate49(object object_0, IntPtr intptr_0);

	// Token: 0x0600189B RID: 6299 RVA: 0x00008628 File Offset: 0x00006828
	static Delegate49()
	{
		Class15.smethod_14(typeof(Delegate49).TypeHandle);
	}

	// Token: 0x04000A11 RID: 2577
	internal static Delegate49 delegate49_0;
}
