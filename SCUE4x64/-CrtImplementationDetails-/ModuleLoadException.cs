using System;
using System.Runtime.Serialization;

namespace <CrtImplementationDetails>
{
	// Token: 0x02000018 RID: 24
	[Serializable]
	internal class ModuleLoadException : Exception
	{
		// Token: 0x06000054 RID: 84 RVA: 0x000021FC File Offset: 0x000015FC
		protected ModuleLoadException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000021E4 File Offset: 0x000015E4
		public ModuleLoadException(string message, Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000021D0 File Offset: 0x000015D0
		public ModuleLoadException(string message) : base(message)
		{
		}

		// Token: 0x040000E5 RID: 229
		public const string Nested = "A nested exception occurred after the primary exception that caused the C++ module to fail to load.\n";
	}
}
