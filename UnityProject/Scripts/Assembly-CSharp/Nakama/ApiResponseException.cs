using System;
using System.Net;

namespace Nakama
{
	public class ApiResponseException : Exception
	{
		public HttpStatusCode HttpStatusCode { get; }

		public GrpcStatusCode GrpcStatusCode { get; }

		public ApiResponseException(HttpStatusCode httpStatusCode, string content, GrpcStatusCode grpcCode)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public bool IsUnAuthenticated()
		{
			return false;
		}
	}
}
