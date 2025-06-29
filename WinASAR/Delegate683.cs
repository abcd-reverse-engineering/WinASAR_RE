using System;

// Token: 0x020004BB RID: 1211
internal sealed class Delegate683 : MulticastDelegate
{
	// Token: 0x06002280 RID: 8832
	public extern void Invoke(Array array_0, int int_0, Array array_1, int int_1, int int_2);

	// Token: 0x06002281 RID: 8833 RVA: 0x0000C572 File Offset: 0x0000A772
	public static void smethod_0(Array array_0, int int_0, Array array_1, int int_1, int int_2, Delegate683 delegate683_1)
	{
		delegate683_1(array_0, int_0, array_1, int_1, int_2);
	}

	// Token: 0x06002282 RID: 8834
	public extern Delegate683(object object_0, IntPtr intptr_0);

	// Token: 0x06002283 RID: 8835 RVA: 0x0000C585 File Offset: 0x0000A785
	static Delegate683()
	{
		Class15.smethod_14(typeof(Delegate683).TypeHandle);
	}

	// Token: 0x04000C8B RID: 3211
	internal static Delegate683 delegate683_0;
}
