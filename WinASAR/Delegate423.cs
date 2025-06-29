using System;

// Token: 0x020003B7 RID: 951
internal sealed class Delegate423 : MulticastDelegate
{
	// Token: 0x06001E70 RID: 7792
	public extern bool Invoke(object object_0, object object_1, object object_2);

	// Token: 0x06001E71 RID: 7793 RVA: 0x0000AB59 File Offset: 0x00008D59
	public static bool smethod_0(object object_0, object object_1, object object_2, Delegate423 delegate423_1)
	{
		return delegate423_1(object_0, object_1, object_2);
	}

	// Token: 0x06001E72 RID: 7794
	public extern Delegate423(object object_0, IntPtr intptr_0);

	// Token: 0x06001E73 RID: 7795 RVA: 0x0000AB68 File Offset: 0x00008D68
	static Delegate423()
	{
		Class15.smethod_14(typeof(Delegate423).TypeHandle);
	}

	// Token: 0x04000B87 RID: 2951
	internal static Delegate423 delegate423_0;
}
