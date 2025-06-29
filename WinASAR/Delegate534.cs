using System;
using System.Linq.Expressions;

// Token: 0x02000426 RID: 1062
internal sealed class Delegate534 : MulticastDelegate
{
	// Token: 0x0600202C RID: 8236
	public extern ParameterExpression Invoke(Type type_0, string string_0);

	// Token: 0x0600202D RID: 8237 RVA: 0x0000B691 File Offset: 0x00009891
	public static ParameterExpression smethod_0(Type type_0, string string_0, Delegate534 delegate534_1)
	{
		return delegate534_1(type_0, string_0);
	}

	// Token: 0x0600202E RID: 8238
	public extern Delegate534(object object_0, IntPtr intptr_0);

	// Token: 0x0600202F RID: 8239 RVA: 0x0000B69E File Offset: 0x0000989E
	static Delegate534()
	{
		Class15.smethod_14(typeof(Delegate534).TypeHandle);
	}

	// Token: 0x04000BF6 RID: 3062
	internal static Delegate534 delegate534_0;
}
