using System;

// Token: 0x0200049F RID: 1183
internal sealed class Delegate655 : MulticastDelegate
{
	// Token: 0x06002210 RID: 8720
	public extern Type[] Invoke(object object_0);

	// Token: 0x06002211 RID: 8721 RVA: 0x0000C2AB File Offset: 0x0000A4AB
	public static Type[] smethod_0(object object_0, Delegate655 delegate655_1)
	{
		return delegate655_1(object_0);
	}

	// Token: 0x06002212 RID: 8722
	public extern Delegate655(object object_0, IntPtr intptr_0);

	// Token: 0x06002213 RID: 8723 RVA: 0x0000C2B6 File Offset: 0x0000A4B6
	static Delegate655()
	{
		Class15.smethod_14(typeof(Delegate655).TypeHandle);
	}

	// Token: 0x04000C6F RID: 3183
	internal static Delegate655 delegate655_0;
}
