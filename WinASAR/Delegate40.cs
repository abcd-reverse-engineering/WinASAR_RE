using System;

// Token: 0x02000238 RID: 568
internal sealed class Delegate40 : MulticastDelegate
{
	// Token: 0x06001874 RID: 6260
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x06001875 RID: 6261 RVA: 0x00008535 File Offset: 0x00006735
	public static void smethod_0(object object_0, bool bool_0, Delegate40 delegate40_1)
	{
		delegate40_1(object_0, bool_0);
	}

	// Token: 0x06001876 RID: 6262
	public extern Delegate40(object object_0, IntPtr intptr_0);

	// Token: 0x06001877 RID: 6263 RVA: 0x00008542 File Offset: 0x00006742
	static Delegate40()
	{
		Class15.smethod_14(typeof(Delegate40).TypeHandle);
	}

	// Token: 0x04000A08 RID: 2568
	internal static Delegate40 delegate40_0;
}
