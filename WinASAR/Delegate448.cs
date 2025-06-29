using System;
using System.Reflection;

// Token: 0x020003D0 RID: 976
internal sealed class Delegate448 : MulticastDelegate
{
	// Token: 0x06001ED4 RID: 7892
	public extern bool Invoke(MethodInfo methodInfo_0, MethodInfo methodInfo_1);

	// Token: 0x06001ED5 RID: 7893 RVA: 0x0000ADDF File Offset: 0x00008FDF
	public static bool smethod_0(MethodInfo methodInfo_0, MethodInfo methodInfo_1, Delegate448 delegate448_1)
	{
		return delegate448_1(methodInfo_0, methodInfo_1);
	}

	// Token: 0x06001ED6 RID: 7894
	public extern Delegate448(object object_0, IntPtr intptr_0);

	// Token: 0x06001ED7 RID: 7895 RVA: 0x0000ADEC File Offset: 0x00008FEC
	static Delegate448()
	{
		Class15.smethod_14(typeof(Delegate448).TypeHandle);
	}

	// Token: 0x04000BA0 RID: 2976
	internal static Delegate448 delegate448_0;
}
