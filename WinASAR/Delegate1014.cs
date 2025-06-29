using System;

// Token: 0x02000606 RID: 1542
internal sealed class Delegate1014 : MulticastDelegate
{
	// Token: 0x060027AC RID: 10156
	public extern object Invoke(Type type_0, int int_0);

	// Token: 0x060027AD RID: 10157 RVA: 0x0000E62E File Offset: 0x0000C82E
	public static object smethod_0(Type type_0, int int_0, Delegate1014 delegate1014_1)
	{
		return delegate1014_1(type_0, int_0);
	}

	// Token: 0x060027AE RID: 10158
	public extern Delegate1014(object object_0, IntPtr intptr_0);

	// Token: 0x060027AF RID: 10159 RVA: 0x0000E63B File Offset: 0x0000C83B
	static Delegate1014()
	{
		Class15.smethod_14(typeof(Delegate1014).TypeHandle);
	}

	// Token: 0x04000DD6 RID: 3542
	internal static Delegate1014 delegate1014_0;
}
