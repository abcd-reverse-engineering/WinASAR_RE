using System;
using System.Linq.Expressions;

// Token: 0x02000475 RID: 1141
internal sealed class Delegate613 : MulticastDelegate
{
	// Token: 0x06002168 RID: 8552
	public extern ParameterExpression Invoke(Type type_0);

	// Token: 0x06002169 RID: 8553 RVA: 0x0000BE7B File Offset: 0x0000A07B
	public static ParameterExpression smethod_0(Type type_0, Delegate613 delegate613_1)
	{
		return delegate613_1(type_0);
	}

	// Token: 0x0600216A RID: 8554
	public extern Delegate613(object object_0, IntPtr intptr_0);

	// Token: 0x0600216B RID: 8555 RVA: 0x0000BE86 File Offset: 0x0000A086
	static Delegate613()
	{
		Class15.smethod_14(typeof(Delegate613).TypeHandle);
	}

	// Token: 0x04000C45 RID: 3141
	internal static Delegate613 delegate613_0;
}
