using System;

// Token: 0x020005C2 RID: 1474
internal sealed class Delegate946 : MulticastDelegate
{
	// Token: 0x0600269C RID: 9884
	public extern string Invoke(float float_0);

	// Token: 0x0600269D RID: 9885 RVA: 0x0000DF3C File Offset: 0x0000C13C
	public static string smethod_0(float float_0, Delegate946 delegate946_1)
	{
		return delegate946_1(float_0);
	}

	// Token: 0x0600269E RID: 9886
	public extern Delegate946(object object_0, IntPtr intptr_0);

	// Token: 0x0600269F RID: 9887 RVA: 0x0000DF47 File Offset: 0x0000C147
	static Delegate946()
	{
		Class15.smethod_14(typeof(Delegate946).TypeHandle);
	}

	// Token: 0x04000D92 RID: 3474
	internal static Delegate946 delegate946_0;
}
