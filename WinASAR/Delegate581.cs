using System;

// Token: 0x02000455 RID: 1109
internal sealed class Delegate581 : MulticastDelegate
{
	// Token: 0x060020E8 RID: 8424
	public extern bool Invoke(object object_0);

	// Token: 0x060020E9 RID: 8425 RVA: 0x0000BB45 File Offset: 0x00009D45
	public static bool smethod_0(object object_0, Delegate581 delegate581_1)
	{
		return delegate581_1(object_0);
	}

	// Token: 0x060020EA RID: 8426
	public extern Delegate581(object object_0, IntPtr intptr_0);

	// Token: 0x060020EB RID: 8427 RVA: 0x0000BB50 File Offset: 0x00009D50
	static Delegate581()
	{
		Class15.smethod_14(typeof(Delegate581).TypeHandle);
	}

	// Token: 0x04000C25 RID: 3109
	internal static Delegate581 delegate581_0;
}
