namespace ARDC.MvX.Playground.Core.Models
{
    /// <summary>
    /// Usuário cadastrado no App.
    /// </summary>
    public class User
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Email { get; set; }

        public UserProfile Profile { get; set; }

        public UserSettings Settings { get; set; }

        public override string ToString() => $"{Login}-{Email}";
    }
}
