﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Radical.Messaging;
using Radical.Windows.Presentation.ComponentModel;

namespace Radical.Windows.Presentation.Messaging
{
	public class ApplicationSuspend
	{
		public ApplicationSuspend( ISuspensionManager sender )
		{
            this.SuspentionManager = sender;
		}

        public ISuspensionManager SuspentionManager
        {
            get;
            private set;
        }
	}
}
