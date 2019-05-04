using System;

namespace ARDC.MvX.Playground.Core.Models
{
    /// <summary>
    /// Perfil de um usuário cadastrado no App.
    /// </summary>
    public class UserProfile
    {
        public string FullName { get; set; }

        public string PhoneNumber { get; set; }

        public string FullAddress { get; set; }

        public string Website { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string Nickname { get; set; }
    }
}
