using System;

// Token: 0x02000562 RID: 1378
internal sealed class Delegate850 : MulticastDelegate
{
	// Token: 0x0600251C RID: 9500
	public extern bool Invoke(string string_0, ref long long_0);

	// Token: 0x0600251D RID: 9501 RVA: 0x0000D5E0 File Offset: 0x0000B7E0
	public static bool smethod_0(string string_0, ref long long_0, Delegate850 delegate850_1)
	{
		return delegate850_1(string_0, ref long_0);
	}

	// Token: 0x0600251E RID: 9502
	public extern Delegate850(object object_0, IntPtr intptr_0);

	// Token: 0x0600251F RID: 9503 RVA: 0x0000D5ED File Offset: 0x0000B7ED
	static Delegate850()
	{
		Class15.smethod_14(typeof(Delegate850).TypeHandle);
	}

	// Token: 0x04000D32 RID: 3378
	internal static Delegate850 delegate850_0;
}
