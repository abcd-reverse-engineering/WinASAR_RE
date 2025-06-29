using System;

// Token: 0x02000556 RID: 1366
internal sealed class Delegate838 : MulticastDelegate
{
	// Token: 0x060024EC RID: 9452
	public extern void Invoke(object object_0);

	// Token: 0x060024ED RID: 9453 RVA: 0x0000D4A6 File Offset: 0x0000B6A6
	public static void smethod_0(object object_0, Delegate838 delegate838_1)
	{
		delegate838_1(object_0);
	}

	// Token: 0x060024EE RID: 9454
	public extern Delegate838(object object_0, IntPtr intptr_0);

	// Token: 0x060024EF RID: 9455 RVA: 0x0000D4B1 File Offset: 0x0000B6B1
	static Delegate838()
	{
		Class15.smethod_14(typeof(Delegate838).TypeHandle);
	}

	// Token: 0x04000D26 RID: 3366
	internal static Delegate838 delegate838_0;
}
