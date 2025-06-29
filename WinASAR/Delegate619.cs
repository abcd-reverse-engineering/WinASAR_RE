using System;
using System.Linq.Expressions;

// Token: 0x0200047B RID: 1147
internal sealed class Delegate619 : MulticastDelegate
{
	// Token: 0x06002180 RID: 8576
	public extern NewExpression Invoke(Type type_0);

	// Token: 0x06002181 RID: 8577 RVA: 0x0000BF17 File Offset: 0x0000A117
	public static NewExpression smethod_0(Type type_0, Delegate619 delegate619_1)
	{
		return delegate619_1(type_0);
	}

	// Token: 0x06002182 RID: 8578
	public extern Delegate619(object object_0, IntPtr intptr_0);

	// Token: 0x06002183 RID: 8579 RVA: 0x0000BF22 File Offset: 0x0000A122
	static Delegate619()
	{
		Class15.smethod_14(typeof(Delegate619).TypeHandle);
	}

	// Token: 0x04000C4B RID: 3147
	internal static Delegate619 delegate619_0;
}
