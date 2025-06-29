using System;

// Token: 0x020005B8 RID: 1464
internal sealed class Delegate936 : MulticastDelegate
{
	// Token: 0x06002674 RID: 9844
	public extern bool Invoke(string string_0);

	// Token: 0x06002675 RID: 9845 RVA: 0x0000DE44 File Offset: 0x0000C044
	public static bool smethod_0(string string_0, Delegate936 delegate936_1)
	{
		return delegate936_1(string_0);
	}

	// Token: 0x06002676 RID: 9846
	public extern Delegate936(object object_0, IntPtr intptr_0);

	// Token: 0x06002677 RID: 9847 RVA: 0x0000DE4F File Offset: 0x0000C04F
	static Delegate936()
	{
		Class15.smethod_14(typeof(Delegate936).TypeHandle);
	}

	// Token: 0x04000D88 RID: 3464
	internal static Delegate936 delegate936_0;
}
