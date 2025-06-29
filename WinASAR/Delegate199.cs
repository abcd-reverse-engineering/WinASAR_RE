using System;

// Token: 0x020002D7 RID: 727
internal sealed class Delegate199 : MulticastDelegate
{
	// Token: 0x06001AF0 RID: 6896
	public extern string Invoke(object object_0);

	// Token: 0x06001AF1 RID: 6897 RVA: 0x000094E1 File Offset: 0x000076E1
	public static string smethod_0(object object_0, Delegate199 delegate199_1)
	{
		return delegate199_1(object_0);
	}

	// Token: 0x06001AF2 RID: 6898
	public extern Delegate199(object object_0, IntPtr intptr_0);

	// Token: 0x06001AF3 RID: 6899 RVA: 0x000094EC File Offset: 0x000076EC
	static Delegate199()
	{
		Class15.smethod_14(typeof(Delegate199).TypeHandle);
	}

	// Token: 0x04000AA7 RID: 2727
	internal static Delegate199 delegate199_0;
}
