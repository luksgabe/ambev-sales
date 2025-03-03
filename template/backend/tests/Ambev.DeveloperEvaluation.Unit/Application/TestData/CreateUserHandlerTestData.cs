using Ambev.DeveloperEvaluation.Application.Users.CreateUser;
using Ambev.DeveloperEvaluation.Domain.Enums;
using Bogus;

namespace Ambev.DeveloperEvaluation.Unit.Domain;

/// <summary>
/// Provides methods for generating test data using the Bogus library.
/// This class centralizes all test data generation to ensure consistency
/// across test cases and provide both valid and invalid data scenarios.
/// </summary>
public static class CreateUserHandlerTestData
{
    /// <summary>
    /// Configures the Faker to generate valid User entities.
    /// The generated users will have valid:
    /// - Username (using internet usernames)
    /// - Password (meeting complexity requirements)
    /// - Email (valid format)
    /// - Phone (Brazilian format)
    /// - Status (Active or Suspended)
    /// - Role (Customer or Admin)
    /// </summary>
    private static readonly Faker<CreateUserCommand> createUserHandlerFaker = new Faker<CreateUserCommand>()
        .CustomInstantiator(faker => new CreateUserCommand(
            faker.Internet.UserName(),
            $"Test@{faker.Random.Number(100, 999)}",
            $"+55{faker.Random.Number(11, 99)}{faker.Random.Number(100000000, 999999999)}",
            faker.Internet.Email(),
            faker.PickRandom(new[] { UserStatus.Active, UserStatus.Suspended }),
            faker.PickRandom(new[] { UserRole.Customer, UserRole.Admin })
        ));

    /// <summary>
    /// Generates a valid User entity with randomized data.
    /// The generated user will have all properties populated with valid values
    /// that meet the system's validation requirements.
    /// </summary>
    /// <returns>A valid User entity with randomly generated data.</returns>
    public static CreateUserCommand GenerateValidCommand()
    {
        return createUserHandlerFaker.Generate();
    }
}
