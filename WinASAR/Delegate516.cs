using System;

// Token: 0x02000414 RID: 1044
internal sealed class Delegate516 : MulticastDelegate
{
	// Token: 0x06001FE4 RID: 8164
	public extern bool Invoke(object object_0);

	// Token: 0x06001FE5 RID: 8165 RVA: 0x0000B4B1 File Offset: 0x000096B1
	public static bool smethod_0(object object_0, Delegate516 delegate516_1)
	{
		return delegate516_1(object_0);
	}

	// Token: 0x06001FE6 RID: 8166
	public extern Delegate516(object object_0, IntPtr intptr_0);

	// Token: 0x06001FE7 RID: 8167 RVA: 0x0000B4BC File Offset: 0x000096BC
	static Delegate516()
	{
		Class15.smethod_14(typeof(Delegate516).TypeHandle);
	}

	// Token: 0x04000BE4 RID: 3044
	internal static Delegate516 delegate516_0;
}
