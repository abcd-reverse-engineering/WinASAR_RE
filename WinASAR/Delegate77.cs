using System;

// Token: 0x0200025D RID: 605
internal sealed class Delegate77 : MulticastDelegate
{
	// Token: 0x06001908 RID: 6408
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x06001909 RID: 6409 RVA: 0x000088E5 File Offset: 0x00006AE5
	public static void smethod_0(object object_0, bool bool_0, Delegate77 delegate77_1)
	{
		delegate77_1(object_0, bool_0);
	}

	// Token: 0x0600190A RID: 6410
	public extern Delegate77(object object_0, IntPtr intptr_0);

	// Token: 0x0600190B RID: 6411 RVA: 0x000088F2 File Offset: 0x00006AF2
	static Delegate77()
	{
		Class15.smethod_14(typeof(Delegate77).TypeHandle);
	}

	// Token: 0x04000A2D RID: 2605
	internal static Delegate77 delegate77_0;
}
