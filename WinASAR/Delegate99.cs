using System;

// Token: 0x02000273 RID: 627
internal sealed class Delegate99 : MulticastDelegate
{
	// Token: 0x06001960 RID: 6496
	public extern void Invoke(object object_0, int int_0);

	// Token: 0x06001961 RID: 6497 RVA: 0x00008B0F File Offset: 0x00006D0F
	public static void smethod_0(object object_0, int int_0, Delegate99 delegate99_1)
	{
		delegate99_1(object_0, int_0);
	}

	// Token: 0x06001962 RID: 6498
	public extern Delegate99(object object_0, IntPtr intptr_0);

	// Token: 0x06001963 RID: 6499 RVA: 0x00008B1C File Offset: 0x00006D1C
	static Delegate99()
	{
		Class15.smethod_14(typeof(Delegate99).TypeHandle);
	}

	// Token: 0x04000A43 RID: 2627
	internal static Delegate99 delegate99_0;
}
