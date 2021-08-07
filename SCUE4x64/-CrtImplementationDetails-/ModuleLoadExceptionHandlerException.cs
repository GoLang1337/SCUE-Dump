using System;
using System.Runtime.Serialization;
using System.Security;

namespace <CrtImplementationDetails>
{
	// Token: 0x02000019 RID: 25
	[Serializable]
	internal class ModuleLoadExceptionHandlerException : ModuleLoadException
	{
		// Token: 0x06000057 RID: 87 RVA: 0x00002310 File Offset: 0x00001710
		protected ModuleLoadExceptionHandlerException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.NestedException = (Exception)info.GetValue("NestedException", typeof(Exception));
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002944 File Offset: 0x00001D44
		public ModuleLoadExceptionHandlerException(string message, Exception innerException, Exception nestedException) : base(message, innerException)
		{
			this.NestedException = nestedException;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00002214 File Offset: 0x00001614
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00002228 File Offset: 0x00001628
		public Exception NestedException
		{
			get
			{
				return this.<backing_store>NestedException;
			}
			set
			{
				this.<backing_store>NestedException = value;
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000223C File Offset: 0x0000163C
		public override string ToString()
		{
			string text;
			if (this.InnerException != null)
			{
				text = this.InnerException.ToString();
			}
			else
			{
				text = string.Empty;
			}
			string text2;
			if (this.NestedException != null)
			{
				text2 = this.NestedException.ToString();
			}
			else
			{
				text2 = string.Empty;
			}
			object[] array = new object[4];
			array[0] = this.GetType();
			string text3;
			if (this.Message != null)
			{
				text3 = this.Message;
			}
			else
			{
				text3 = string.Empty;
			}
			array[1] = text3;
			string text4;
			if (text != null)
			{
				text4 = text;
			}
			else
			{
				text4 = string.Empty;
			}
			array[2] = text4;
			string text5;
			if (text2 != null)
			{
				text5 = text2;
			}
			else
			{
				text5 = string.Empty;
			}
			array[3] = text5;
			return string.Format("\n{0}: {1}\n--- Start of primary exception ---\n{2}\n--- End of primary exception ---\n\n--- Start of nested exception ---\n{3}\n--- End of nested exception ---\n", array);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000022E0 File Offset: 0x000016E0
		[SecurityCritical]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("NestedException", this.NestedException, typeof(Exception));
		}

		// Token: 0x040000E6 RID: 230
		private const string formatString = "\n{0}: {1}\n--- Start of primary exception ---\n{2}\n--- End of primary exception ---\n\n--- Start of nested exception ---\n{3}\n--- End of nested exception ---\n";

		// Token: 0x040000E7 RID: 231
		private Exception <backing_store>NestedException;
	}
}
