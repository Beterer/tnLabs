﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.tnLabs.Core.SBDtos
{
	public class StartSessionRequest
	{
		public int SessionId { get; set; }
        public int IdentityId { get; set; }
		public Guid Version { get; set; }
	}
}
