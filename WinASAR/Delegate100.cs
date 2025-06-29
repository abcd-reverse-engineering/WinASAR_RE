using System;

// Token: 0x02000274 RID: 628
internal sealed class Delegate100 : MulticastDelegate
{
	// Token: 0x06001964 RID: 6500
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x06001965 RID: 6501 RVA: 0x00008B29 File Offset: 0x00006D29
	public static void smethod_0(object object_0, bool bool_0, Delegate100 delegate100_1)
	{
		delegate100_1(object_0, bool_0);
	}

	// Token: 0x06001966 RID: 6502
	public extern Delegate100(object object_0, IntPtr intptr_0);

	// Token: 0x06001967 RID: 6503 RVA: 0x00008B36 File Offset: 0x00006D36
	static Delegate100()
	{
		Class15.smethod_14(typeof(Delegate100).TypeHandle);
	}

	// Token: 0x04000A44 RID: 2628
	internal static Delegate100 delegate100_0;
}
