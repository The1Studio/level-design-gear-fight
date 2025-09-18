using System.Collections.Generic;

public class AHSdkDebug
{
	public bool IsDebug { get; }

	public bool IsBlockAll { get; }

	public bool IsReportAll { get; }

	public List<string> BlockDomains { get; }

	public AHSdkDebug(bool isDebug = true, bool isBlockAll = false, bool isReportAll = false, List<string> blockDomains = null)
	{
	}
}
