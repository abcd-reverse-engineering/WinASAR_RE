using System;

// Token: 0x0200052D RID: 1325
internal sealed class Delegate797 : MulticastDelegate
{
	// Token: 0x06002448 RID: 9288
	public extern bool Invoke(Uri uri_0, Uri uri_1);

	// Token: 0x06002449 RID: 9289 RVA: 0x0000D090 File Offset: 0x0000B290
	public static bool smethod_0(Uri uri_0, Uri uri_1, Delegate797 delegate797_1)
	{
		return delegate797_1(uri_0, uri_1);
	}

	// Token: 0x0600244A RID: 9290
	public extern Delegate797(object object_0, IntPtr intptr_0);

	// Token: 0x0600244B RID: 9291 RVA: 0x0000D09D File Offset: 0x0000B29D
	static Delegate797()
	{
		Class15.smethod_14(typeof(Delegate797).TypeHandle);
	}

	// Token: 0x04000CFD RID: 3325
	internal static Delegate797 delegate797_0;
}
