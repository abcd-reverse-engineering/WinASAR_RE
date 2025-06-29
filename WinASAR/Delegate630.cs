using System;

// Token: 0x02000486 RID: 1158
internal sealed class Delegate630 : MulticastDelegate
{
	// Token: 0x060021AC RID: 8620
	public extern void Invoke(object object_0, ref bool bool_0);

	// Token: 0x060021AD RID: 8621 RVA: 0x0000C02F File Offset: 0x0000A22F
	public static void smethod_0(object object_0, ref bool bool_0, Delegate630 delegate630_1)
	{
		delegate630_1(object_0, ref bool_0);
	}

	// Token: 0x060021AE RID: 8622
	public extern Delegate630(object object_0, IntPtr intptr_0);

	// Token: 0x060021AF RID: 8623 RVA: 0x0000C03C File Offset: 0x0000A23C
	static Delegate630()
	{
		Class15.smethod_14(typeof(Delegate630).TypeHandle);
	}

	// Token: 0x04000C56 RID: 3158
	internal static Delegate630 delegate630_0;
}
