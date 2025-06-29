using System;
using System.Linq.Expressions;

// Token: 0x0200042B RID: 1067
internal sealed class Delegate539 : MulticastDelegate
{
	// Token: 0x06002040 RID: 8256
	public extern ConstantExpression Invoke(object object_0);

	// Token: 0x06002041 RID: 8257 RVA: 0x0000B70D File Offset: 0x0000990D
	public static ConstantExpression smethod_0(object object_0, Delegate539 delegate539_1)
	{
		return delegate539_1(object_0);
	}

	// Token: 0x06002042 RID: 8258
	public extern Delegate539(object object_0, IntPtr intptr_0);

	// Token: 0x06002043 RID: 8259 RVA: 0x0000B718 File Offset: 0x00009918
	static Delegate539()
	{
		Class15.smethod_14(typeof(Delegate539).TypeHandle);
	}

	// Token: 0x04000BFB RID: 3067
	internal static Delegate539 delegate539_0;
}
