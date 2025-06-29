using System;

// Token: 0x020002C0 RID: 704
internal sealed class Delegate176 : MulticastDelegate
{
	// Token: 0x06001A94 RID: 6804
	public extern string[] Invoke(object object_0);

	// Token: 0x06001A95 RID: 6805 RVA: 0x0000929D File Offset: 0x0000749D
	public static string[] smethod_0(object object_0, Delegate176 delegate176_1)
	{
		return delegate176_1(object_0);
	}

	// Token: 0x06001A96 RID: 6806
	public extern Delegate176(object object_0, IntPtr intptr_0);

	// Token: 0x06001A97 RID: 6807 RVA: 0x000092A8 File Offset: 0x000074A8
	static Delegate176()
	{
		Class15.smethod_14(typeof(Delegate176).TypeHandle);
	}

	// Token: 0x04000A90 RID: 2704
	internal static Delegate176 delegate176_0;
}
