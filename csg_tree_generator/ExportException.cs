using System.Runtime.Serialization;

namespace csg_tree_generator
{
	[Serializable]
	internal class ExportException : Exception
	{
		public ExportException()
		{
		}

		public ExportException(string? message) : base(message)
		{
		}

		public ExportException(string? message, Exception? innerException) : base(message, innerException)
		{
		}

		protected ExportException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}