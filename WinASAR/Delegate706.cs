using System;
using System.Reflection;

// Token: 0x020004D2 RID: 1234
internal sealed class Delegate706 : MulticastDelegate
{
	// Token: 0x060022DC RID: 8924
	public extern bool Invoke(MemberInfo memberInfo_0, MemberInfo memberInfo_1);

	// Token: 0x060022DD RID: 8925 RVA: 0x0000C7AE File Offset: 0x0000A9AE
	public static bool smethod_0(MemberInfo memberInfo_0, MemberInfo memberInfo_1, Delegate706 delegate706_1)
	{
		return delegate706_1(memberInfo_0, memberInfo_1);
	}

	// Token: 0x060022DE RID: 8926
	public extern Delegate706(object object_0, IntPtr intptr_0);

	// Token: 0x060022DF RID: 8927 RVA: 0x0000C7BB File Offset: 0x0000A9BB
	static Delegate706()
	{
		Class15.smethod_14(typeof(Delegate706).TypeHandle);
	}

	// Token: 0x04000CA2 RID: 3234
	internal static Delegate706 delegate706_0;
}
