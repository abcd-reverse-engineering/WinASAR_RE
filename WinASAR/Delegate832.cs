using System;

// Token: 0x02000550 RID: 1360
internal sealed class Delegate832 : MulticastDelegate
{
	// Token: 0x060024D4 RID: 9428
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x060024D5 RID: 9429 RVA: 0x0000D40C File Offset: 0x0000B60C
	public static void smethod_0(object object_0, string string_0, Delegate832 delegate832_1)
	{
		delegate832_1(object_0, string_0);
	}

	// Token: 0x060024D6 RID: 9430
	public extern Delegate832(object object_0, IntPtr intptr_0);

	// Token: 0x060024D7 RID: 9431 RVA: 0x0000D419 File Offset: 0x0000B619
	static Delegate832()
	{
		Class15.smethod_14(typeof(Delegate832).TypeHandle);
	}

	// Token: 0x04000D20 RID: 3360
	internal static Delegate832 delegate832_0;
}
