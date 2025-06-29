using System;

// Token: 0x02000386 RID: 902
internal sealed class Delegate374 : MulticastDelegate
{
	// Token: 0x06001DAC RID: 7596
	public extern void Invoke(Array array_0, int int_0, Array array_1, int int_1, int int_2);

	// Token: 0x06001DAD RID: 7597 RVA: 0x0000A66D File Offset: 0x0000886D
	public static void smethod_0(Array array_0, int int_0, Array array_1, int int_1, int int_2, Delegate374 delegate374_1)
	{
		delegate374_1(array_0, int_0, array_1, int_1, int_2);
	}

	// Token: 0x06001DAE RID: 7598
	public extern Delegate374(object object_0, IntPtr intptr_0);

	// Token: 0x06001DAF RID: 7599 RVA: 0x0000A680 File Offset: 0x00008880
	static Delegate374()
	{
		Class15.smethod_14(typeof(Delegate374).TypeHandle);
	}

	// Token: 0x04000B56 RID: 2902
	internal static Delegate374 delegate374_0;
}
