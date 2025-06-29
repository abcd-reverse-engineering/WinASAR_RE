using System;

// Token: 0x020003B1 RID: 945
internal sealed class Delegate417 : MulticastDelegate
{
	// Token: 0x06001E58 RID: 7768
	public extern bool Invoke(double double_0);

	// Token: 0x06001E59 RID: 7769 RVA: 0x0000AAC3 File Offset: 0x00008CC3
	public static bool smethod_0(double double_0, Delegate417 delegate417_1)
	{
		return delegate417_1(double_0);
	}

	// Token: 0x06001E5A RID: 7770
	public extern Delegate417(object object_0, IntPtr intptr_0);

	// Token: 0x06001E5B RID: 7771 RVA: 0x0000AACE File Offset: 0x00008CCE
	static Delegate417()
	{
		Class15.smethod_14(typeof(Delegate417).TypeHandle);
	}

	// Token: 0x04000B81 RID: 2945
	internal static Delegate417 delegate417_0;
}
