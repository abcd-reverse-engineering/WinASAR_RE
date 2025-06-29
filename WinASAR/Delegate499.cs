using System;

// Token: 0x02000403 RID: 1027
internal sealed class Delegate499 : MulticastDelegate
{
	// Token: 0x06001FA0 RID: 8096
	public extern int Invoke(int int_0);

	// Token: 0x06001FA1 RID: 8097 RVA: 0x0000B309 File Offset: 0x00009509
	public static int smethod_0(int int_0, Delegate499 delegate499_1)
	{
		return delegate499_1(int_0);
	}

	// Token: 0x06001FA2 RID: 8098
	public extern Delegate499(object object_0, IntPtr intptr_0);

	// Token: 0x06001FA3 RID: 8099 RVA: 0x0000B314 File Offset: 0x00009514
	static Delegate499()
	{
		Class15.smethod_14(typeof(Delegate499).TypeHandle);
	}

	// Token: 0x04000BD3 RID: 3027
	internal static Delegate499 delegate499_0;
}
