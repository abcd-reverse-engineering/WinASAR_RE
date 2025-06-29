using System;

// Token: 0x02000391 RID: 913
internal sealed class Delegate385 : MulticastDelegate
{
	// Token: 0x06001DD8 RID: 7640
	public extern decimal Invoke(decimal decimal_0, decimal decimal_1);

	// Token: 0x06001DD9 RID: 7641 RVA: 0x0000A789 File Offset: 0x00008989
	public static decimal smethod_0(decimal decimal_0, decimal decimal_1, Delegate385 delegate385_1)
	{
		return delegate385_1(decimal_0, decimal_1);
	}

	// Token: 0x06001DDA RID: 7642
	public extern Delegate385(object object_0, IntPtr intptr_0);

	// Token: 0x06001DDB RID: 7643 RVA: 0x0000A796 File Offset: 0x00008996
	static Delegate385()
	{
		Class15.smethod_14(typeof(Delegate385).TypeHandle);
	}

	// Token: 0x04000B61 RID: 2913
	internal static Delegate385 delegate385_0;
}
