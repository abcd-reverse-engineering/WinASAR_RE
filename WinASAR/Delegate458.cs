using System;
using System.ComponentModel;
using System.Globalization;

// Token: 0x020003DA RID: 986
internal sealed class Delegate458 : MulticastDelegate
{
	// Token: 0x06001EFC RID: 7932
	public extern object Invoke(object object_0, ITypeDescriptorContext itypeDescriptorContext_0, CultureInfo cultureInfo_0, object object_1, Type type_0);

	// Token: 0x06001EFD RID: 7933 RVA: 0x0000AEDF File Offset: 0x000090DF
	public static object smethod_0(object object_0, ITypeDescriptorContext itypeDescriptorContext_0, CultureInfo cultureInfo_0, object object_1, Type type_0, Delegate458 delegate458_1)
	{
		return delegate458_1(object_0, itypeDescriptorContext_0, cultureInfo_0, object_1, type_0);
	}

	// Token: 0x06001EFE RID: 7934
	public extern Delegate458(object object_0, IntPtr intptr_0);

	// Token: 0x06001EFF RID: 7935 RVA: 0x0000AEF2 File Offset: 0x000090F2
	static Delegate458()
	{
		Class15.smethod_14(typeof(Delegate458).TypeHandle);
	}

	// Token: 0x04000BAA RID: 2986
	internal static Delegate458 delegate458_0;
}
