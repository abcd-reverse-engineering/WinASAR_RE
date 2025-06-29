using System;

// Token: 0x0200022C RID: 556
internal sealed class Delegate28 : MulticastDelegate
{
	// Token: 0x06001844 RID: 6212
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x06001845 RID: 6213 RVA: 0x0000840B File Offset: 0x0000660B
	public static void smethod_0(object object_0, string string_0, Delegate28 delegate28_1)
	{
		delegate28_1(object_0, string_0);
	}

	// Token: 0x06001846 RID: 6214
	public extern Delegate28(object object_0, IntPtr intptr_0);

	// Token: 0x06001847 RID: 6215 RVA: 0x00008418 File Offset: 0x00006618
	static Delegate28()
	{
		Class15.smethod_14(typeof(Delegate28).TypeHandle);
	}

	// Token: 0x040009FC RID: 2556
	internal static Delegate28 delegate28_0;
}
