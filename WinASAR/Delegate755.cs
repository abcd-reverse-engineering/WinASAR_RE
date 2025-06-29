using System;
using System.Reflection;

// Token: 0x02000503 RID: 1283
internal sealed class Delegate755 : MulticastDelegate
{
	// Token: 0x060023A0 RID: 9120
	public extern bool Invoke(PropertyInfo propertyInfo_0, PropertyInfo propertyInfo_1);

	// Token: 0x060023A1 RID: 9121 RVA: 0x0000CC72 File Offset: 0x0000AE72
	public static bool smethod_0(PropertyInfo propertyInfo_0, PropertyInfo propertyInfo_1, Delegate755 delegate755_1)
	{
		return delegate755_1(propertyInfo_0, propertyInfo_1);
	}

	// Token: 0x060023A2 RID: 9122
	public extern Delegate755(object object_0, IntPtr intptr_0);

	// Token: 0x060023A3 RID: 9123 RVA: 0x0000CC7F File Offset: 0x0000AE7F
	static Delegate755()
	{
		Class15.smethod_14(typeof(Delegate755).TypeHandle);
	}

	// Token: 0x04000CD3 RID: 3283
	internal static Delegate755 delegate755_0;
}
