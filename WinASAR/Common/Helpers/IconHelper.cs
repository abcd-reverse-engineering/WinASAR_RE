using System;
using System.Drawing;

namespace WinASAR.Common.Helpers
{
	// Token: 0x0200002A RID: 42
	public static class IconHelper
	{
		// Token: 0x060001C2 RID: 450 RVA: 0x00025A30 File Offset: 0x00023C30
		public static Icon GetFileIcon(string fileName, bool isSmallIcon = true)
		{
			object[] array2;
			for (;;)
			{
				object[] array = new object[2];
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 == 0)
				{
					goto IL_0039;
				}
				IL_0059:
				switch (num)
				{
				case 1:
					IL_0039:
					array[0] = fileName;
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 != 0)
					{
						goto IL_0026;
					}
					goto IL_0059;
				case 2:
					continue;
				case 3:
					goto IL_0026;
				case 4:
					goto IL_0003;
				}
				break;
				IL_0003:
				array2 = Class24.smethod_1(66, array, null);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 == 0)
				{
					break;
				}
				goto IL_0059;
				IL_0026:
				array[1] = isSmallIcon;
				goto IL_0003;
			}
			return (Icon)array2[0];
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00025ADC File Offset: 0x00023CDC
		public static Icon GetFileDefaultIcon(string fileName, bool isSmallIcon = true)
		{
			object[] array;
			for (;;)
			{
				IL_0052:
				array = new object[2];
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa == 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						array[0] = fileName;
						goto IL_0003;
					case 2:
						goto IL_0052;
					case 3:
						goto IL_0003;
					case 4:
						goto IL_0082;
					}
					goto Block_2;
					IL_0003:
					array[1] = isSmallIcon;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 == 0)
					{
						goto Block_1;
					}
				}
			}
			Block_1:
			Block_2:
			object[] array2 = Class24.smethod_1(67, array, null);
			IL_0082:
			return (Icon)array2[0];
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00025B74 File Offset: 0x00023D74
		public static Icon GetFileIcon(string fileName, bool isSmallIcon, out long imageIndex, bool isExeIcon = true)
		{
			object[] array2;
			for (;;)
			{
				IL_00FF:
				object[] array = new object[4];
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 == 0)
				{
					goto IL_00A6;
				}
				for (;;)
				{
					IL_00D7:
					switch (num)
					{
					case 1:
						goto IL_00C4;
					case 2:
						goto IL_0059;
					case 3:
						goto IL_00A6;
					case 4:
						goto IL_00FF;
					case 5:
						for (;;)
						{
							array2 = Class24.smethod_1(68, array, null);
							num = 7;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
							{
								goto IL_00D7;
							}
						}
						break;
					case 6:
						goto IL_0036;
					case 7:
						imageIndex = (long)array2[1];
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa == 0)
						{
							continue;
						}
						break;
					}
					goto Block_4;
				}
				IL_0036:
				array[3] = isExeIcon;
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 != 0)
				{
					goto IL_00D7;
				}
				IL_0059:
				array[2] = imageIndex;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 != 0)
				{
					goto IL_0036;
				}
				goto IL_00D7;
				IL_00C4:
				array[1] = isSmallIcon;
				goto IL_0059;
				IL_00A6:
				array[0] = fileName;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c != 0)
				{
					goto IL_00C4;
				}
				goto IL_00D7;
			}
			Block_4:
			return (Icon)array2[0];
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00025CAC File Offset: 0x00023EAC
		public static Icon GetFolderIcon(bool isSmallIcon = true)
		{
			object[] array2;
			for (;;)
			{
				IL_0063:
				object[] array = new object[1];
				for (;;)
				{
					array[0] = isSmallIcon;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 != 0)
					{
						goto IL_0026;
					}
					do
					{
						IL_0003:
						array2 = Class24.smethod_1(69, array, null);
						num = 1;
					}
					while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e == 0);
					IL_0026:
					switch (num)
					{
					case 0:
						goto IL_0003;
					case 1:
						goto IL_0071;
					case 2:
						break;
					case 3:
						goto IL_0063;
					default:
						goto IL_0003;
					}
				}
			}
			IL_0071:
			return (Icon)array2[0];
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00025D34 File Offset: 0x00023F34
		public static Icon GetFolderIcon(bool isSmallIcon, out long imageIndex)
		{
			object[] array2;
			for (;;)
			{
				object[] array = new object[2];
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 == 0)
				{
					goto IL_0055;
				}
				IL_0068:
				switch (num)
				{
				case 0:
					goto IL_0055;
				case 1:
					continue;
				case 2:
					goto IL_00A9;
				case 3:
					goto IL_001C;
				case 4:
					break;
				case 5:
					goto IL_0006;
				default:
					goto IL_0055;
				}
				IL_002B:
				imageIndex = (long)array2[1];
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 == 0)
				{
					break;
				}
				goto IL_0068;
				IL_001C:
				array2 = Class24.smethod_1(70, array, null);
				goto IL_002B;
				IL_0006:
				array[1] = imageIndex;
				goto IL_001C;
				IL_0055:
				array[0] = isSmallIcon;
				goto IL_0006;
			}
			IL_00A9:
			return (Icon)array2[0];
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00025DF4 File Offset: 0x00023FF4
		public static Icon GetFolderIcon(string folderName, bool isSmallIcon, out long imageIndex)
		{
			object[] array2;
			for (;;)
			{
				IL_00C5:
				object[] array = new object[3];
				for (;;)
				{
					IL_00B7:
					array[0] = folderName;
					for (;;)
					{
						IL_00A4:
						array[1] = isSmallIcon;
						for (;;)
						{
							IL_007A:
							array[2] = imageIndex;
							int num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa == 0)
							{
								goto IL_0056;
							}
							do
							{
								IL_0033:
								array2 = Class24.smethod_1(71, array, null);
								num = 3;
							}
							while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa == 0);
							for (;;)
							{
								IL_0056:
								switch (num)
								{
								case 1:
									goto IL_0033;
								case 2:
									goto IL_007A;
								case 3:
									imageIndex = (long)array2[1];
									num = 0;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 != 0)
									{
										continue;
									}
									break;
								case 4:
									goto IL_00B7;
								case 5:
									goto IL_00C5;
								case 6:
									goto IL_00A4;
								}
								goto Block_3;
							}
						}
					}
				}
			}
			Block_3:
			return (Icon)array2[0];
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00025EE0 File Offset: 0x000240E0
		public static Icon GetDriverIcon(char driverMark, bool isSmallIcon = true)
		{
			object[] array2;
			for (;;)
			{
				IL_0066:
				object[] array = new object[2];
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 != 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						array[0] = driverMark;
						goto IL_0003;
					case 2:
						goto IL_0066;
					case 3:
						goto IL_0014;
					case 4:
						goto IL_0003;
					}
					goto Block_2;
					IL_0014:
					array2 = Class24.smethod_1(72, array, null);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 == 0)
					{
						goto Block_1;
					}
					continue;
					IL_0003:
					array[1] = isSmallIcon;
					goto IL_0014;
				}
			}
			Block_1:
			Block_2:
			return (Icon)array2[0];
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00025F80 File Offset: 0x00024180
		public static Icon GetDriverIcon(char driverMark, bool isSmallIcon, out long imageIndex)
		{
			object[] array2;
			for (;;)
			{
				object[] array = new object[3];
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af != 0)
				{
					goto IL_0062;
				}
				IL_0075:
				switch (num)
				{
				case 1:
					goto IL_003F;
				case 2:
					IL_0062:
					array[0] = driverMark;
					goto IL_0006;
				case 3:
					continue;
				case 4:
					goto IL_0017;
				case 5:
					goto IL_0006;
				case 6:
					goto IL_00D0;
				}
				break;
				IL_0017:
				array[2] = imageIndex;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 != 0)
				{
					goto IL_003F;
				}
				goto IL_0075;
				IL_0006:
				array[1] = isSmallIcon;
				goto IL_0017;
				IL_003F:
				array2 = Class24.smethod_1(73, array, null);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 != 0)
				{
					break;
				}
				goto IL_0075;
			}
			imageIndex = (long)array2[1];
			IL_00D0:
			return (Icon)array2[0];
		}
	}
}
