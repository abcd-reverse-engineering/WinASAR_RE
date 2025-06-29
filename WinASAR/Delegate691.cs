using System;

// Token: 0x020004C3 RID: 1219
internal sealed class Delegate691 : MulticastDelegate
{
	// Token: 0x060022A0 RID: 8864
	public extern string Invoke(object object_0, string string_0, string string_1);

	// Token: 0x060022A1 RID: 8865 RVA: 0x0000C642 File Offset: 0x0000A842
	public static string smethod_0(object object_0, string string_0, string string_1, Delegate691 delegate691_1)
	{
		return delegate691_1(object_0, string_0, string_1);
	}

	// Token: 0x060022A2 RID: 8866
	public extern Delegate691(object object_0, IntPtr intptr_0);

	// Token: 0x060022A3 RID: 8867 RVA: 0x0000C651 File Offset: 0x0000A851
	static Delegate691()
	{
		Class15.smethod_14(typeof(Delegate691).TypeHandle);
	}

	// Token: 0x04000C93 RID: 3219
	internal static Delegate691 delegate691_0;
}
