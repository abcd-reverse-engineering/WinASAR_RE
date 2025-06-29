using System;

// Token: 0x020002B2 RID: 690
internal sealed class Delegate162 : MulticastDelegate
{
	// Token: 0x06001A5C RID: 6748
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x06001A5D RID: 6749 RVA: 0x00009139 File Offset: 0x00007339
	public static void smethod_0(object object_0, bool bool_0, Delegate162 delegate162_1)
	{
		delegate162_1(object_0, bool_0);
	}

	// Token: 0x06001A5E RID: 6750
	public extern Delegate162(object object_0, IntPtr intptr_0);

	// Token: 0x06001A5F RID: 6751 RVA: 0x00009146 File Offset: 0x00007346
	static Delegate162()
	{
		Class15.smethod_14(typeof(Delegate162).TypeHandle);
	}

	// Token: 0x04000A82 RID: 2690
	internal static Delegate162 delegate162_0;
}
