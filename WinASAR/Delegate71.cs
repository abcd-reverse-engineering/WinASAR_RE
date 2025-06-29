using System;

// Token: 0x02000257 RID: 599
internal sealed class Delegate71 : MulticastDelegate
{
	// Token: 0x060018F0 RID: 6384
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x060018F1 RID: 6385 RVA: 0x0000884B File Offset: 0x00006A4B
	public static void smethod_0(object object_0, bool bool_0, Delegate71 delegate71_1)
	{
		delegate71_1(object_0, bool_0);
	}

	// Token: 0x060018F2 RID: 6386
	public extern Delegate71(object object_0, IntPtr intptr_0);

	// Token: 0x060018F3 RID: 6387 RVA: 0x00008858 File Offset: 0x00006A58
	static Delegate71()
	{
		Class15.smethod_14(typeof(Delegate71).TypeHandle);
	}

	// Token: 0x04000A27 RID: 2599
	internal static Delegate71 delegate71_0;
}
