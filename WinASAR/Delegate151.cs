using System;

// Token: 0x020002A7 RID: 679
internal sealed class Delegate151 : MulticastDelegate
{
	// Token: 0x06001A30 RID: 6704
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x06001A31 RID: 6705 RVA: 0x00009025 File Offset: 0x00007225
	public static void smethod_0(object object_0, string string_0, Delegate151 delegate151_1)
	{
		delegate151_1(object_0, string_0);
	}

	// Token: 0x06001A32 RID: 6706
	public extern Delegate151(object object_0, IntPtr intptr_0);

	// Token: 0x06001A33 RID: 6707 RVA: 0x00009032 File Offset: 0x00007232
	static Delegate151()
	{
		Class15.smethod_14(typeof(Delegate151).TypeHandle);
	}

	// Token: 0x04000A77 RID: 2679
	internal static Delegate151 delegate151_0;
}
