using System;

// Token: 0x02000247 RID: 583
internal sealed class Delegate55 : MulticastDelegate
{
	// Token: 0x060018B0 RID: 6320
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x060018B1 RID: 6321 RVA: 0x000086B3 File Offset: 0x000068B3
	public static void smethod_0(object object_0, bool bool_0, Delegate55 delegate55_1)
	{
		delegate55_1(object_0, bool_0);
	}

	// Token: 0x060018B2 RID: 6322
	public extern Delegate55(object object_0, IntPtr intptr_0);

	// Token: 0x060018B3 RID: 6323 RVA: 0x000086C0 File Offset: 0x000068C0
	static Delegate55()
	{
		Class15.smethod_14(typeof(Delegate55).TypeHandle);
	}

	// Token: 0x04000A17 RID: 2583
	internal static Delegate55 delegate55_0;
}
