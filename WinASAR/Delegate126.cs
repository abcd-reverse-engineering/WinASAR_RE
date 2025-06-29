using System;

// Token: 0x0200028E RID: 654
internal sealed class Delegate126 : MulticastDelegate
{
	// Token: 0x060019CC RID: 6604
	public extern string Invoke(object object_0);

	// Token: 0x060019CD RID: 6605 RVA: 0x00008DB3 File Offset: 0x00006FB3
	public static string smethod_0(object object_0, Delegate126 delegate126_1)
	{
		return delegate126_1(object_0);
	}

	// Token: 0x060019CE RID: 6606
	public extern Delegate126(object object_0, IntPtr intptr_0);

	// Token: 0x060019CF RID: 6607 RVA: 0x00008DBE File Offset: 0x00006FBE
	static Delegate126()
	{
		Class15.smethod_14(typeof(Delegate126).TypeHandle);
	}

	// Token: 0x04000A5E RID: 2654
	internal static Delegate126 delegate126_0;
}
