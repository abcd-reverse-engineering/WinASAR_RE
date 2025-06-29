using System;

// Token: 0x020003FE RID: 1022
internal sealed class Delegate494 : MulticastDelegate
{
	// Token: 0x06001F8C RID: 8076
	public extern bool Invoke(DateTime dateTime_0, DateTime dateTime_1);

	// Token: 0x06001F8D RID: 8077 RVA: 0x0000B28F File Offset: 0x0000948F
	public static bool smethod_0(DateTime dateTime_0, DateTime dateTime_1, Delegate494 delegate494_1)
	{
		return delegate494_1(dateTime_0, dateTime_1);
	}

	// Token: 0x06001F8E RID: 8078
	public extern Delegate494(object object_0, IntPtr intptr_0);

	// Token: 0x06001F8F RID: 8079 RVA: 0x0000B29C File Offset: 0x0000949C
	static Delegate494()
	{
		Class15.smethod_14(typeof(Delegate494).TypeHandle);
	}

	// Token: 0x04000BCE RID: 3022
	internal static Delegate494 delegate494_0;
}
