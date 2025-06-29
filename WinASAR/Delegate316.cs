using System;

// Token: 0x0200034C RID: 844
internal sealed class Delegate316 : MulticastDelegate
{
	// Token: 0x06001CC4 RID: 7364
	public extern void Invoke(ref int int_0, int int_1);

	// Token: 0x06001CC5 RID: 7365 RVA: 0x0000A073 File Offset: 0x00008273
	public static void smethod_0(ref int int_0, int int_1, Delegate316 delegate316_1)
	{
		delegate316_1(ref int_0, int_1);
	}

	// Token: 0x06001CC6 RID: 7366
	public extern Delegate316(object object_0, IntPtr intptr_0);

	// Token: 0x06001CC7 RID: 7367 RVA: 0x0000A080 File Offset: 0x00008280
	static Delegate316()
	{
		Class15.smethod_14(typeof(Delegate316).TypeHandle);
	}

	// Token: 0x04000B1C RID: 2844
	internal static Delegate316 delegate316_0;
}
