using System;

// Token: 0x02000325 RID: 805
internal sealed class Delegate277 : MulticastDelegate
{
	// Token: 0x06001C28 RID: 7208
	public extern int Invoke(object object_0, string string_0, int int_0, StringComparison stringComparison_0);

	// Token: 0x06001C29 RID: 7209 RVA: 0x00009C8D File Offset: 0x00007E8D
	public static int smethod_0(object object_0, string string_0, int int_0, StringComparison stringComparison_0, Delegate277 delegate277_1)
	{
		return delegate277_1(object_0, string_0, int_0, stringComparison_0);
	}

	// Token: 0x06001C2A RID: 7210
	public extern Delegate277(object object_0, IntPtr intptr_0);

	// Token: 0x06001C2B RID: 7211 RVA: 0x00009C9E File Offset: 0x00007E9E
	static Delegate277()
	{
		Class15.smethod_14(typeof(Delegate277).TypeHandle);
	}

	// Token: 0x04000AF5 RID: 2805
	internal static Delegate277 delegate277_0;
}
