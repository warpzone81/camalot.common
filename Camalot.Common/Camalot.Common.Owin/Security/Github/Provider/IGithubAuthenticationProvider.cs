﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camalot.Common.Owin.Security.Github.Provider {
	public interface IGithubAuthenticationProvider {
		Task Authenticated ( GithubAuthenticatedContext context );
		Task ReturnEndpoint ( GithubReturnEndpointContext context );
	}
}
