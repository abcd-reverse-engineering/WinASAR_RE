using System;

// Token: 0x020003BB RID: 955
internal sealed class Delegate427 : MulticastDelegate
{
	// Token: 0x06001E80 RID: 7808
	public extern void Invoke(object object_0, object object_1, int[] int_0);

	// Token: 0x06001E81 RID: 7809 RVA: 0x0000ABBF File Offset: 0x00008DBF
	public static void smethod_0(object object_0, object object_1, int[] int_0, Delegate427 delegate427_1)
	{
		delegate427_1(object_0, object_1, int_0);
	}

	// Token: 0x06001E82 RID: 7810
	public extern Delegate427(object object_0, IntPtr intptr_0);

	// Token: 0x06001E83 RID: 7811 RVA: 0x0000ABCE File Offset: 0x00008DCE
	static Delegate427()
	{
		Class15.smethod_14(typeof(Delegate427).TypeHandle);
	}

	// Token: 0x04000B8B RID: 2955
	internal static Delegate427 delegate427_0;
}
