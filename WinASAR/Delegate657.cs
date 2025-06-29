using System;

// Token: 0x020004A1 RID: 1185
internal sealed class Delegate657 : MulticastDelegate
{
	// Token: 0x06002218 RID: 8728
	public extern Type[] Invoke(object object_0);

	// Token: 0x06002219 RID: 8729 RVA: 0x0000C2DB File Offset: 0x0000A4DB
	public static Type[] smethod_0(object object_0, Delegate657 delegate657_1)
	{
		return delegate657_1(object_0);
	}

	// Token: 0x0600221A RID: 8730
	public extern Delegate657(object object_0, IntPtr intptr_0);

	// Token: 0x0600221B RID: 8731 RVA: 0x0000C2E6 File Offset: 0x0000A4E6
	static Delegate657()
	{
		Class15.smethod_14(typeof(Delegate657).TypeHandle);
	}

	// Token: 0x04000C71 RID: 3185
	internal static Delegate657 delegate657_0;
}
