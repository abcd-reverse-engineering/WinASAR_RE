using System;

// Token: 0x020004EE RID: 1262
internal sealed class Delegate734 : MulticastDelegate
{
	// Token: 0x0600234C RID: 9036
	public extern bool Invoke(object object_0);

	// Token: 0x0600234D RID: 9037 RVA: 0x0000CA58 File Offset: 0x0000AC58
	public static bool smethod_0(object object_0, Delegate734 delegate734_1)
	{
		return delegate734_1(object_0);
	}

	// Token: 0x0600234E RID: 9038
	public extern Delegate734(object object_0, IntPtr intptr_0);

	// Token: 0x0600234F RID: 9039 RVA: 0x0000CA63 File Offset: 0x0000AC63
	static Delegate734()
	{
		Class15.smethod_14(typeof(Delegate734).TypeHandle);
	}

	// Token: 0x04000CBE RID: 3262
	internal static Delegate734 delegate734_0;
}
