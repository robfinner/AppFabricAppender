﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppFabricAppender
{
	public class BufferedAppFabricAppender : log4net.Appender.BufferingAppenderSkeleton
	{

		protected override void SendBuffer(log4net.Core.LoggingEvent[] events)
		{
			throw new NotImplementedException();
		}
	}
}
