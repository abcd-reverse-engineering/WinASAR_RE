using System;

// Token: 0x020005C0 RID: 1472
internal sealed class Delegate944 : MulticastDelegate
{
	// Token: 0x06002694 RID: 9876
	public extern string Invoke(long long_0);

	// Token: 0x06002695 RID: 9877 RVA: 0x0000DF0C File Offset: 0x0000C10C
	public static string smethod_0(long long_0, Delegate944 delegate944_1)
	{
		return delegate944_1(long_0);
	}

	// Token: 0x06002696 RID: 9878
	public extern Delegate944(object object_0, IntPtr intptr_0);

	// Token: 0x06002697 RID: 9879 RVA: 0x0000DF17 File Offset: 0x0000C117
	static Delegate944()
	{
		Class15.smethod_14(typeof(Delegate944).TypeHandle);
	}

	// Token: 0x04000D90 RID: 3472
	internal static Delegate944 delegate944_0;
}
