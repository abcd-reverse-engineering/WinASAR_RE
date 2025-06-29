using System;
using WinASAR.Common.Enums;
using WinASAR.Common.Helpers;

namespace WinASAR.Common.Constants
{
	// Token: 0x02000038 RID: 56
	public class FileAttributeConstants
	{
		// Token: 0x060001DE RID: 478 RVA: 0x0002617C File Offset: 0x0002437C
		public FileAttributeConstants()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x060001DF RID: 479 RVA: 0x000261B0 File Offset: 0x000243B0
		static FileAttributeConstants()
		{
			for (;;)
			{
				IL_0090:
				int num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c != 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						goto IL_0028;
					case 2:
						FileAttributeConstants.FileTypeName = EnumHelper.GetEnumDescription(FileTypes.File);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 != 0)
						{
							continue;
						}
						break;
					case 3:
						goto IL_0006;
					case 4:
						goto IL_0090;
					case 5:
						goto IL_0006;
					}
					return;
					IL_0006:
					FileAttributeConstants.RootFolderTypeName = EnumHelper.GetEnumDescription(FileTypes.RootFolder);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
					{
						continue;
					}
					IL_0028:
					FileAttributeConstants.FolderTypeName = EnumHelper.GetEnumDescription(FileTypes.Folder);
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 != 0)
					{
						return;
					}
				}
			}
		}

		// Token: 0x04000191 RID: 401
		public const string RootFolderExtension = ".rootfolder";

		// Token: 0x04000192 RID: 402
		public const int RootFolderType = 0;

		// Token: 0x04000193 RID: 403
		public static string RootFolderTypeName;

		// Token: 0x04000194 RID: 404
		public const string FolderExtension = ".folder";

		// Token: 0x04000195 RID: 405
		public const int FolderType = 1;

		// Token: 0x04000196 RID: 406
		public static string FolderTypeName;

		// Token: 0x04000197 RID: 407
		public const string FileExtension = ".file";

		// Token: 0x04000198 RID: 408
		public const int FileType = 2;

		// Token: 0x04000199 RID: 409
		public static string FileTypeName;
	}
}
