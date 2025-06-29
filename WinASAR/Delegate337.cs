using System;

// Token: 0x02000361 RID: 865
internal sealed class Delegate337 : MulticastDelegate
{
	// Token: 0x06001D18 RID: 7448
	public extern bool Invoke(Uri uri_0, Uri uri_1);

	// Token: 0x06001D19 RID: 7449 RVA: 0x0000A2A5 File Offset: 0x000084A5
	public static bool smethod_0(Uri uri_0, Uri uri_1, Delegate337 delegate337_1)
	{
		return delegate337_1(uri_0, uri_1);
	}

	// Token: 0x06001D1A RID: 7450
	public extern Delegate337(object object_0, IntPtr intptr_0);

	// Token: 0x06001D1B RID: 7451 RVA: 0x0000A2B2 File Offset: 0x000084B2
	static Delegate337()
	{
		Class15.smethod_14(typeof(Delegate337).TypeHandle);
	}

	// Token: 0x04000B31 RID: 2865
	internal static Delegate337 delegate337_0;
}
