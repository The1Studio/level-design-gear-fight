using System;
using System.ComponentModel;

public class SROptions
{
	[NonSerialized]
	private const string TRUSTEDTIME = "TrustedTime";

	[Category("TrustedTime")]
	public void ResetToNow()
	{
	}

	[Category("TrustedTime")]
	public void AddOneDay()
	{
	}

	[Category("TrustedTime")]
	public void AddOneHour()
	{
	}

	[Category("TrustedTime")]
	public void MinusOneHour()
	{
	}
}
