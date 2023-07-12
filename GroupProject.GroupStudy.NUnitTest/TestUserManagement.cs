using BusinessObjects.EntityModels;
using Repositories;

namespace GroupProject.GroupStudy.NUnitTest;

public class TestUserManagement
{
	IUserRepository repo;

	[SetUp]
	public void Setup()
	{
		// Initialize the UserRepository
		repo = new UserRepository();
	}

	[Test]
	public void AddUser_ValidUser_UserAddedSuccessfully()
	{
		// Create a user 
		User user = new User
		{
			Username = "TestCreate",
			Email = "create@gmail.com",
			Password = "123",
		};

		// Add
		repo.AddNew(user);
		User addedUser = repo.GetUserById(user.UserId);

		// Assert
		Assert.IsNotNull(addedUser);
		Assert.AreEqual(user.Username, addedUser.Username);
		Assert.AreEqual(user.Email, addedUser.Email);
		Assert.AreEqual(user.Password, addedUser.Password);

		repo.Delete(user.UserId);
	}

	[Test]
	public void UpdateUser_ValidUser_UserAddedSuccessfully()
	{
		// Create a user 
		User user = new User
		{
			Username = "TestUpdate",
			Email = "update@gmail.com",
			Password = "123",
		};

		repo.AddNew(user);

		// Act
		user.Username = "UpdatedName";
		user.Password = "abc";
		repo.Update(user);

		// Assert
		User updatedUser = repo.GetUserById(user.UserId);

		Assert.IsNotNull(updatedUser);
		Assert.AreEqual(user.Username, updatedUser.Username);
		Assert.AreEqual(user.Password, updatedUser.Password);
	}

	[Test]
	public void DeleteUser_ValidUser_UserDeletedSuccessfully()
	{
		// Arrange
		User user = new User
		{
			Username = "TestDelete",
			Email = "delete@gmail.com",
			Password = "123",
		};
		repo.AddNew(user);
		User addedUser = repo.GetUserById(user.UserId);

		Assert.IsNotNull(addedUser);
		// Act
		repo.Delete(addedUser.UserId);

		// Assert
		User deletedUser = repo.GetUserById(addedUser.UserId);
		Assert.IsNull(deletedUser);
	}
}
