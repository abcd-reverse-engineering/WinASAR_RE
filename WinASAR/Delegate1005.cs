using System;
using System.Reflection;

// Token: 0x020005FD RID: 1533
internal sealed class Delegate1005 : MulticastDelegate
{
	// Token: 0x06002788 RID: 10120
	public extern Delegate Invoke(Type type_0, MethodInfo methodInfo_0);

	// Token: 0x06002789 RID: 10121 RVA: 0x0000E54E File Offset: 0x0000C74E
	public static Delegate smethod_0(Type type_0, MethodInfo methodInfo_0, Delegate1005 delegate1005_1)
	{
		return delegate1005_1(type_0, methodInfo_0);
	}

	// Token: 0x0600278A RID: 10122
	public extern Delegate1005(object object_0, IntPtr intptr_0);

	// Token: 0x0600278B RID: 10123 RVA: 0x0000E55B File Offset: 0x0000C75B
	static Delegate1005()
	{
		Class15.smethod_14(typeof(Delegate1005).TypeHandle);
	}

	// Token: 0x04000DCD RID: 3533
	internal static Delegate1005 delegate1005_0;
}
