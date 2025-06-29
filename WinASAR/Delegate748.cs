using System;

// Token: 0x020004FC RID: 1276
internal sealed class Delegate748 : MulticastDelegate
{
	// Token: 0x06002384 RID: 9092
	public extern int Invoke(object object_0, int int_0);

	// Token: 0x06002385 RID: 9093 RVA: 0x0000CBC4 File Offset: 0x0000ADC4
	public static int smethod_0(object object_0, int int_0, Delegate748 delegate748_1)
	{
		return delegate748_1(object_0, int_0);
	}

	// Token: 0x06002386 RID: 9094
	public extern Delegate748(object object_0, IntPtr intptr_0);

	// Token: 0x06002387 RID: 9095 RVA: 0x0000CBD1 File Offset: 0x0000ADD1
	static Delegate748()
	{
		Class15.smethod_14(typeof(Delegate748).TypeHandle);
	}

	// Token: 0x04000CCC RID: 3276
	internal static Delegate748 delegate748_0;
}
