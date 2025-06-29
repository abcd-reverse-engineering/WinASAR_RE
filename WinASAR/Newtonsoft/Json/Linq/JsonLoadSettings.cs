using System;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x0200015F RID: 351
	public class JsonLoadSettings
	{
		// Token: 0x06000F3F RID: 3903 RVA: 0x0007B2F0 File Offset: 0x000794F0
		public JsonLoadSettings()
		{
			for (;;)
			{
				IL_003A:
				this.lineInfoHandling_0 = LineInfoHandling.Load;
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 != 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.commentHandling_0 = CommentHandling.Ignore;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 == 0)
						{
							continue;
						}
						break;
					case 2:
						goto IL_003A;
					case 3:
						return;
					}
					goto Block_1;
				}
			}
			Block_1:
			this.duplicatePropertyNameHandling_0 = DuplicatePropertyNameHandling.Replace;
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000F40 RID: 3904 RVA: 0x000061FE File Offset: 0x000043FE
		// (set) Token: 0x06000F41 RID: 3905 RVA: 0x0007B35C File Offset: 0x0007955C
		public CommentHandling CommentHandling
		{
			get
			{
				return this.commentHandling_0;
			}
			set
			{
				IL_003E:
				while (value >= CommentHandling.Ignore)
				{
					IL_0037:
					while (value <= CommentHandling.Load)
					{
						for (;;)
						{
							this.commentHandling_0 = value;
							int num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 == 0)
							{
								switch (num)
								{
								case 1:
									return;
								case 2:
									continue;
								case 3:
									goto IL_0037;
								case 4:
									goto IL_003E;
								}
								break;
							}
							return;
						}
						break;
					}
					break;
				}
				throw new ArgumentOutOfRangeException(Class15.smethod_17(124833264 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719));
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000F42 RID: 3906 RVA: 0x00006206 File Offset: 0x00004406
		// (set) Token: 0x06000F43 RID: 3907 RVA: 0x0007B3CC File Offset: 0x000795CC
		public LineInfoHandling LineInfoHandling
		{
			get
			{
				return this.lineInfoHandling_0;
			}
			set
			{
				IL_0056:
				while (value >= LineInfoHandling.Ignore)
				{
					IL_004F:
					while (value <= LineInfoHandling.Load)
					{
						int num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 != 0)
						{
							break;
						}
						for (;;)
						{
							switch (num)
							{
							case 1:
								goto IL_004F;
							case 2:
								this.lineInfoHandling_0 = value;
								num = 3;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a == 0)
								{
									continue;
								}
								break;
							case 3:
								return;
							case 5:
								goto IL_0056;
							}
							break;
						}
						break;
					}
					IL_0061:
					throw new ArgumentOutOfRangeException(Class15.smethod_17(1743160350 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8));
				}
				goto IL_0061;
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000F44 RID: 3908 RVA: 0x0000620E File Offset: 0x0000440E
		// (set) Token: 0x06000F45 RID: 3909 RVA: 0x0007B458 File Offset: 0x00079658
		public DuplicatePropertyNameHandling DuplicatePropertyNameHandling
		{
			get
			{
				return this.duplicatePropertyNameHandling_0;
			}
			set
			{
				for (;;)
				{
					if (value >= DuplicatePropertyNameHandling.Replace)
					{
						goto IL_004B;
					}
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b == 0)
					{
						goto IL_004B;
					}
					IL_001B:
					switch (num)
					{
					case 1:
					case 4:
						goto IL_006E;
					case 2:
						continue;
					case 3:
						return;
					}
					IL_004B:
					if (value > DuplicatePropertyNameHandling.Error)
					{
						num = 4;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 == 0)
						{
							break;
						}
						goto IL_001B;
					}
					else
					{
						this.duplicatePropertyNameHandling_0 = value;
						num = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb == 0)
						{
							goto IL_001B;
						}
						return;
					}
				}
				IL_006E:
				throw new ArgumentOutOfRangeException(Class15.smethod_17(974439475 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f));
			}
		}

		// Token: 0x040006E0 RID: 1760
		private CommentHandling commentHandling_0;

		// Token: 0x040006E1 RID: 1761
		private LineInfoHandling lineInfoHandling_0;

		// Token: 0x040006E2 RID: 1762
		private DuplicatePropertyNameHandling duplicatePropertyNameHandling_0;
	}
}
