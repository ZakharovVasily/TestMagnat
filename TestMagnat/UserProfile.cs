using TestMagnatBL.Users.Employee;

namespace TestMagnat
{
    static class UserProfile
    {
        public static Employee Data;

        public static void EnterUserData(string userName)
        {
            var connectUserProfile = new EmployeeMySql();
            Data = connectUserProfile.GetDataProfile(userName);
        }
    }
}
