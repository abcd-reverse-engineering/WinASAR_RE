using System;

// Token: 0x02000516 RID: 1302
internal sealed class Delegate774 : MulticastDelegate
{
	// Token: 0x060023EC RID: 9196
	public extern void Invoke(object object_0, object object_1, int int_0);

	// Token: 0x060023ED RID: 9197 RVA: 0x0000CE50 File Offset: 0x0000B050
	public static void smethod_0(object object_0, object object_1, int int_0, Delegate774 delegate774_1)
	{
		delegate774_1(object_0, object_1, int_0);
	}

	// Token: 0x060023EE RID: 9198
	public extern Delegate774(object object_0, IntPtr intptr_0);

	// Token: 0x060023EF RID: 9199 RVA: 0x0000CE5F File Offset: 0x0000B05F
	static Delegate774()
	{
		Class15.smethod_14(typeof(Delegate774).TypeHandle);
	}

	// Token: 0x04000CE6 RID: 3302
	internal static Delegate774 delegate774_0;
}
