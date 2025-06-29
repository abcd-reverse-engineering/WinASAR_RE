using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns0
{
	// Token: 0x02000015 RID: 21
	[CompilerGenerated]
	[DefaultMember("FullName")]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeIdentifier]
	[ComImport]
	public interface IWshShortcut
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000F6 RID: 246
		[DispId(0)]
		[IndexerName("FullName")]
		string FullName
		{
			[DispId(0)]
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000F7 RID: 247
		// (set) Token: 0x060000F8 RID: 248
		[DispId(1000)]
		string Arguments
		{
			[DispId(1000)]
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[DispId(1000)]
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: MarshalAs(UnmanagedType.BStr)]
			[param: In]
			set;
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000F9 RID: 249
		// (set) Token: 0x060000FA RID: 250
		[DispId(1001)]
		string Description
		{
			[DispId(1001)]
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[DispId(1001)]
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: MarshalAs(UnmanagedType.BStr)]
			[param: In]
			set;
		}

		// Token: 0x060000FB RID: 251
		void _VtblGap1_2();

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000FC RID: 252
		// (set) Token: 0x060000FD RID: 253
		[DispId(1003)]
		string IconLocation
		{
			[DispId(1003)]
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[DispId(1003)]
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: MarshalAs(UnmanagedType.BStr)]
			[param: In]
			set;
		}

		// Token: 0x060000FE RID: 254
		void _VtblGap2_1();

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000FF RID: 255
		// (set) Token: 0x06000100 RID: 256
		[DispId(1005)]
		string TargetPath
		{
			[DispId(1005)]
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[DispId(1005)]
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: MarshalAs(UnmanagedType.BStr)]
			[param: In]
			set;
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000101 RID: 257
		// (set) Token: 0x06000102 RID: 258
		[DispId(1006)]
		int WindowStyle
		{
			[DispId(1006)]
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[DispId(1006)]
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000103 RID: 259
		// (set) Token: 0x06000104 RID: 260
		[DispId(1007)]
		string WorkingDirectory
		{
			[DispId(1007)]
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[DispId(1007)]
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: MarshalAs(UnmanagedType.BStr)]
			[param: In]
			set;
		}

		// Token: 0x06000105 RID: 261
		void _VtblGap3_1();

		// Token: 0x06000106 RID: 262
		[DispId(2001)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Save();
	}
}
