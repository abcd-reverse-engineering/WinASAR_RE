using System;
using System.Reflection;

// Token: 0x020004AD RID: 1197
internal sealed class Delegate669 : MulticastDelegate
{
	// Token: 0x06002248 RID: 8776
	public extern Attribute[] Invoke(MemberInfo memberInfo_0, bool bool_0);

	// Token: 0x06002249 RID: 8777 RVA: 0x0000C409 File Offset: 0x0000A609
	public static Attribute[] smethod_0(MemberInfo memberInfo_0, bool bool_0, Delegate669 delegate669_1)
	{
		return delegate669_1(memberInfo_0, bool_0);
	}

	// Token: 0x0600224A RID: 8778
	public extern Delegate669(object object_0, IntPtr intptr_0);

	// Token: 0x0600224B RID: 8779 RVA: 0x0000C416 File Offset: 0x0000A616
	static Delegate669()
	{
		Class15.smethod_14(typeof(Delegate669).TypeHandle);
	}

	// Token: 0x04000C7D RID: 3197
	internal static Delegate669 delegate669_0;
}
