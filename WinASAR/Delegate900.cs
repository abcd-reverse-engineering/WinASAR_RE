using System;

// Token: 0x02000594 RID: 1428
internal sealed class Delegate900 : MulticastDelegate
{
	// Token: 0x060025E4 RID: 9700
	public extern string Invoke(object object_0);

	// Token: 0x060025E5 RID: 9701 RVA: 0x0000DACC File Offset: 0x0000BCCC
	public static string smethod_0(object object_0, Delegate900 delegate900_1)
	{
		return delegate900_1(object_0);
	}

	// Token: 0x060025E6 RID: 9702
	public extern Delegate900(object object_0, IntPtr intptr_0);

	// Token: 0x060025E7 RID: 9703 RVA: 0x0000DAD7 File Offset: 0x0000BCD7
	static Delegate900()
	{
		Class15.smethod_14(typeof(Delegate900).TypeHandle);
	}

	// Token: 0x04000D64 RID: 3428
	internal static Delegate900 delegate900_0;
}
