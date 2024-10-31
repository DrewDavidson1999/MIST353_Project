
namespace WeatherDataAppAPI.Repositories
{
	public interface INewUser
	{
        public Task<bool<NewUser>> InsertNewUserGetDetails(string userName, string email, string passwordHash);


    }
}
