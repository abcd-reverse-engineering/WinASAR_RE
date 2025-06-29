using System;
using System.Reflection;

// Token: 0x020004E2 RID: 1250
internal sealed class Delegate722 : MulticastDelegate
{
	// Token: 0x0600231C RID: 8988
	public extern bool Invoke(MemberInfo memberInfo_0, MemberInfo memberInfo_1);

	// Token: 0x0600231D RID: 8989 RVA: 0x0000C936 File Offset: 0x0000AB36
	public static bool smethod_0(MemberInfo memberInfo_0, MemberInfo memberInfo_1, Delegate722 delegate722_1)
	{
		return delegate722_1(memberInfo_0, memberInfo_1);
	}

	// Token: 0x0600231E RID: 8990
	public extern Delegate722(object object_0, IntPtr intptr_0);

	// Token: 0x0600231F RID: 8991 RVA: 0x0000C943 File Offset: 0x0000AB43
	static Delegate722()
	{
		Class15.smethod_14(typeof(Delegate722).TypeHandle);
	}

	// Token: 0x04000CB2 RID: 3250
	internal static Delegate722 delegate722_0;
}
