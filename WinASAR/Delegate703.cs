using System;

// Token: 0x020004CF RID: 1231
internal sealed class Delegate703 : MulticastDelegate
{
	// Token: 0x060022D0 RID: 8912
	public extern bool Invoke(object object_0);

	// Token: 0x060022D1 RID: 8913 RVA: 0x0000C766 File Offset: 0x0000A966
	public static bool smethod_0(object object_0, Delegate703 delegate703_1)
	{
		return delegate703_1(object_0);
	}

	// Token: 0x060022D2 RID: 8914
	public extern Delegate703(object object_0, IntPtr intptr_0);

	// Token: 0x060022D3 RID: 8915 RVA: 0x0000C771 File Offset: 0x0000A971
	static Delegate703()
	{
		Class15.smethod_14(typeof(Delegate703).TypeHandle);
	}

	// Token: 0x04000C9F RID: 3231
	internal static Delegate703 delegate703_0;
}
