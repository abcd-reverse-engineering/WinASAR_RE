using System;

// Token: 0x020005D0 RID: 1488
internal sealed class Delegate960 : MulticastDelegate
{
	// Token: 0x060026D4 RID: 9940
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x060026D5 RID: 9941 RVA: 0x0000E09A File Offset: 0x0000C29A
	public static void smethod_0(object object_0, bool bool_0, Delegate960 delegate960_1)
	{
		delegate960_1(object_0, bool_0);
	}

	// Token: 0x060026D6 RID: 9942
	public extern Delegate960(object object_0, IntPtr intptr_0);

	// Token: 0x060026D7 RID: 9943 RVA: 0x0000E0A7 File Offset: 0x0000C2A7
	static Delegate960()
	{
		Class15.smethod_14(typeof(Delegate960).TypeHandle);
	}

	// Token: 0x04000DA0 RID: 3488
	internal static Delegate960 delegate960_0;
}
