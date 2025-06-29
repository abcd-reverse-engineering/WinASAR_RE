using System;

// Token: 0x020004A2 RID: 1186
internal sealed class Delegate658 : MulticastDelegate
{
	// Token: 0x0600221C RID: 8732
	public extern Type Invoke(object object_0);

	// Token: 0x0600221D RID: 8733 RVA: 0x0000C2F3 File Offset: 0x0000A4F3
	public static Type smethod_0(object object_0, Delegate658 delegate658_1)
	{
		return delegate658_1(object_0);
	}

	// Token: 0x0600221E RID: 8734
	public extern Delegate658(object object_0, IntPtr intptr_0);

	// Token: 0x0600221F RID: 8735 RVA: 0x0000C2FE File Offset: 0x0000A4FE
	static Delegate658()
	{
		Class15.smethod_14(typeof(Delegate658).TypeHandle);
	}

	// Token: 0x04000C72 RID: 3186
	internal static Delegate658 delegate658_0;
}
