using ARDC.MvX.Playground.Core.Models;
using Bogus;
using System;

namespace ARDC.MvX.Playground.Core.Generators
{
    /// <summary>
    /// Gerador de Usuários falsos
    /// </summary>
    public static class UserGenerator
    {
        private static int _userId = 1;

        /// <summary>
        /// Gera um usuário
        /// </summary>
        /// <returns>Um usuário gerado aleatóriamente</returns>
        public static User GenerateUser()
        {
            return new Faker<User>("pt_BR")
                .RuleFor(u => u.Id, f => _userId++)
                .RuleFor(u => u.Email, f => f.Internet.Email())
                .RuleFor(u => u.Login, f => f.Internet.UserName())
                .RuleFor(u => u.Profile, f => GenerateProfile(f))
                .RuleFor(u => u.Settings, f => GenerateSettings(f))
                .Generate();
        }

        /// <summary>
        /// Gera um perfil de usuário
        /// </summary>
        /// <param name="faker">Faker a ser utilizado para a geração</param>
        /// <returns>Um perfil de usuário gerado aleatóriamente</returns>
        private static UserProfile GenerateProfile(Faker faker)
        {
            return new Faker<UserProfile>("pt_BR")
                .RuleFor(u => u.FullName, faker.Person.FullName)
                .RuleFor(u => u.FullAddress, faker.Address.FullAddress())
                .RuleFor(u => u.Nickname, faker.Person.LastName)
                .RuleFor(u => u.PhoneNumber, faker.Person.Phone)
                .RuleFor(u => u.Website, faker.Person.Website)
                .RuleFor(u => u.DateOfBirth, faker.Random.Bool() ? (DateTime?)faker.Date.Past(50) : null)
                .Generate();
        }

        /// <summary>
        /// Gera uma configuração de usuário
        /// </summary>
        /// <param name="faker">Faker a ser utilizado para a geração</param>
        /// <returns>Uma configuração gerada aleatóriamente</returns>
        private static UserSettings GenerateSettings(Faker faker)
        {
            return new Faker<UserSettings>("pt_BR")
                .RuleFor(u => u.AllowCalls, faker.Random.Bool())
                .RuleFor(u => u.AllowEmails, faker.Random.Bool())
                .RuleFor(u => u.AllowNotifications, faker.Random.Bool())
                .RuleFor(u => u.EnableTwoFactorAuthentication, faker.Random.Bool())
                .Generate();
        }
    }
}
