using System;
using System.Dynamic;

// Token: 0x02000416 RID: 1046
internal sealed class Delegate518 : MulticastDelegate
{
	// Token: 0x06001FEC RID: 8172
	public extern DynamicMetaObject Invoke(object object_0, SetMemberBinder setMemberBinder_0, DynamicMetaObject dynamicMetaObject_0);

	// Token: 0x06001FED RID: 8173 RVA: 0x0000B4E3 File Offset: 0x000096E3
	public static DynamicMetaObject smethod_0(object object_0, SetMemberBinder setMemberBinder_0, DynamicMetaObject dynamicMetaObject_0, Delegate518 delegate518_0)
	{
		return delegate518_0(object_0, setMemberBinder_0, dynamicMetaObject_0);
	}

	// Token: 0x06001FEE RID: 8174
	public extern Delegate518(object object_0, IntPtr intptr_0);

	// Token: 0x06001FEF RID: 8175 RVA: 0x0000B4F2 File Offset: 0x000096F2
	static Delegate518()
	{
		Class15.smethod_14(typeof(Delegate518).TypeHandle);
	}

	// Token: 0x04000BE6 RID: 3046
	internal static Delegate518 bNymUpetKB;
}
