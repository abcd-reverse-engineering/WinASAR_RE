using System;

// Token: 0x020003E8 RID: 1000
internal sealed class Delegate472 : MulticastDelegate
{
	// Token: 0x06001F34 RID: 7988
	public extern int Invoke(int int_0, int int_1);

	// Token: 0x06001F35 RID: 7989 RVA: 0x0000B04F File Offset: 0x0000924F
	public static int smethod_0(int int_0, int int_1, Delegate472 delegate472_1)
	{
		return delegate472_1(int_0, int_1);
	}

	// Token: 0x06001F36 RID: 7990
	public extern Delegate472(object object_0, IntPtr intptr_0);

	// Token: 0x06001F37 RID: 7991 RVA: 0x0000B05C File Offset: 0x0000925C
	static Delegate472()
	{
		Class15.smethod_14(typeof(Delegate472).TypeHandle);
	}

	// Token: 0x04000BB8 RID: 3000
	internal static Delegate472 delegate472_0;
}
