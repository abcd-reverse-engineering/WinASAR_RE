using System;

// Token: 0x020003ED RID: 1005
internal sealed class Delegate477 : MulticastDelegate
{
	// Token: 0x06001F48 RID: 8008
	public extern DateTime Invoke(ref DateTime dateTime_0);

	// Token: 0x06001F49 RID: 8009 RVA: 0x0000B0C9 File Offset: 0x000092C9
	public static DateTime smethod_0(ref DateTime dateTime_0, Delegate477 delegate477_1)
	{
		return delegate477_1(ref dateTime_0);
	}

	// Token: 0x06001F4A RID: 8010
	public extern Delegate477(object object_0, IntPtr intptr_0);

	// Token: 0x06001F4B RID: 8011 RVA: 0x0000B0D4 File Offset: 0x000092D4
	static Delegate477()
	{
		Class15.smethod_14(typeof(Delegate477).TypeHandle);
	}

	// Token: 0x04000BBD RID: 3005
	internal static Delegate477 delegate477_0;
}
