using System;

// Token: 0x02000378 RID: 888
internal sealed class Delegate360 : MulticastDelegate
{
	// Token: 0x06001D74 RID: 7540
	public extern bool Invoke(object object_0, IFormatProvider iformatProvider_0);

	// Token: 0x06001D75 RID: 7541 RVA: 0x0000A4F9 File Offset: 0x000086F9
	public static bool smethod_0(object object_0, IFormatProvider iformatProvider_0, Delegate360 delegate360_1)
	{
		return delegate360_1(object_0, iformatProvider_0);
	}

	// Token: 0x06001D76 RID: 7542
	public extern Delegate360(object object_0, IntPtr intptr_0);

	// Token: 0x06001D77 RID: 7543 RVA: 0x0000A506 File Offset: 0x00008706
	static Delegate360()
	{
		Class15.smethod_14(typeof(Delegate360).TypeHandle);
	}

	// Token: 0x04000B48 RID: 2888
	internal static Delegate360 delegate360_0;
}
