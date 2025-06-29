using System;

// Token: 0x020003AB RID: 939
internal sealed class Delegate411 : MulticastDelegate
{
	// Token: 0x06001E40 RID: 7744
	public extern string Invoke(object object_0, IFormatProvider iformatProvider_0);

	// Token: 0x06001E41 RID: 7745 RVA: 0x0000AA1F File Offset: 0x00008C1F
	public static string smethod_0(object object_0, IFormatProvider iformatProvider_0, Delegate411 delegate411_1)
	{
		return delegate411_1(object_0, iformatProvider_0);
	}

	// Token: 0x06001E42 RID: 7746
	public extern Delegate411(object object_0, IntPtr intptr_0);

	// Token: 0x06001E43 RID: 7747 RVA: 0x0000AA2C File Offset: 0x00008C2C
	static Delegate411()
	{
		Class15.smethod_14(typeof(Delegate411).TypeHandle);
	}

	// Token: 0x04000B7B RID: 2939
	internal static Delegate411 delegate411_0;
}
