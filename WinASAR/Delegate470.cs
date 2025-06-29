using System;

// Token: 0x020003E6 RID: 998
internal sealed class Delegate470 : MulticastDelegate
{
	// Token: 0x06001F2C RID: 7980
	public extern bool Invoke(string string_0, string string_1, ref Guid guid_0);

	// Token: 0x06001F2D RID: 7981 RVA: 0x0000B01B File Offset: 0x0000921B
	public static bool smethod_0(string string_0, string string_1, ref Guid guid_0, Delegate470 delegate470_1)
	{
		return delegate470_1(string_0, string_1, ref guid_0);
	}

	// Token: 0x06001F2E RID: 7982
	public extern Delegate470(object object_0, IntPtr intptr_0);

	// Token: 0x06001F2F RID: 7983 RVA: 0x0000B02A File Offset: 0x0000922A
	static Delegate470()
	{
		Class15.smethod_14(typeof(Delegate470).TypeHandle);
	}

	// Token: 0x04000BB6 RID: 2998
	internal static Delegate470 delegate470_0;
}
