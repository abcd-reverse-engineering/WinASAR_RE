using System;
using System.ComponentModel;

// Token: 0x020003D8 RID: 984
internal sealed class Delegate456 : MulticastDelegate
{
	// Token: 0x06001EF4 RID: 7924
	public extern TypeConverter Invoke(Type type_0);

	// Token: 0x06001EF5 RID: 7925 RVA: 0x0000AEAD File Offset: 0x000090AD
	public static TypeConverter smethod_0(Type type_0, Delegate456 delegate456_1)
	{
		return delegate456_1(type_0);
	}

	// Token: 0x06001EF6 RID: 7926
	public extern Delegate456(object object_0, IntPtr intptr_0);

	// Token: 0x06001EF7 RID: 7927 RVA: 0x0000AEB8 File Offset: 0x000090B8
	static Delegate456()
	{
		Class15.smethod_14(typeof(Delegate456).TypeHandle);
	}

	// Token: 0x04000BA8 RID: 2984
	internal static Delegate456 delegate456_0;
}
