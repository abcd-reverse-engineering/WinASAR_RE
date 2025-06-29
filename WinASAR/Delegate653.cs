using System;
using System.Reflection;

// Token: 0x0200049D RID: 1181
internal sealed class Delegate653 : MulticastDelegate
{
	// Token: 0x06002208 RID: 8712
	public extern bool Invoke(ConstructorInfo constructorInfo_0, ConstructorInfo constructorInfo_1);

	// Token: 0x06002209 RID: 8713 RVA: 0x0000C279 File Offset: 0x0000A479
	public static bool smethod_0(ConstructorInfo constructorInfo_0, ConstructorInfo constructorInfo_1, Delegate653 delegate653_1)
	{
		return delegate653_1(constructorInfo_0, constructorInfo_1);
	}

	// Token: 0x0600220A RID: 8714
	public extern Delegate653(object object_0, IntPtr intptr_0);

	// Token: 0x0600220B RID: 8715 RVA: 0x0000C286 File Offset: 0x0000A486
	static Delegate653()
	{
		Class15.smethod_14(typeof(Delegate653).TypeHandle);
	}

	// Token: 0x04000C6D RID: 3181
	internal static Delegate653 delegate653_0;
}
