using System;
using System.Runtime.InteropServices;

namespace WinASAR.Common.Helpers
{
	// Token: 0x0200002B RID: 43
	public static class Win32Helper
	{
		// Token: 0x060001CD RID: 461
		[DllImport("shell32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr SHGetFileInfo(string pszPath, Win32Helper.FileAttribute dwFileAttributes, ref Win32Helper.SHFileInfo sfi, uint cbFileInfo, Win32Helper.SHFileInfoFlags uFlags);

		// Token: 0x060001CE RID: 462
		[DllImport("shell32.dll")]
		public static extern uint ExtractIconEx(string lpszFile, int nIconIndex, int[] phiconLarge, int[] phiconSmall, uint nIcons);

		// Token: 0x060001CF RID: 463
		[DllImport("user32.dll")]
		public static extern int DestroyIcon(IntPtr hIcon);

		// Token: 0x060001D0 RID: 464
		[DllImport("urlmon.dll", CharSet = CharSet.Auto)]
		public static extern int FindMimeFromData(IntPtr pBC, [MarshalAs(UnmanagedType.LPWStr)] string pwzUrl, [MarshalAs(UnmanagedType.LPArray)] byte[] pBuffer, uint cbSize, [MarshalAs(UnmanagedType.LPWStr)] string pwzMimeProposed, uint dwMimeFlags, out IntPtr ppwzMimeOut, uint dwReserved);

		// Token: 0x060001D1 RID: 465
		[DllImport("shell32.dll", CharSet = CharSet.Auto)]
		public static extern bool ShellExecuteEx(ref Win32Helper.SHELLEXECUTEINFO lpExecInfo);

		// Token: 0x060001D2 RID: 466
		[DllImport("shell32.dll", CharSet = CharSet.Auto)]
		public static extern int SHFileOperation(ref Win32Helper.SHFILEOPSTRUCT FileOp);

		// Token: 0x060001D3 RID: 467 RVA: 0x00026068 File Offset: 0x00024268
		static Win32Helper()
		{
			for (;;)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 != 0)
				{
					goto IL_0025;
				}
				IL_003A:
				switch (num)
				{
				case 1:
					IL_0025:
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 == 0)
					{
						goto IL_0003;
					}
					goto IL_003A;
				case 2:
					continue;
				case 3:
					goto IL_0082;
				case 4:
					goto IL_0003;
				case 5:
					goto IL_0090;
				case 6:
					return;
				}
				break;
				IL_0003:
				Win32Helper.ErrorFileIndex = -2L;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 != 0)
				{
					break;
				}
				goto IL_003A;
			}
			Win32Helper.ErrorFolderIndex = -4L;
			IL_0082:
			Win32Helper.ErrorDriverIndex = -8L;
			IL_0090:
			Win32Helper.ErrorApplicationIndex = -16L;
		}

		// Token: 0x0400012C RID: 300
		public const uint SEE_MASK_INVOKEIDLIST = 12U;

		// Token: 0x0400012D RID: 301
		public const uint SW_SHOW = 5U;

		// Token: 0x0400012E RID: 302
		public static readonly long ErrorFileIndex;

		// Token: 0x0400012F RID: 303
		public static readonly long ErrorFolderIndex;

		// Token: 0x04000130 RID: 304
		public static readonly long ErrorDriverIndex;

		// Token: 0x04000131 RID: 305
		public static readonly long ErrorApplicationIndex;

		// Token: 0x04000132 RID: 306
		public const int FO_DELETE = 3;

		// Token: 0x04000133 RID: 307
		public const int FO_COPY = 1;

		// Token: 0x04000134 RID: 308
		public const int FO_MOVE = 3;

		// Token: 0x04000135 RID: 309
		public const int FOF_ALLOWUNDO = 64;

		// Token: 0x04000136 RID: 310
		public const int FOF_NOCONFIRMATION = 1048576;

		// Token: 0x04000137 RID: 311
		public const int FOF_SILENT = 262144;

		// Token: 0x04000138 RID: 312
		public const int FOF_NOERRORUI = 67108864;

		// Token: 0x0200002C RID: 44
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		public struct SHFILEOPSTRUCT
		{
			// Token: 0x0400013A RID: 314
			public IntPtr hwnd;

			// Token: 0x0400013B RID: 315
			public int wFunc;

			// Token: 0x0400013C RID: 316
			public string pFrom;

			// Token: 0x0400013D RID: 317
			public string pTo;

			// Token: 0x0400013E RID: 318
			public int fFlags;

			// Token: 0x0400013F RID: 319
			[MarshalAs(UnmanagedType.Bool)]
			public bool fAnyOperationsAborted;

			// Token: 0x04000140 RID: 320
			public IntPtr hNameMappings;

			// Token: 0x04000141 RID: 321
			public string lpszProgressTitle;
		}

		// Token: 0x0200002D RID: 45
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		public struct SHELLEXECUTEINFO
		{
			// Token: 0x04000142 RID: 322
			public int cbSize;

			// Token: 0x04000143 RID: 323
			public uint fMask;

			// Token: 0x04000144 RID: 324
			public readonly IntPtr hwnd;

			// Token: 0x04000145 RID: 325
			[MarshalAs(UnmanagedType.LPTStr)]
			public string lpVerb;

			// Token: 0x04000146 RID: 326
			[MarshalAs(UnmanagedType.LPTStr)]
			public string lpFile;

			// Token: 0x04000147 RID: 327
			[MarshalAs(UnmanagedType.LPTStr)]
			public readonly string lpParameters;

			// Token: 0x04000148 RID: 328
			[MarshalAs(UnmanagedType.LPTStr)]
			public readonly string lpDirectory;

			// Token: 0x04000149 RID: 329
			public uint nShow;

			// Token: 0x0400014A RID: 330
			public readonly IntPtr hInstApp;

			// Token: 0x0400014B RID: 331
			public readonly IntPtr lpIDList;

			// Token: 0x0400014C RID: 332
			[MarshalAs(UnmanagedType.LPTStr)]
			public readonly string lpClass;

			// Token: 0x0400014D RID: 333
			public readonly IntPtr hkeyClass;

			// Token: 0x0400014E RID: 334
			public readonly uint dwHotKey;

			// Token: 0x0400014F RID: 335
			public readonly IntPtr hIcon;

			// Token: 0x04000150 RID: 336
			public readonly IntPtr hProcess;
		}

		// Token: 0x0200002E RID: 46
		[Flags]
		public enum SHFileInfoFlags : uint
		{
			// Token: 0x04000152 RID: 338
			AddOveylays = 32U,
			// Token: 0x04000153 RID: 339
			Attr_Specified = 131072U,
			// Token: 0x04000154 RID: 340
			Attributes = 2048U,
			// Token: 0x04000155 RID: 341
			DisplayName = 512U,
			// Token: 0x04000156 RID: 342
			ExeType = 8192U,
			// Token: 0x04000157 RID: 343
			Icon = 256U,
			// Token: 0x04000158 RID: 344
			IconLocation = 4096U,
			// Token: 0x04000159 RID: 345
			LargeIcon = 0U,
			// Token: 0x0400015A RID: 346
			LinkOverlay = 32768U,
			// Token: 0x0400015B RID: 347
			OpenIcon = 2U,
			// Token: 0x0400015C RID: 348
			OverlayIndex = 64U,
			// Token: 0x0400015D RID: 349
			Pidl = 8U,
			// Token: 0x0400015E RID: 350
			Selected = 65536U,
			// Token: 0x0400015F RID: 351
			ShellIconSize = 4U,
			// Token: 0x04000160 RID: 352
			SmallIcon = 1U,
			// Token: 0x04000161 RID: 353
			SysIconIndex = 16384U,
			// Token: 0x04000162 RID: 354
			TypeName = 1024U,
			// Token: 0x04000163 RID: 355
			UseFileAttributes = 16U
		}

		// Token: 0x0200002F RID: 47
		[Flags]
		public enum FileAttribute
		{
			// Token: 0x04000165 RID: 357
			ReadOnly = 1,
			// Token: 0x04000166 RID: 358
			Hidden = 2,
			// Token: 0x04000167 RID: 359
			System = 4,
			// Token: 0x04000168 RID: 360
			Directory = 16,
			// Token: 0x04000169 RID: 361
			Archive = 32,
			// Token: 0x0400016A RID: 362
			Device = 64,
			// Token: 0x0400016B RID: 363
			Normal = 128,
			// Token: 0x0400016C RID: 364
			Temporary = 256,
			// Token: 0x0400016D RID: 365
			Sparse_File = 512,
			// Token: 0x0400016E RID: 366
			Reparse_Point = 1024,
			// Token: 0x0400016F RID: 367
			Compressed = 2048,
			// Token: 0x04000170 RID: 368
			Offline = 4096,
			// Token: 0x04000171 RID: 369
			Not_Content_Indexed = 8192,
			// Token: 0x04000172 RID: 370
			Encrypted = 16384
		}

		// Token: 0x02000030 RID: 48
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		public struct SHFileInfo
		{
			// Token: 0x04000173 RID: 371
			public readonly IntPtr hIcon;

			// Token: 0x04000174 RID: 372
			public readonly IntPtr iIcon;

			// Token: 0x04000175 RID: 373
			public readonly uint dwAttributes;

			// Token: 0x04000176 RID: 374
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
			public readonly string szDisplayName;

			// Token: 0x04000177 RID: 375
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
			public readonly string szTypeName;
		}
	}
}
