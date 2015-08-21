﻿/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OpenId.Providers
 * for more information concerning the license and the contributors participating to this project.
 */

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Security.Claims;
using Microsoft.AspNet.Authentication;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Http.Authentication;
using Microsoft.Framework.Internal;
using Newtonsoft.Json.Linq;

namespace AspNet.Security.OpenId.Notifications {
    public class OpenIdAuthenticatedNotification : BaseNotification<OpenIdAuthenticationOptions> {
        public OpenIdAuthenticatedNotification(
            [NotNull] HttpContext context,
            [NotNull] OpenIdAuthenticationOptions options)
            : base(context, options) {
        }

        public ClaimsPrincipal Principal { get; set; }

        public AuthenticationProperties Properties { get; set; }

        public string Identifier { get; [param: NotNull] set; }

        public IReadOnlyDictionary<string, string> Attributes { get; [param: NotNull] set; } = ImmutableDictionary.Create<string, string>();

        public JObject User { get; [param: NotNull] set; } = new JObject();
    }
}
