using System;
using System.Reflection;

// Token: 0x020004B1 RID: 1201
internal sealed class Delegate673 : MulticastDelegate
{
	// Token: 0x06002258 RID: 8792
	public extern Attribute[] Invoke(ParameterInfo parameterInfo_0, bool bool_0);

	// Token: 0x06002259 RID: 8793 RVA: 0x0000C475 File Offset: 0x0000A675
	public static Attribute[] smethod_0(ParameterInfo parameterInfo_0, bool bool_0, Delegate673 delegate673_1)
	{
		return delegate673_1(parameterInfo_0, bool_0);
	}

	// Token: 0x0600225A RID: 8794
	public extern Delegate673(object object_0, IntPtr intptr_0);

	// Token: 0x0600225B RID: 8795 RVA: 0x0000C482 File Offset: 0x0000A682
	static Delegate673()
	{
		Class15.smethod_14(typeof(Delegate673).TypeHandle);
	}

	// Token: 0x04000C81 RID: 3201
	internal static Delegate673 delegate673_0;
}
