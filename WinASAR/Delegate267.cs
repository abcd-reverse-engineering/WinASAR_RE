using System;

// Token: 0x0200031B RID: 795
internal sealed class Delegate267 : MulticastDelegate
{
	// Token: 0x06001C00 RID: 7168
	public extern void Invoke(object object_0, int int_0);

	// Token: 0x06001C01 RID: 7169 RVA: 0x00009B8D File Offset: 0x00007D8D
	public static void smethod_0(object object_0, int int_0, Delegate267 delegate267_1)
	{
		delegate267_1(object_0, int_0);
	}

	// Token: 0x06001C02 RID: 7170
	public extern Delegate267(object object_0, IntPtr intptr_0);

	// Token: 0x06001C03 RID: 7171 RVA: 0x00009B9A File Offset: 0x00007D9A
	static Delegate267()
	{
		Class15.smethod_14(typeof(Delegate267).TypeHandle);
	}

	// Token: 0x04000AEB RID: 2795
	internal static Delegate267 delegate267_0;
}
