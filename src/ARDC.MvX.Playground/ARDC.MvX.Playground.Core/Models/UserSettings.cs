using System;
using System.Collections.Generic;
using System.Text;

namespace ARDC.MvX.Playground.Core.Models
{
    /// <summary>
    /// Configurações do Usuário.
    /// </summary>
    public class UserSettings
    {
        public bool AllowEmails { get; set; }

        public bool AllowNotifications { get; set; }

        public bool AllowCalls { get; set; }

        public bool EnableTwoFactorAuthentication { get; set; }
    }
}
