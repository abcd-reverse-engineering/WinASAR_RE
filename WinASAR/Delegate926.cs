using System;

// Token: 0x020005AE RID: 1454
internal sealed class Delegate926 : MulticastDelegate
{
	// Token: 0x0600264C RID: 9804
	public extern string Invoke(object object_0);

	// Token: 0x0600264D RID: 9805 RVA: 0x0000DD4A File Offset: 0x0000BF4A
	public static string smethod_0(object object_0, Delegate926 delegate926_1)
	{
		return delegate926_1(object_0);
	}

	// Token: 0x0600264E RID: 9806
	public extern Delegate926(object object_0, IntPtr intptr_0);

	// Token: 0x0600264F RID: 9807 RVA: 0x0000DD55 File Offset: 0x0000BF55
	static Delegate926()
	{
		Class15.smethod_14(typeof(Delegate926).TypeHandle);
	}

	// Token: 0x04000D7E RID: 3454
	internal static Delegate926 delegate926_0;
}
