using System;
using System.Reflection;

// Token: 0x020004AE RID: 1198
internal sealed class Delegate670 : MulticastDelegate
{
	// Token: 0x0600224C RID: 8780
	public extern Attribute[] Invoke(MemberInfo memberInfo_0, Type type_0, bool bool_0);

	// Token: 0x0600224D RID: 8781 RVA: 0x0000C423 File Offset: 0x0000A623
	public static Attribute[] smethod_0(MemberInfo memberInfo_0, Type type_0, bool bool_0, Delegate670 delegate670_1)
	{
		return delegate670_1(memberInfo_0, type_0, bool_0);
	}

	// Token: 0x0600224E RID: 8782
	public extern Delegate670(object object_0, IntPtr intptr_0);

	// Token: 0x0600224F RID: 8783 RVA: 0x0000C432 File Offset: 0x0000A632
	static Delegate670()
	{
		Class15.smethod_14(typeof(Delegate670).TypeHandle);
	}

	// Token: 0x04000C7E RID: 3198
	internal static Delegate670 delegate670_0;
}
