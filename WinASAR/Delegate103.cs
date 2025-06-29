using System;

// Token: 0x02000277 RID: 631
internal sealed class Delegate103 : MulticastDelegate
{
	// Token: 0x06001970 RID: 6512
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x06001971 RID: 6513 RVA: 0x00008B77 File Offset: 0x00006D77
	public static void smethod_0(object object_0, bool bool_0, Delegate103 delegate103_1)
	{
		delegate103_1(object_0, bool_0);
	}

	// Token: 0x06001972 RID: 6514
	public extern Delegate103(object object_0, IntPtr intptr_0);

	// Token: 0x06001973 RID: 6515 RVA: 0x00008B84 File Offset: 0x00006D84
	static Delegate103()
	{
		Class15.smethod_14(typeof(Delegate103).TypeHandle);
	}

	// Token: 0x04000A47 RID: 2631
	internal static Delegate103 delegate103_0;
}
