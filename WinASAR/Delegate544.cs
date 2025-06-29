using System;
using System.Dynamic;

// Token: 0x02000430 RID: 1072
internal sealed class Delegate544 : MulticastDelegate
{
	// Token: 0x06002054 RID: 8276
	public extern BindingRestrictions Invoke(object object_0, BindingRestrictions bindingRestrictions_0);

	// Token: 0x06002055 RID: 8277 RVA: 0x0000B793 File Offset: 0x00009993
	public static BindingRestrictions smethod_0(object object_0, BindingRestrictions bindingRestrictions_0, Delegate544 delegate544_1)
	{
		return delegate544_1(object_0, bindingRestrictions_0);
	}

	// Token: 0x06002056 RID: 8278
	public extern Delegate544(object object_0, IntPtr intptr_0);

	// Token: 0x06002057 RID: 8279 RVA: 0x0000B7A0 File Offset: 0x000099A0
	static Delegate544()
	{
		Class15.smethod_14(typeof(Delegate544).TypeHandle);
	}

	// Token: 0x04000C00 RID: 3072
	internal static Delegate544 delegate544_0;
}
