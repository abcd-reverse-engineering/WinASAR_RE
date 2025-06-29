using System;
using System.Windows.Forms;

// Token: 0x0200024C RID: 588
internal sealed class Delegate60 : MulticastDelegate
{
	// Token: 0x060018C4 RID: 6340
	public extern void Invoke(object object_0, PictureBoxSizeMode pictureBoxSizeMode_0);

	// Token: 0x060018C5 RID: 6341 RVA: 0x00008731 File Offset: 0x00006931
	public static void smethod_0(object object_0, PictureBoxSizeMode pictureBoxSizeMode_0, Delegate60 delegate60_1)
	{
		delegate60_1(object_0, pictureBoxSizeMode_0);
	}

	// Token: 0x060018C6 RID: 6342
	public extern Delegate60(object object_0, IntPtr intptr_0);

	// Token: 0x060018C7 RID: 6343 RVA: 0x0000873E File Offset: 0x0000693E
	static Delegate60()
	{
		Class15.smethod_14(typeof(Delegate60).TypeHandle);
	}

	// Token: 0x04000A1C RID: 2588
	internal static Delegate60 delegate60_0;
}
