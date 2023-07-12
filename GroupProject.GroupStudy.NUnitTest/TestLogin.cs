using BusinessObjects.EntityModels;
using GroupStudyWinApp;
using Repositories;

namespace GroupProject.GroupStudy.NUnitTest
{
	public class TestLogin
	{
		[Test]
		public void TestIsEmptyInput()
		{
			Assert.AreEqual(false, frmLogin.IsEmptyInput("", ""));
			Assert.AreEqual(false, frmLogin.IsEmptyInput("quanntn0811@gmail.com", ""));
			Assert.AreEqual(false, frmLogin.IsEmptyInput("", "123"));
			Assert.AreEqual(true, frmLogin.IsEmptyInput("quanntn0811@gmail.com", "123"));
		}

		[Test]
		public void TestIsUserExist()
		{
			Assert.AreEqual(false, frmLogin.IsUserExist("abc@gmail.com", "abc"));
			Assert.AreEqual(true, frmLogin.IsUserExist("admin@gmail.com", "1"));
			Assert.AreEqual(true, frmLogin.IsUserExist("quanntn@gmail.com", "1"));
		}
		
		[Test]
		public void TestIsAdminOrUser()
		{
			// admin
			Assert.AreEqual(true, frmLogin.IsAdminOrUser("admin@gmail.com", "1"));
			// user
			Assert.AreEqual(false, frmLogin.IsAdminOrUser("hieuht@gmail.com", "1"));
		}
	}
}