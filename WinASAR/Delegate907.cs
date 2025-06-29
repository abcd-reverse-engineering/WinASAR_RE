using System;

// Token: 0x0200059B RID: 1435
internal sealed class Delegate907 : MulticastDelegate
{
	// Token: 0x06002600 RID: 9728
	public extern string Invoke(object object_0);

	// Token: 0x06002601 RID: 9729 RVA: 0x0000DB78 File Offset: 0x0000BD78
	public static string smethod_0(object object_0, Delegate907 delegate907_1)
	{
		return delegate907_1(object_0);
	}

	// Token: 0x06002602 RID: 9730
	public extern Delegate907(object object_0, IntPtr intptr_0);

	// Token: 0x06002603 RID: 9731 RVA: 0x0000DB83 File Offset: 0x0000BD83
	static Delegate907()
	{
		Class15.smethod_14(typeof(Delegate907).TypeHandle);
	}

	// Token: 0x04000D6B RID: 3435
	internal static Delegate907 delegate907_0;
}
