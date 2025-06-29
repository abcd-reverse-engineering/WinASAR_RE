using System;

// Token: 0x02000243 RID: 579
internal sealed class Delegate51 : MulticastDelegate
{
	// Token: 0x060018A0 RID: 6304
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x060018A1 RID: 6305 RVA: 0x0000864F File Offset: 0x0000684F
	public static void smethod_0(object object_0, bool bool_0, Delegate51 delegate51_1)
	{
		delegate51_1(object_0, bool_0);
	}

	// Token: 0x060018A2 RID: 6306
	public extern Delegate51(object object_0, IntPtr intptr_0);

	// Token: 0x060018A3 RID: 6307 RVA: 0x0000865C File Offset: 0x0000685C
	static Delegate51()
	{
		Class15.smethod_14(typeof(Delegate51).TypeHandle);
	}

	// Token: 0x04000A13 RID: 2579
	internal static Delegate51 delegate51_0;
}
