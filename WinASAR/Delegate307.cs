using System;

// Token: 0x02000343 RID: 835
internal sealed class Delegate307 : MulticastDelegate
{
	// Token: 0x06001CA0 RID: 7328
	public extern void Invoke(object object_0, string string_0, bool bool_0);

	// Token: 0x06001CA1 RID: 7329 RVA: 0x00009F95 File Offset: 0x00008195
	public static void smethod_0(object object_0, string string_0, bool bool_0, Delegate307 delegate307_1)
	{
		delegate307_1(object_0, string_0, bool_0);
	}

	// Token: 0x06001CA2 RID: 7330
	public extern Delegate307(object object_0, IntPtr intptr_0);

	// Token: 0x06001CA3 RID: 7331 RVA: 0x00009FA4 File Offset: 0x000081A4
	static Delegate307()
	{
		Class15.smethod_14(typeof(Delegate307).TypeHandle);
	}

	// Token: 0x04000B13 RID: 2835
	internal static Delegate307 delegate307_0;
}
